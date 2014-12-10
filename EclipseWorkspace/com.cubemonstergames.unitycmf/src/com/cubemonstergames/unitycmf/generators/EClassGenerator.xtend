package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.xtext.generator.IFileSystemAccess
import org.eclipse.emf.ecore.EPackage

import static extension com.cubemonstergames.unitycmf.generators.GenUtil.*
import org.eclipse.emf.ecore.EAnnotation
import org.eclipse.emf.ecore.EOperation
import org.eclipse.emf.ecore.ETypedElement
import org.eclipse.emf.ecore.EParameter
import org.eclipse.emf.ecore.EEnum

class EClassGenerator {
	
	val EPackage ePackage;
	val boolean isGeneratingOperations;
	
	new(EPackage ePackage, boolean isGeneratingOperations) {
		this.ePackage = ePackage;
		this.isGeneratingOperations = isGeneratingOperations;
	}
	
	def generate(EClass eClass, IFileSystemAccess fsa) {
		fsa.generateFile(eClass.getName() + ".cs", '''
		using UnityCMF.CCore;
		using UnityCMF.ECore;
		
		namespace «ePackage.fullPackageName» {
			 
			public interface «eClass.classifierName» : «eClass.superInterfaceDeclaration» {
				«FOR eFeature:eClass.EStructuralFeatures»
					«IF !eFeature.filter»
						«eFeature.generateFeatureInterface»
					«ENDIF»
				«ENDFOR»
				
				«IF isGeneratingOperations»
					«FOR eOperation:eClass.EOperations»
						«eOperation.generateOperationInterface»
					«ENDFOR»
				«ENDIF»
			}
			
			public class «eClass.classifierName»Impl : «IF eClass.ESuperTypes.empty»CObjectImpl«ELSE»«eClass.ESuperTypes.get(0).classifierName»Impl«ENDIF», «eClass.classifierName» {
				// PROTECTED REGION ID(«eClass.classifierName».custom) ENABLED START
			
				// PROTECTED REGION END
				
				public «eClass.name.toFirstUpper»Impl(UnityCMF.ECore.EClass eClass) : base(eClass) {
					«FOR eFeature:eClass.EStructuralFeatures»
						«IF !eFeature.filter»
							«eFeature.generateFeatureInitialization»
						«ENDIF»
					«ENDFOR»
					// PROTECTED REGION ID(«eClass.classifierName».constructor) ENABLED START
			
					// PROTECTED REGION END
				}
		
				«IF isGeneratingOperations»
					«FOR eOperation:eClass.EOperations»
						«eOperation.generateOperationImplementation»
					«ENDFOR»
				«ENDIF»
				
				«FOR eFeature:eClass.EStructuralFeatures»
					«IF !eFeature.filter»
						«eFeature.generateFeatureImplementation»
					«ENDIF»
				«ENDFOR»
				
				public override void CSet(EStructuralFeature feature, object value) {
					switch(feature.Name) {
					«FOR eFeature:eClass.EStructuralFeatures»
						«IF !eFeature.filter && !eFeature.many && !eFeature.derived»
						case "«eFeature.name»" : 
							«eFeature.propertyName» = («eFeature.EType.typeReference»)value;
							break;															
						«ENDIF»
					«ENDFOR»
						default: 
							throw new System.ArgumentException();
					}
				}
				
				public override object CGet(EStructuralFeature feature) {
					switch(feature.Name) {
					«FOR eFeature:eClass.EStructuralFeatures»
						«IF !eFeature.filter»
						case "«eFeature.name»" : 
							return «eFeature.propertyName»;															
						«ENDIF»
					«ENDFOR»
						default: 
							throw new System.ArgumentException();
					}
				}
			}
		} // UnityCMF.«eClass.EPackage.name»
		''')
	} 
	
	def superInterfaceDeclaration(EClass eClass) '''«IF eClass.EAllSuperTypes.empty»CObject«ELSE»«FOR superClass:eClass.EAllSuperTypes SEPARATOR ','»«superClass.name»«ENDFOR»«ENDIF»'''
	
	def generateTypeReference(ETypedElement eTypedElement) '''«
		IF eTypedElement.many
			»«IF eTypedElement.dimendionsOf2dField != null
				»C2DField<«eTypedElement.EType.typeReference»>«
			ELSE
				»CList<«eTypedElement.EType.typeReference»>«
			ENDIF»«
		ELSE»«eTypedElement.EType.typeReference»«
		ENDIF»'''
	
	def generateFeatureInterface(EStructuralFeature eFeature) '''
		«eFeature.generateTypeReference» «eFeature.propertyName» { get; «IF !eFeature.many && !eFeature.derived»set;«ENDIF» }
	'''
	
	def generateOperationInterface(EOperation eOperation) '''
		«eOperation.generateTypeReference» «eOperation.name»(«FOR eParameter:eOperation.EParameters SEPARATOR ', '»«eParameter.generateParameter»«ENDFOR»);
	'''
	
	def generateParameter(EParameter parameter)	'''«parameter.generateTypeReference» «parameter.name»'''
	
	def featureMetaReference(EStructuralFeature feature) '''«ePackage.metaName».cINSTANCE.Package.«feature.EContainingClass.name»_«feature.name»'''
	
	def generateFeatureImplementation(EStructuralFeature eFeature) '''
		«IF eFeature.many»
			«val dimensions2dField=eFeature.dimendionsOf2dField»
			«IF dimensions2dField!=null»
				private C2DField<«eFeature.EType.typeReference»> _«eFeature.propertyName»;
				public C2DField<«eFeature.EType.typeReference»> «eFeature.propertyName» {
					«IF eFeature.derived»
						«eFeature.generateDerivedFeatureImplentationBlock('''C2DField<«eFeature.EType.typeReference»>''')»
					«ELSE»
						get {
							if (_«eFeature.propertyName» == null) {
								EStructuralFeature feature = «eFeature.featureMetaReference»;
								_«eFeature.propertyName» = new C2DField<«eFeature.EType.typeReference»>(«dimensions2dField», this, feature);
							}
							return _«eFeature.propertyName»;
						}
					«ENDIF»
				}
			«ELSE»
				private CList<«eFeature.EType.typeReference»> _«eFeature.propertyName»;
				public CList<«eFeature.EType.typeReference»> «eFeature.propertyName» {
					«IF eFeature.derived»
						«eFeature.generateDerivedFeatureImplentationBlock('''CList<«eFeature.EType.typeReference»>''')»
					«ELSE»
						get {
							if (_«eFeature.propertyName» == null) {
								EStructuralFeature feature = «eFeature.featureMetaReference»;
								_«eFeature.propertyName» = new CList<«eFeature.EType.typeReference»>(this, feature);
							}
							return _«eFeature.propertyName»;
						}
					«ENDIF»
				}
			«ENDIF»
		«ELSE»
			private «eFeature.EType.typeReference» _«eFeature.propertyName»;
			public «eFeature.EType.typeReference» «eFeature.propertyName» {
				«IF eFeature.derived»
					«eFeature.generateDerivedFeatureImplentationBlock(eFeature.EType.typeReference)»
				«ELSE»
					get { return _«eFeature.propertyName»; }
					set {
						«eFeature.EType.typeReference» oldValue = _«eFeature.propertyName»;
						_«eFeature.propertyName» = value;
						
						if (CNotificationRequired(«eFeature.featureMetaReference()»)) {
							CNotify(new CAction(this, CActionType.SET, «eFeature.featureMetaReference», oldValue, value, -1));
						}	
					}
				«ENDIF»
			}
		«ENDIF»
	'''
	
	def generateDerivedFeatureImplentationBlock(EStructuralFeature eFeature, String typeRef) '''
		get {
			// PROTECTED REGION ID(«eFeature.EContainingClass.classifierName».«eFeature.name») ENABLED START
			return default(«typeRef»);
			// PROTECTED REGION END
		}
	'''
	
	def generateFeatureInitialization(EStructuralFeature eFeature) '''
		«IF eFeature.many && !eFeature.derived»
			«val dimensions2dField=eFeature.dimendionsOf2dField»
			«IF dimensions2dField!=null»
				_«eFeature.propertyName» = new C2DField<«eFeature.EType.typeReference»>(«dimensions2dField», this, feature, true);			
			«ENDIF»
		«ENDIF»
	'''
	
	def uniqueName(EOperation eOperation) '''«eOperation.EContainingClass.name».«eOperation.name»_«FOR eParameter:eOperation.EParameters SEPARATOR '_'»«eParameter.EType.name»«ENDFOR»'''
	
	def generateOperationImplementation(EOperation eOperation) '''
		public virtual «eOperation.generateTypeReference» «eOperation.name»(«FOR eParameter:eOperation.EParameters SEPARATOR ', '»«eParameter.generateParameter»«ENDFOR») {
			// PROTECTED REGION ID(«eOperation.uniqueName») ENABLED START
			throw new System.InvalidOperationException("Unsupported Operation «eOperation.EContainingClass.name».«eOperation.name»(«FOR eParameter:eOperation.EParameters SEPARATOR ','»«eParameter.EType.name»«ENDFOR»)");
			// PROTECTED REGION END
		}
	'''
	
	def typeReference(EClassifier type) {
		if (type == null) return 'void';
		if (type instanceof EDataType) {
			if (type instanceof EEnum) {
				return type.name;
			}
			val annotation = type.EAnnotations.findFirst[a|a.source.endsWith("UnityCMF")]
			if (annotation != null) {
				val instanceClass = annotation.details.get("CInstanceClass");
				if (instanceClass != null) {
					return instanceClass;
				}
			} 
			return (type as EDataType).primitiveTypeReference			
		} else if (type instanceof EClass) {
			if (type.EPackage == ePackage) {
				return type.classifierName;
			}
			return '''«type.EPackage.fullPackageName».«type.classifierName»'''
		}
	}
	
	def String dimendionsOf2dField(ETypedElement eTypedElement) {
		for(EAnnotation annotation: eTypedElement.EAnnotations) {
			if (annotation.source.endsWith("UnityCMF") && annotation.details.get("2DField") != null) {
				return annotation.details.get("2DField") as String;
			}
		}
		return null;
	}
}