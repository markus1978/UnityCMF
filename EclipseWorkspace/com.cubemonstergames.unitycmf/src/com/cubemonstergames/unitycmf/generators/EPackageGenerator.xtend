package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EPackage
import org.eclipse.xtext.generator.IFileSystemAccess
import org.eclipse.emf.ecore.EClass

import static extension com.cubemonstergames.unitycmf.generators.GenUtil.*
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.emf.ecore.EcorePackage
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EEnum

class EPackageGenerator {
	val EPackage ePackage;
	
	new(EPackage ePackage) {
		this.ePackage = ePackage;
	}
	
	def generate(IFileSystemAccess fsa) {
		fsa.generateFile(ePackage.packageInterfaceName + ".cs", '''
		«IF ePackage != EcorePackage.eINSTANCE»
			using UnityCMF.ECore;
		«ENDIF»
		
		namespace «ePackage.fullPackageName» {
		«FOR eEnum:ePackage.EClassifiers.filter[c|c instanceof EEnum]»
			public enum «eEnum.name» { «FOR literal:(eEnum as EEnum).ELiterals SEPARATOR ", "»«literal.name»«ENDFOR» }
		«ENDFOR»
			 
			public sealed class «ePackage.metaName» {
				public static «ePackage.metaName» cINSTANCE = new «ePackage.metaName»();
				public «ePackage.packageInterfaceName» Package { get; private set; }
				public «ePackage.factoryInterfaceName» Factory { get; private set; }
				public «ePackage.metaName»() {
					Package = new «ePackage.packageImplementationName»();
					Factory = new «ePackage.factoryImplementationName»();
				}
			}
			
			public interface «ePackage.packageInterfaceName» {
				«FOR eClassifier:ePackage.EClassifiers»
					«IF eClassifier instanceof EClass»
						«(eClassifier as EClass).generatePropertiesForClassInterface»
					«ELSE»
						«(eClassifier as EDataType).generatePropertiesForDataTypeInterface»
					«ENDIF»
				«ENDFOR»
			}
			
			public class «ePackage.packageImplementationName» : «ePackage.packageInterfaceName» {
				public «ePackage.packageImplementationName»() {
					«FOR eClassifier:ePackage.EClassifiers»
						«IF eClassifier instanceof EClass»
							«(eClassifier as EClass).generatePropertiesForClassInitialization»
						«ELSE»
							«(eClassifier as EDataType).generatePropertiesForDataTypeInitialization»
						«ENDIF»
					«ENDFOR»
				}
				
				«FOR eClassifier:ePackage.EClassifiers»
					«IF eClassifier instanceof EClass»
						«(eClassifier as EClass).generatePropertiesForClassImplementation»
					«ELSE»
						«(eClassifier as EDataType).generatePropertiesForDataTypeImplementation»
					«ENDIF»
				«ENDFOR»
			}
		} // UnityCMF.«ePackage.name»
		''')
	}
	
	static def packageFeatureProperty(EStructuralFeature eFeature) {
		return '''«eFeature.EContainingClass.classifierName»_«eFeature.name»'''
	}
	
	def generatePropertiesForClassInterface(EClass eClass) '''
		EClass «eClass.name.toFirstUpper» { get; }
		«FOR eFeature:eClass.EStructuralFeatures»
			«IF !eFeature.filter»
				EStructuralFeature «eFeature.packageFeatureProperty» { get; }
			«ENDIF»
		«ENDFOR»
	'''
	
	def generatePropertiesForDataTypeInterface(EDataType eDataType) '''
		EDataType «eDataType.name.toFirstUpper» { get; }
	'''
	
	def generatePropertiesForClassImplementation(EClass eClass) '''
		public EClass «eClass.name.toFirstUpper» { get; private set;}
		«FOR eFeature:eClass.EStructuralFeatures»
			«IF !eFeature.filter»
				public EStructuralFeature «eFeature.packageFeatureProperty»  { get; private set;}
			«ENDIF»
		«ENDFOR»
	'''
	
	def generatePropertiesForDataTypeImplementation(EDataType eDataType) '''
		public EDataType «eDataType.name.toFirstUpper» { get; private set;}		
	'''
	
	def generatePropertiesForDataTypeInitialization(EDataType eDataType) '''
		«eDataType.name.toFirstUpper» = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
		«eDataType.name.toFirstUpper».Name = "«eDataType.name»";
	'''
	
	def generatePropertiesForClassInitialization(EClass eClass) '''
		«eClass.name.toFirstUpper» = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
		«eClass.name.toFirstUpper».Name = "«eClass.name»";
		«FOR eFeature:eClass.EStructuralFeatures»	
			«IF !eFeature.filter»		
				«eClass.name.toFirstUpper»_«eFeature.name» = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
				«eClass.name.toFirstUpper»_«eFeature.name».Name = "«eFeature.name»";
				«eClass.name.toFirstUpper»_«eFeature.name».LowerBound = «eFeature.lowerBound»;
				«eClass.name.toFirstUpper»_«eFeature.name».UpperBound = «eFeature.upperBound»;
				«eClass.name.toFirstUpper»_«eFeature.name».EType = «eFeature.EType.EPackage.metaName».cINSTANCE.Package.«eFeature.EType.name.toFirstUpper»;
				«eClass.name.toFirstUpper».EStructuralFeatures.Add(«eClass.name.toFirstUpper»_«eFeature.name»);
			«ENDIF»
		«ENDFOR»
				
	'''
}
	