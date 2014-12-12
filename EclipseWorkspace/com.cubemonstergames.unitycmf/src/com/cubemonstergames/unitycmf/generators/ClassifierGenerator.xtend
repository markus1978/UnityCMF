package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EEnum

class ClassifierGenerator {
	val ModelGenerator2 modelGenerator;
	val boolean isGeneratingOperations;
	
	new(ModelGenerator2 modelGenerator, boolean isGeneratingOperations) {
		this.modelGenerator = modelGenerator;
		this.isGeneratingOperations = isGeneratingOperations;
	}
	
	def generatatePackageInterfacePropertyDefinition(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			EClass «eClass.cInstanceName» { get; }
			«FOR eFeature:eClass.EStructuralFeatures»
				«modelGenerator.featureGenerator.generatePackageInterfaceFeatureDefinition(eFeature)»				
			«ENDFOR»
		«ELSE»
			«val eDataType = eClassifier as EDataType»
			EDataType «eDataType.cInstanceName» { get; }
		«ENDIF»
	'''
	
	def generatatePackageImplementationClassifierInitialization(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			«eClass.cInstanceName» = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			«eClass.cInstanceName».Name = "«eClass.name»";
			«eClass.cInstanceName».CPackage = «modelGenerator.metaGenerator.cPackageInstanceRefFromPackageImplementation(eClass.EPackage)»;
		«ELSE»
			«val eDataType = eClassifier as EDataType»
			«eDataType.cInstanceName» = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			«eDataType.cInstanceName».Name = "«eDataType.name»";
			«eDataType.cInstanceName».CPackage = «modelGenerator.metaGenerator.cPackageInstanceRefFromPackageImplementation(eDataType.EPackage)»;
		«ENDIF»
	'''
	
	def generatatePackageImplementationFeatureInitialization(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			«FOR eFeature:eClass.EStructuralFeatures»	
				«modelGenerator.featureGenerator.generatePackageImplementationFeatureInitailization(eFeature)»
			«ENDFOR»
		«ENDIF»
	'''
	
	def generatatePackageImplementationPropertyImplementation(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			public EClass «eClass.cInstanceName» { get; private set;}
			«FOR eFeature:eClass.EStructuralFeatures»
				«modelGenerator.featureGenerator.generatePackageImplementationFeatureImplementation(eFeature)»				
			«ENDFOR»
		«ELSE»
			«val eDataType = eClassifier as EDataType»
			public EDataType «eDataType.cInstanceName» { get; private set;}		
		«ENDIF»
	'''
	
	def generateFactoryInterface(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			«eClass.cRef» Create«eClass.cName»();
		«ENDIF»
	'''
	
	def generateFactoryImplementation(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			public «eClass.cRef» Create«eClass.cName»() {
				UnityCMF.ECore.EClass eClass = «eClass.cInstanceRef»;
				return new «eClass.cImplementationRef»(eClass);
			}
		«ENDIF»
	'''
	
	def generate(EClass eClass) '''
		using UnityCMF.CCore;
		using UnityCMF.ECore;
		
		namespace «modelGenerator.metaGenerator.cNamespaceName(eClass.EPackage)» {
			«eClass.generateInterface»
			«eClass.generateImplementation»
		
		} // UnityCMF.«eClass.EPackage.name»
	'''
	
	def generateInterface(EClass eClass) '''
		public interface «eClass.cName» : «IF eClass.EAllSuperTypes.empty»CObject«ELSE»«FOR superClass:eClass.EAllSuperTypes SEPARATOR ','»«superClass.name»«ENDFOR»«ENDIF» {
			«FOR eFeature:eClass.EStructuralFeatures»
				«modelGenerator.featureGenerator.generateFeatureInterface(eFeature)»
			«ENDFOR»
			
			«IF isGeneratingOperations»
				«FOR eOperation:eClass.EOperations»
					«modelGenerator.featureGenerator.generateOperationInterface(eOperation)»
				«ENDFOR»
			«ENDIF»
		}
	'''
	
	def generateImplementation(EClass eClass) '''
		public class «eClass.cImplementationName» : «IF eClass.ESuperTypes.empty»CObjectImpl«ELSE»«eClass.ESuperTypes.get(0).cImplementationRef»«ENDIF», «eClass.cRef» {
			// PROTECTED REGION ID(«eClass.cName».custom) ENABLED START
		
			// PROTECTED REGION END
			
			public «eClass.name.toFirstUpper»Impl(UnityCMF.ECore.EClass eClass) : base(eClass) {
				«FOR eFeature:eClass.EStructuralFeatures»
					«modelGenerator.featureGenerator.generateFeatureInitialization(eFeature)»
				«ENDFOR»
				// PROTECTED REGION ID(«eClass.cName».constructor) ENABLED START
		
				// PROTECTED REGION END
			}
			«IF isGeneratingOperations»
				«FOR eOperation:eClass.EOperations»
					«modelGenerator.featureGenerator.generateOperationImplementation(eOperation)»
				«ENDFOR»
			«ENDIF»
			
			«FOR eFeature:eClass.EStructuralFeatures»
				«modelGenerator.featureGenerator.generateFeatureImplementation(eFeature)»
			«ENDFOR»
			
			public override void CSet(EStructuralFeature feature, object value) {
				switch(feature.Name) {
				«FOR eFeature:eClass.EStructuralFeatures»
					«modelGenerator.featureGenerator.generateReflectiveSet(eFeature)»
				«ENDFOR»
					default: 
						throw new System.ArgumentException();
				}
			}
			
			public override object CGet(EStructuralFeature feature) {
				switch(feature.Name) {
				«FOR eFeature:eClass.EStructuralFeatures»
					«modelGenerator.featureGenerator.generateReflectiveGet(eFeature)»
				«ENDFOR»
					default: 
						throw new System.ArgumentException();
				}
			}
		}
	'''
	
	def cName(EClassifier eClassifier) {
		return eClassifier.name.toFirstUpper;
	}
	
	private def cImplementationName(EClassifier eClassifier) '''«eClassifier.cName»Impl''' 
		
	private def cInstanceName(EClassifier eClassifier) { cName(eClassifier) }
	
	def cImplementationRef(EClassifier eClassifier) {
		if (eClassifier.EPackage == modelGenerator.model) {
			return eClassifier.cImplementationName;
		} else {
			return '''«modelGenerator.metaGenerator.cNamespaceRef(eClassifier.EPackage)».«eClassifier.cImplementationName»'''
		}
	}
	
	def cInstanceRef(EClassifier eClassifier) '''«modelGenerator.metaGenerator.cPackageInstanceRef(eClassifier.EPackage)».«eClassifier.cInstanceName»'''
	
	def cInstanceRefFromPackageImplementation(EClassifier eClassifier) '''«modelGenerator.metaGenerator.cPackageInstanceRefFromPackageImplementation(eClassifier.EPackage)».«eClassifier.cInstanceName»'''
	
	def cRef(EClassifier eClassifier) {
		if (eClassifier == null) return 'void';
		
		if (eClassifier instanceof EDataType) {
			if (!(eClassifier instanceof EEnum)) {
				val annotation = eClassifier.EAnnotations.findFirst[a|a.source.endsWith("UnityCMF")]
				if (annotation != null) {
					val instanceClass = annotation.details.get("CInstanceClass");
					if (instanceClass != null) {
						return instanceClass;
					}
				} 
			}
			
			if (eClassifier.name.equals("EInt")) return "int"
			if (eClassifier.name.equals("EString")) return "string"
			if (eClassifier.name.equals("EDouble")) return "float"
			if (eClassifier.name.equals("EBoolean")) return "bool"				
		}
		
		if (eClassifier.EPackage == modelGenerator.model) {
			return eClassifier.cName;
		} else {
			return '''«modelGenerator.metaGenerator.cNamespaceRef(eClassifier.EPackage)».«eClassifier.cName»'''
		}
	}
	
	def filter(EClassifier eClassifier) {
		return ! (eClassifier instanceof EClass || 
			eClassifier.name.equals("EInt") ||
			eClassifier.name.equals("EString") ||
			eClassifier.name.equals("EDouble") ||
			eClassifier.name.equals("EBoolean") ||
			eClassifier instanceof EEnum ||
			eClassifier.EAnnotations.exists[a|a.source.endsWith("UnityCMF") && a.details.get("CInstanceClass") != null])
	}
}