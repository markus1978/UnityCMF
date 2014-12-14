package com.cubemonstergames.unitycmf.generators

import com.google.inject.Singleton
import org.eclipse.emf.ecore.EAnnotation
import org.eclipse.emf.ecore.EAttribute
import org.eclipse.emf.ecore.EOperation
import org.eclipse.emf.ecore.EReference
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.emf.ecore.ETypedElement
import org.eclipse.emf.ecore.EClass
import com.cubemonstergames.unitycmf.ccore.CcorePackage

@Singleton
class FeatureGenerator extends AbstractGenerator {
	
	def generatePackageInterfaceFeatureDefinition(EStructuralFeature eFeature) '''
		«IF !eFeature.filter»
			«IF eFeature instanceof EAttribute»EAttribute«ELSE»EReference«ENDIF» «eFeature.cInstanceName» { get; }
		«ENDIF»
	'''
	
	def generatePackageImplementationFeatureInitailization(EStructuralFeature eFeature) '''
		«IF !eFeature.filter»		
			«eFeature.cInstanceName» = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.Create«IF eFeature instanceof EAttribute»EAttribute«ELSE»EReference«ENDIF»();
			«eFeature.cInstanceName».Name = "«eFeature.name»";
			«eFeature.cInstanceName».LowerBound = «eFeature.lowerBound»;
			«eFeature.cInstanceName».UpperBound = «eFeature.upperBound»;
			«eFeature.cInstanceName».Derived = «eFeature.derived»;
			«eFeature.cInstanceName».EType = «modelGenerator.classifierGenerator.cInstanceRefFromPackageImplementation(eFeature.EType)»;
			«IF eFeature instanceof EReference»
				«eFeature.cInstanceName».Containment = «(eFeature as EReference).containment»;
			«ENDIF»
			«modelGenerator.classifierGenerator.cName(eFeature.EContainingClass)».EStructuralFeatures.Add(«eFeature.cInstanceName»);
		«ENDIF»
	'''
	
	def generatePackageImplementationFeatureImplementation(EStructuralFeature eFeature) '''
		«IF !eFeature.filter»
			public «IF eFeature instanceof EAttribute»EAttribute«ELSE»EReference«ENDIF» «eFeature.cInstanceName»  { get; private set;}
		«ENDIF»
	'''
	
	def generateFeatureInterface(EStructuralFeature eFeature) '''
		«IF !eFeature.filter»
			«IF eFeature.many»
				«IF eFeature.dimendionsOf2dFieldAsStr != null»
					C2DField<«eFeature.cTypeRef»> «eFeature.cName» { get; }
				«ELSE»
					CList<«eFeature.cTypeRef»> «eFeature.cName» { get; }
				«ENDIF»
			«ELSE»
				«eFeature.cTypeRef» «eFeature.cName» { get; «IF !eFeature.derived»set;«ENDIF» }
			«ENDIF»
		«ENDIF»
	'''
	
	def generateOperationInterface(EOperation eOperation) '''
		«eOperation.cTypeRef» «eOperation.cName»(«eOperation.generateParameters»);
	'''
	
	def generateParameters(EOperation eOperation) '''«FOR eParameter:eOperation.EParameters SEPARATOR ', '»«eParameter.cTypeRef» «eParameter.name»«ENDFOR»'''
	
	def generateFeatureImplementation(EStructuralFeature eFeature) '''
		«IF !eFeature.filter»
			«IF eFeature.many»
				«val dimensions2dField=eFeature.dimendionsOf2dFieldAsStr»
				«IF dimensions2dField!=null»
					«IF !eFeature.derived»					
						private C2DField<«eFeature.cTypeRef»> «eFeature.cLocalName»;
					«ENDIF»
					public C2DField<«eFeature.cTypeRef»> «eFeature.cName» {
						«IF eFeature.derived»
							«eFeature.generateDerivedFeatureImplentationBlock('''C2DField<«eFeature.cTypeRef»>''')»
						«ELSE»
							get {
								if («eFeature.cLocalName» == null) {
									EStructuralFeature feature = «eFeature.cInstanceRef»;
									«eFeature.cLocalName» = new C2DField<«eFeature.cTypeRef»>(«dimensions2dField», this, feature);
								}
								return «eFeature.cLocalName»;
							}
						«ENDIF»
					}
				«ELSE»
					«IF !eFeature.derived»
						private CList<«eFeature.cTypeRef»> «eFeature.cLocalName»;
					«ENDIF»
					public CList<«eFeature.cTypeRef»> «eFeature.cName» {
						«IF eFeature.derived»
							«eFeature.generateDerivedFeatureImplentationBlock('''CList<«eFeature.cTypeRef»>''')»
						«ELSE»
							get {
								if («eFeature.cLocalName» == null) {
									EStructuralFeature feature = «eFeature.cInstanceRef»;
									«eFeature.cLocalName» = new CList<«eFeature.cTypeRef»>(this, feature);
								}
								return «eFeature.cLocalName»;
							}
						«ENDIF»
					}
				«ENDIF»
			«ELSE»
				«IF !eFeature.derived»
					private «eFeature.cTypeRef» «eFeature.cLocalName»;
				«ENDIF»
				public «eFeature.cTypeRef» «eFeature.cName» {
					«IF eFeature.derived»
						«eFeature.generateDerivedFeatureImplentationBlock(eFeature.cTypeRef)»
					«ELSE»
						get { return «eFeature.cLocalName»; }
						set {
							«eFeature.cTypeRef» oldValue = «eFeature.cLocalName»;
							«eFeature.cLocalName» = value;
							«IF eFeature instanceof EReference && (eFeature as EReference).containment»
								if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
								if (value != null) (value as CObjectImpl).CContainer = this;
							«ENDIF»
							if (CNotificationRequired(«eFeature.cInstanceRef»)) {
								CNotify(new CAction(this, CActionType.SET, «eFeature.cInstanceRef», oldValue, value, -1));
							}	
						}
					«ENDIF»
				}
			«ENDIF»
		«ENDIF»
	'''
	
	private def String dimendionsOf2dFieldAsStr(EStructuralFeature eFeature) {
		if (eFeature instanceof EReference && 
				(eFeature as EReference).containment &&
				CcorePackage.eINSTANCE.c2DFieldElement.isSuperTypeOf((eFeature.EType as EClass))) {
			for(EAnnotation annotation: eFeature.EAnnotations) {
				if (annotation.source.endsWith("UnityCMF") && annotation.details.get("InstanceSet") != null) {
					return annotation.details.get("InstanceSet") as String;
				}
			}
		}
		return null;		
	}
	
	private def generateDerivedFeatureImplentationBlock(EStructuralFeature eFeature, String typeRefStr) '''
		get {
			// PROTECTED REGION ID(«modelGenerator.classifierGenerator.cName(eFeature.EContainingClass)».«eFeature.cName») ENABLED START
			return default(«typeRefStr»);
			// PROTECTED REGION END
		}
	'''
	
	private def uniqueName(EOperation eOperation) '''«eOperation.EContainingClass.name».«eOperation.name»_«FOR eParameter:eOperation.EParameters SEPARATOR '_'»«eParameter.cTypeRef»«ENDFOR»'''
	
	def generateOperationImplementation(EOperation eOperation) '''
		public virtual «eOperation.cTypeRef» «eOperation.cName»(«eOperation.generateParameters») {
			// PROTECTED REGION ID(«eOperation.uniqueName») ENABLED START
			throw new System.InvalidOperationException("Unsupported Operation «eOperation.EContainingClass.name».«eOperation.name»(«FOR eParameter:eOperation.EParameters SEPARATOR ','»«eParameter.cTypeRef»«ENDFOR»)");
			// PROTECTED REGION END
		}
	'''
	
	def generateReflectiveSet(EStructuralFeature eFeature) '''
		«IF !eFeature.filter && !eFeature.many && !eFeature.derived»
			case "«eFeature.name»" : 
				«eFeature.cName» = («eFeature.cTypeRef»)value;
				break;															
		«ENDIF»
	'''
	
	def generateReflectiveGet(EStructuralFeature eFeature) '''
		«IF !eFeature.filter»
			case "«eFeature.name»" : 
				return «eFeature.cName»;															
		«ENDIF»
	'''
	
	def generateFeatureInitialization(EStructuralFeature eFeature) '''
		«IF !eFeature.filter && eFeature.many && !eFeature.derived»
			«val dimensions2dField=eFeature.dimendionsOf2dFieldAsStr»
			«IF dimensions2dField!=null»
				«eFeature.cLocalName» = new C2DField<«eFeature.cTypeRef»>(«dimensions2dField», this, «eFeature.cInstanceRef», true);			
			«ENDIF»
		«ENDIF»
	'''
	
	private def cTypeRef(ETypedElement eFeature) { 
		if (eFeature.EType == null) { 
			return "void";
		} else {
			modelGenerator.classifierGenerator.cRef(eFeature.EType)
		}
	}
	
	private def cLocalName(EStructuralFeature eFeature) '''_«eFeature.name.toFirstLower»'''
	
	def cName(EStructuralFeature eFeature) '''«eFeature.name.toFirstUpper»'''
	
	def cName(EOperation eOperation) { eOperation.name.toFirstUpper }
	
	private def cInstanceName(EStructuralFeature eFeature) '''«modelGenerator.classifierGenerator.cName(eFeature.EContainingClass)»_«eFeature.cName»'''
	
	def cInstanceRef(EStructuralFeature eFeature) '''«modelGenerator.metaGenerator.cPackageInstanceRef(eFeature.EContainingClass.EPackage)».«cInstanceName(eFeature)»'''
	
	def boolean filter(EStructuralFeature eFeature) {
		return modelGenerator.classifierGenerator.filter(eFeature.EType);
	}
}