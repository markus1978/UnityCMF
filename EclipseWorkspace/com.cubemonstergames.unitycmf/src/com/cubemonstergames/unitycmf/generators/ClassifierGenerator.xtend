package com.cubemonstergames.unitycmf.generators

import com.google.inject.Singleton
import java.util.ArrayList
import java.util.HashMap
import java.util.List
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EEnum
import org.eclipse.emf.ecore.EOperation
import org.eclipse.emf.ecore.EReference
import org.eclipse.emf.ecore.EStructuralFeature

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
	
	def CharSequence generatatePackageImplementationClassifierInitialization(EClassifier eClassifier) '''
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
				«eClass.cRef» «eClass.cCreateInstanceName»;
			«ENDIF»
		«ENDIF»
	'''
	
	def generateFactoryImplementation(EClassifier eClassifier) '''
		«IF eClassifier instanceof EClass»
			«val eClass = eClassifier as EClass»
			«IF !eClass.abstract && !eClass.interface»
				public «eClass.cRef» «eClass.cCreateInstanceName» {
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
			«IF modelGenerator.isGeneratingOperations»
				«FOR eOperation:eClass.EOperations»
					«modelGenerator.featureGenerator.generateOperationDelegate(eOperation)»
				«ENDFOR»
			«ENDIF»
			«eClass.generateInterface»
			
			«IF !eClass.interface»
				«eClass.generateImplementation»
			«ENDIF»
			
			«eClass.generateBuilder»
		
		} // UnityCMF.«eClass.EPackage.name»
	'''
	
	def generateInterface(EClass eClass) '''
		public interface «eClass.cName» : «IF eClass.EAllSuperTypes.empty»CObject«ELSE»«FOR superClass:eClass.EAllSuperTypes SEPARATOR ','»«superClass.name»«ENDFOR»«ENDIF» {
			«FOR eFeature:eClass.EStructuralFeatures»
				«modelGenerator.featureGenerator.generateFeatureInterface(eFeature)»
			«ENDFOR»
			«IF eClass.incommingCompositeReferences.size == 1»
				«modelGenerator.featureGenerator.generateImplicentContainerPropertyInterface(eClass.incommingCompositeReferences.get(0))»
			«ENDIF»
			
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
			«IF eClass.incommingCompositeReferencesToImplement.size == 1»
				«modelGenerator.featureGenerator.generateImplicentContainerPropertyImplementation(eClass.incommingCompositeReferencesToImplement.get(0))»
			«ENDIF»
			
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
			
			public override void CRemoveContent(CObject value) {
				switch(value.CContainingFeature.Name) {
					«FOR eFeature:eClass.featuresToImplement»
						«modelGenerator.featureGenerator.generateReflectiveRemoveContent(eFeature)»
					«ENDFOR»
					default:
						«IF eClass.superTypeToExtent == null»
							throw new System.ArgumentException();
						«ELSE»
							base.CRemoveContent(value);
							break;
						«ENDIF»
				}
			}
		}
	'''
	
	def generateBuilder(EClass eClass) '''
		public interface «eClass.cBuilderName»«IF !eClass.ESuperTypes.empty»: «FOR superType:eClass.ESuperTypes SEPARATOR ","»«superType.cBuilderName»«ENDFOR»«ENDIF» {
			«eClass.cRef» «eClass.cBuildProperty» { get; }
		}

		«IF !eClass.interface»
			public class «eClass.cBuilderName»Impl: «eClass.cBuilderName» {
			
				private «eClass.cRef» _build;
				
				«FOR superType:eClass.EAllSuperTypes»
					public «superType.cRef» «superType.cBuildProperty» {
						get {
							return _build as «superType.cRef»;
						}
					}
					
				«ENDFOR»
				public «eClass.cRef» «eClass.cBuildProperty» {
					get {
						return _build as «eClass.cRef»;
					}
				}
				
				private «eClass.cBuilderName»Impl(«eClass.cRef» build) 
				{
					_build = build;
				}
				
				«IF !eClass.abstract && !eClass.interface»
					public static «eClass.cBuilderImplRef» New() {
						return new «eClass.cBuilderName»Impl(«eClass.cCreateInstanceRef»);
					}
				«ENDIF»
				
				«FOR eFeature:eClass.EAllStructuralFeatures»
					«IF !eFeature.derived»
						«modelGenerator.featureGenerator.generateFeatureBuilder(eClass, eFeature)»
					«ENDIF»
				«ENDFOR»
			}
		«ENDIF»
	'''
	
	def cName(EClassifier eClassifier) {
		return eClassifier.name.toFirstUpper;
	}
	
	private def cImplementationName(EClassifier eClassifier) '''«eClassifier.cName»Impl''' 
		
	private def cBuilderName(EClass eClass) '''«eClass.cName»Builder'''
	
	private def cInstanceName(EClassifier eClassifier) { cName(eClassifier) }
	
	def cImplementationRef(EClassifier eClassifier) {
		if (eClassifier.EPackage == modelGenerator.model) {
			return eClassifier.cImplementationName;
		} else {
			return '''«modelGenerator.metaGenerator.cNamespaceRef(eClassifier.EPackage)».«eClassifier.cImplementationName»'''
		}
	}
	
	def cBuilderImplRef(EClass eClass) {
		return '''«eClass.cBuilderRef»Impl'''
	}
	
	def cBuilderRef(EClass eClass) {
		if (eClass.EPackage == modelGenerator.model) {
			return '''«eClass.cBuilderName»''';
		} else {
			return '''«modelGenerator.metaGenerator.cNamespaceRef(eClass.EPackage)».«eClass.cBuilderName»'''
		}
	}
	
	def cBuildProperty(EClass eClass) {
		return '''Build«eClass.cName»'''
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
			if (eClassifier.name.equals("ELong")) return "long"
			if (eClassifier.name.equals("EFloat")) return "float"				
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
			eClassifier.name.equals("ELong") ||
			eClassifier.name.equals("EFloat") ||
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
		for (EClass superType: eClass.ESuperTypes) {
			if (superType != superTypeToExtent(eClass) && !superType.interface) {
				result.addAll(superType.featuresToImplement);
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
	
	private def String cCreateInstanceName(EClass eClass) '''Create«eClass.cName»()'''
	
	def String cCreateInstanceRef(EClass eClass) '''«modelGenerator.metaGenerator.cFactoryInstanceRef(eClass.EPackage)».Create«eClass.cName»()'''
	
	private val incommingCompositeReferencesCache = new HashMap<EClass, List<EReference>>() 
	private def List<EReference> incommingCompositeReferencesToImplement(EClass eClass) {
		val result = eClass.incommingCompositeReferences;
		for (EClass superType: eClass.EAllSuperTypes) {
			if (superType != eClass.superTypeToExtent && !eClass.superTypeToExtent.EAllSuperTypes.contains(superType)) {
				result.addAll(superType.incommingCompositeReferences);
			}
		}
		return result;	
	}
	private def List<EReference> incommingCompositeReferences(EClass eClass) {
		var result = incommingCompositeReferencesCache.get(eClass);
		if (result == null) {
			result = new ArrayList<EReference>();
			incommingCompositeReferencesCache.put(eClass, result);
			val inheritedIncomingReferences = new ArrayList<EReference>();
			for(EClass superType: eClass.EAllSuperTypes) {
				inheritedIncomingReferences.addAll(incommingCompositeReferences(superType));
			}
			for(EClassifier eClassifier: eClass.EPackage.EClassifiers) {
				if (eClassifier instanceof EClass && eClassifier != eClass) {
					val otherClass = eClassifier as EClass;
					for (EReference incomingReference: otherClass.EReferences) {
						if (!incomingReference.EAnnotations.exists[it.details.get("withoutImplicitContainer") != null]) {
							if (incomingReference.EType == eClass) {
								if (incomingReference.containment && !incomingReference.derived) {
									var alreadyHasACorrespondingFeature = false;
									for (EStructuralFeature eFeature: eClass.EAllStructuralFeatures) {
										val one = modelGenerator.featureGenerator.cName(eFeature).toString
										val two = cName(incomingReference.EContainingClass).toString
										if (one.equals(two)) {
											alreadyHasACorrespondingFeature = true;
										}
									}
									for (EReference inheritedIncomingReference: inheritedIncomingReferences) {
										if (cName(inheritedIncomingReference.EContainingClass).toString.equals(cName(incomingReference.EContainingClass).toString)) {
											alreadyHasACorrespondingFeature = true;
										}	
									}
									if (!alreadyHasACorrespondingFeature && filterIncomingReferences(incomingReference)) {									
										result.add(incomingReference);
									}
								}
							}	
						}
					}
				}
			}		
		}
		return result;
	}
	
	def boolean filterIncomingReferences(EReference incomingReference) {
		if (incomingReference.EContainingClass.name.toLowerCase.equals("eclass")) {
			return false;
		}
		return true;
	}
}