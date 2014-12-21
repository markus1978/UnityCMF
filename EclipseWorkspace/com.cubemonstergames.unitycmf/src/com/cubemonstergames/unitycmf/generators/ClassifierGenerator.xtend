package com.cubemonstergames.unitycmf.generators

import com.google.inject.Singleton
import java.util.ArrayList
import java.util.List
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EEnum
import org.eclipse.emf.ecore.EOperation
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.emf.ecore.impl.BasicEObjectImpl

@Singleton
class ClassifierGenerator extends AbstractGenerator {
	
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
			«IF !eClass.abstract && !eClass.interface»
				«eClass.cRef» Create«eClass.cName»();
			«ENDIF»
		«ENDIF»
	'''
	
	def generateFactoryImplementation(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			«IF !eClass.abstract && !eClass.interface»
				public «eClass.cRef» Create«eClass.cName»() {
					UnityCMF.ECore.EClass eClass = «eClass.cInstanceRef»;
					return new «eClass.cImplementationRef»(eClass);
				}
			«ENDIF»
		«ENDIF»
	'''
	
	def generateFactoryReflectiveImplementation(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			«IF !eClass.abstract && !eClass.interface»
				case "«eClassifier.name»": return new «modelGenerator.classifierGenerator.cImplementationRef(eClassifier)»(eClass);
			«ENDIF»
		«ENDIF»
	'''
	
	def generate(EClass eClass) '''
		using UnityCMF.CCore;
		using UnityCMF.ECore;
		// PROTECTED REGION ID(«eClass.cName».Namespaces) ENABLED START
		
		// PROTECTED REGION END
		
		namespace «modelGenerator.metaGenerator.cNamespaceName(eClass.EPackage)» {
			«eClass.generateInterface»
			«IF !eClass.interface»
				«eClass.generateImplementation»
			«ENDIF»
		
		} // UnityCMF.«eClass.EPackage.name»
	'''
	
	def generateInterface(EClass eClass) '''
		public interface «eClass.cName» : «IF eClass.EAllSuperTypes.empty»CObject«ELSE»«FOR superClass:eClass.EAllSuperTypes SEPARATOR ','»«superClass.name»«ENDFOR»«ENDIF» {
			«FOR eFeature:eClass.EStructuralFeatures»
				«modelGenerator.featureGenerator.generateFeatureInterface(eFeature)»
			«ENDFOR»
			
			«IF modelGenerator.isGeneratingOperations»
				«FOR eOperation:eClass.EOperations»
					«modelGenerator.featureGenerator.generateOperationInterface(eOperation)»
				«ENDFOR»
			«ENDIF»
		}
	'''
	
	def generateImplementation(EClass eClass) '''
		public class «eClass.cImplementationName» : «IF eClass.superTypeToExtent == null»CObjectImpl«ELSE»«eClass.superTypeToExtent.cImplementationRef»«ENDIF», «eClass.cRef» {
		
			public «eClass.name.toFirstUpper»Impl(UnityCMF.ECore.EClass eClass) : base(eClass) {
				«FOR eFeature:eClass.featuresToImplement»
					«modelGenerator.featureGenerator.generateFeatureInitialization(eFeature)»
				«ENDFOR»
				// PROTECTED REGION ID(«eClass.cName».Constructor) ENABLED START
		
				// PROTECTED REGION END
			}
			
			#region client code
			// PROTECTED REGION ID(«eClass.cName».ClientCode) ENABLED START
		
			// PROTECTED REGION END
			#endregion				
		
			#region derived features and operations
			«FOR eFeature:eClass.featuresToImplement»
				«IF eFeature.derived»
					«modelGenerator.featureGenerator.generateFeatureImplementation(eFeature)»
				«ENDIF»
			«ENDFOR»
			
			«IF modelGenerator.isGeneratingOperations»
				«FOR eOperation:eClass.operationsToImplement»
					«modelGenerator.featureGenerator.generateOperationImplementation(eOperation)»
				«ENDFOR»
			«ENDIF»
			#endregion
			
			«FOR eFeature:eClass.featuresToImplement»
				«IF !eFeature.derived»
					«modelGenerator.featureGenerator.generateFeatureImplementation(eFeature)»
				«ENDIF»
			«ENDFOR»
			
			public override void CSet(EStructuralFeature feature, object value) {
				switch(feature.Name) {
					«FOR eFeature:eClass.featuresToImplement»
						«modelGenerator.featureGenerator.generateReflectiveSet(eFeature)»
					«ENDFOR»
					default: 
						«IF eClass.superTypeToExtent == null»
							throw new System.ArgumentException();
						«ELSE»
							base.CSet(feature, value);
							break;
						«ENDIF»
				}
			}
			
			public override object CGet(EStructuralFeature feature) {
				switch(feature.Name) {
					«FOR eFeature:eClass.featuresToImplement»
						«modelGenerator.featureGenerator.generateReflectiveGet(eFeature)»
					«ENDFOR»
					default: 
						«IF eClass.superTypeToExtent == null»
							throw new System.ArgumentException();
						«ELSE»
							return base.CGet(feature);
						«ENDIF»
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
		if (eClassifier.name == null) System.out.println("## " + (eClassifier as BasicEObjectImpl).eProxyURI);
		return ! (eClassifier instanceof EClass || 
			eClassifier.name.equals("EInt") ||
			eClassifier.name.equals("EString") ||
			eClassifier.name.equals("EDouble") ||
			eClassifier.name.equals("EBoolean") ||
			eClassifier instanceof EEnum ||
			eClassifier.EAnnotations.exists[a|a.source.endsWith("UnityCMF") && a.details.get("CInstanceClass") != null])
	}
	
	def EClass superTypeToExtent(EClass eClass) {
		var EClass lastSuitableSuperType = null;
		for(EClass superType: eClass.EAllSuperTypes) {
			if (!superType.interface) {
				lastSuitableSuperType = superType;
			}
		}
		return lastSuitableSuperType;
	}
	
	def List<EStructuralFeature> featuresToImplement(EClass eClass) {
		val result = new ArrayList<EStructuralFeature>();
		result.addAll(eClass.EStructuralFeatures);
		for (EClass superType: eClass.EAllSuperTypes) {
			if (superType.interface) {
				result.addAll(superType.EStructuralFeatures);		
			}
		}
		for (EClass superType: eClass.EAllSuperTypes) {
			if (!superType.interface) {
				result.removeAll(superType.featuresToImplement);		
			}
		}
		return result;
	}
	
	def List<EOperation> operationsToImplement(EClass eClass) {
		val result = new ArrayList<EOperation>();
		result.addAll(eClass.EOperations);
		for (EClass superType: eClass.EAllSuperTypes) {
			if (superType.interface) {
				result.addAll(superType.EOperations);		
			}
		}
		for (EClass superType: eClass.EAllSuperTypes) {
			if (!superType.interface) {
				result.removeAll(superType.operationsToImplement);		
			}
		}
		return result;
	}
}