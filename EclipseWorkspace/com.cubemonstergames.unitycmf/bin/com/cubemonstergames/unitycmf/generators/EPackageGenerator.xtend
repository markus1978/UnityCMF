package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EPackage
import org.eclipse.xtext.generator.IFileSystemAccess
import org.eclipse.emf.ecore.EClass

import static extension com.cubemonstergames.unitycmf.generators.GenUtil.*
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.emf.ecore.EcorePackage

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
			public interface «ePackage.packageInterfaceName» {
				public static «ePackage.packageInterfaceName» cINSTANCE = new «ePackage.packageImplementationName»();
				
				«FOR eClassifier:ePackage.EClassifiers»
					«IF eClassifier instanceof EClass»
						«(eClassifier as EClass).generatePropertiesForClassInterface»
					«ENDIF»
				«ENDFOR»
			}
			
			public class «ePackage.packageImplementationName» : «ePackage.packageInterfaceName» {
				public «ePackage.packageImplementationName»() {
					«FOR eClassifier:ePackage.EClassifiers»
						«IF eClassifier instanceof EClass»
							«(eClassifier as EClass).generatePropertiesForClassInitialization»
						«ENDIF»
					«ENDFOR»
				}
				
				«FOR eClassifier:ePackage.EClassifiers»
					«IF eClassifier instanceof EClass»
						«(eClassifier as EClass).generatePropertiesForClassImplementation»
					«ENDIF»
				«ENDFOR»
			}
		} // UnityCMF.«ePackage.name»
		''')
	}
	
	def packageFeatureProperty(EStructuralFeature eFeature) {
		return '''«eFeature.EContainingClass.classifierName»_«eFeature.name»'''
	}
	
	def generatePropertiesForClassInterface(EClass eClass) '''
		UnityCMF.ECore.EClass «eClass.name.toFirstUpper» { get; }
		«FOR eFeature:eClass.EStructuralFeatures»
			«IF !eFeature.filter»
				EStructuralFeature «eFeature.packageFeatureProperty» { get; }
			«ENDIF»
		«ENDFOR»
	'''
	
	def generatePropertiesForClassImplementation(EClass eClass) '''
		public UnityCMF.ECore.EClass «eClass.name.toFirstUpper» { public get; private set;}
		«FOR eFeature:eClass.EStructuralFeatures»
			«IF !eFeature.filter»
				public EStructuralFeature «eFeature.packageFeatureProperty»  { public get; private set;}
			«ENDIF»
		«ENDFOR»
	'''
	
	def generatePropertiesForClassInitialization(EClass eClass) '''
		«eClass.name.toFirstUpper» = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEClass();
		«eClass.name.toFirstUpper».Name = "«eClass.name»";
		«FOR eFeature:eClass.EStructuralFeatures»	
			«IF !eFeature.filter»		
				«eClass.name.toFirstUpper»_«eFeature.name» = UnityCMF.ECore.ECoreFactory.cINSTANCE.CreateEStructuralFeature();
				«eClass.name.toFirstUpper»_«eFeature.name».Name = "«eFeature.name»";
				«eClass.name.toFirstUpper»_«eFeature.name».Many = «eFeature.many»;
				«eClass.name.toFirstUpper»_«eFeature.name».EType = UnityCMF.«eFeature.EType.EPackage.name.toFirstUpper».«eFeature.EType.EPackage.name.toFirstUpper»Package.cINSTANCE.«eFeature.EType.name.toFirstUpper»;
				«eClass.name.toFirstUpper».EStructuralFeatures.Add(«eClass.name.toFirstUpper»_«eFeature.name»);
			«ENDIF»
		«ENDFOR»
				
	'''
}
	