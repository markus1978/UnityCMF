package com.cubemonstergames.unitycmf.generators

import com.google.inject.Singleton
import org.eclipse.emf.ecore.EAnnotation
import org.eclipse.emf.ecore.EAttribute
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EOperation
import org.eclipse.emf.ecore.EReference
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.emf.ecore.ETypedElementimport org.eclipse.emf.ecore.EModelElement

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
		«IF eOperation.delegate»
			«eOperation.cDelegateName» «eOperation.cName» { get; set; }
		«ELSE»
			«eOperation.cTypeRef» «eOperation.cName»(«eOperation.generateParameters»);
		«ENDIF»
	'''
	
	def generateOperationDelegate(EOperation eOperation) '''
		«IF eOperation.delegate»
			public delegate «eOperation.cTypeRef» «eOperation.cDelegateName»(«eOperation.generateParameters»);
		«ENDIF»
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
					public «eFeature.virtual» C2DField<«eFeature.cTypeRef»> «eFeature.cName» {
						«IF eFeature.derived»
							«eFeature.generateDerivedFeatureImplentationBlock('''C2DField<«eFeature.cTypeRef»>''')»
						«ELSE»
							get {
								if («eFeature.cLocalName» == null) {
									EStructuralFeature feature = «eFeature.cInstanceRef»;
									«eFeature.cLocalName» = new C2DField<«eFeature.cTypeRef»>(«dimensions2dField», «eFeature.instanceSet», this, feature);
								}
								return «eFeature.cLocalName»;
							}
						«ENDIF»
					}
				«ELSE»
					«IF !eFeature.derived»
						private CList<«eFeature.cTypeRef»> «eFeature.cLocalName»;
					«ENDIF»
					public «eFeature.virtual» CList<«eFeature.cTypeRef»> «eFeature.cName» {
						«IF eFeature.derived»
							«eFeature.generateDerivedFeatureImplentationBlock('''CList<«eFeature.cTypeRef»>''')»
						«ELSE»
							get {
								if («eFeature.cLocalName» == null) {
									EStructuralFeature feature = «eFeature.cInstanceRef»;
									«eFeature.cLocalName» = new CList<«eFeature.cTypeRef»>(«eFeature.instanceSet», this, feature);
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
				public «eFeature.virtual» «eFeature.cTypeRef» «eFeature.cName» {
					«IF eFeature.derived»
						«eFeature.generateDerivedFeatureImplentationBlock(eFeature.cTypeRef)»
					«ELSE»
						get {
							«IF eFeature.instanceSet»
								if («eFeature.cLocalName» == null) {
									«eFeature.cLocalName» = «metaGenerator.cFactoryInstanceRef(eFeature.EType.EPackage)».create(«classifierGenerator.cInstanceRef(eFeature.EType)») as «classifierGenerator.cName(eFeature.EType)»;
								}
							«ENDIF»
							return «eFeature.cLocalName»;
						}
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
		if (eFeature instanceof EReference) {
			for(EAnnotation annotation: eFeature.EAnnotations) {
				if (annotation.source.endsWith("UnityCMF") && annotation.details.get("Dimensions") != null) {
					return annotation.details.get("Dimensions") as String;
				}
			}
		}
		return null;		
	}
	
	private def boolean isInstanceSet(EStructuralFeature eFeature) {
		if (eFeature instanceof EReference && (eFeature as EReference).containment) {
			for(EAnnotation annotation: eFeature.EAnnotations) {
				if (annotation.source.endsWith("UnityCMF") && annotation.details.get("Instances") != null) {
					return true;
				}
			}
		}
		return false;
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
		«IF eOperation.delegate»
			public «eOperation.cDelegateName» «eOperation.cName» { get; set; }
		«ELSE»
			public «eOperation.virtual» «eOperation.cTypeRef» «eOperation.cName»(«eOperation.generateParameters») {
				// PROTECTED REGION ID(«eOperation.uniqueName») ENABLED START
				throw new System.InvalidOperationException("Unsupported Operation «eOperation.EContainingClass.name».«eOperation.name»(«FOR eParameter:eOperation.EParameters SEPARATOR ','»«eParameter.cTypeRef»«ENDFOR»)");
				// PROTECTED REGION END
			}
		«ENDIF»
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
	
	def generateReflectiveRemoveContent(EStructuralFeature eFeature) '''
		«IF !eFeature.filter && eFeature instanceof EReference && (eFeature as EReference).containment && !eFeature.derived»
			case "«eFeature.name»" :
				«IF eFeature.many»
					«cLocalName(eFeature)».RemoveAt(«cLocalName(eFeature)».IndexOf(value)); 
				«ELSE»
					«cName(eFeature)» = null;
				«ENDIF» 
				break;
		«ENDIF»
	'''
	
	def generateFeatureInitialization(EStructuralFeature eFeature) '''
		«IF !eFeature.filter && !eFeature.derived && eFeature.instanceSet»
			«IF eFeature.many»
				«val dimensions2dField=eFeature.dimendionsOf2dFieldAsStr»
				«IF dimensions2dField!=null»
					«eFeature.cLocalName» = new C2DField<«eFeature.cTypeRef»>(«dimensions2dField», «eFeature.instanceSet», this, «eFeature.cInstanceRef»);			
				«ELSE»
					«eFeature.cLocalName» = new CList<«eFeature.cTypeRef»>(«eFeature.instanceSet», this, «eFeature.cInstanceRef»);
				«ENDIF»
			«ELSE»
				«eFeature.cName» = «modelGenerator.classifierGenerator.cCreateInstanceRef(eFeature.EType as EClass)»;
			«ENDIF»
		«ENDIF»
	'''
	
	def generateImplicentContainerPropertyInterface(EReference reference) '''
		«modelGenerator.classifierGenerator.cRef(reference.EContainingClass)» «modelGenerator.classifierGenerator.cName(reference.EContainingClass)» { get; }
	'''
	
	def generateImplicentContainerPropertyImplementation(EReference reference) '''
		public «modelGenerator.classifierGenerator.cRef(reference.EContainingClass)» «modelGenerator.classifierGenerator.cName(reference.EContainingClass)» { 
			get { 
				return CContainer as «modelGenerator.classifierGenerator.cRef(reference.EContainingClass)»;
			}
		}
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
	
	private def boolean delegate(EOperation eOperation) {
		for(EAnnotation annotation: eOperation.EAnnotations) {
			if (annotation.source.endsWith("UnityCMF") && annotation.details.get("Delegate") != null) {
				return annotation.details.get("Delegate").equals("true");
			}
		}	
		return false;
	}
	
	private def String virtual(EModelElement eFeature) {
		for(EAnnotation annotation: eFeature.EAnnotations) {
			if (annotation.source.endsWith("UnityCMF") && annotation.details.get("virtual") != null) {
				if (annotation.details.get("virtual").equals("true")) {
					return "virtual";
				}
			}
		}	
		return "";
	}
	
	private def cDelegateName(EOperation eOperation) '''«modelGenerator.classifierGenerator.cName(eOperation.EContainingClass)»_«eOperation.cName»'''
}