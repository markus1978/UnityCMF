package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EPackage
import org.eclipse.xtext.generator.IFileSystemAccess

import static extension com.cubemonstergames.unitycmf.generators.GenUtil.*
import org.eclipse.emf.ecore.EcorePackage

class EFactoryGenerator {
	
	val EPackage ePackage;
	
	new(EPackage ePackage) {
		this.ePackage = ePackage;
	}
	
	def generate(IFileSystemAccess fsa) {
		fsa.generateFile(ePackage.factoryInterfaceName + ".cs", '''
		«IF ePackage != EcorePackage.eINSTANCE»
			using UnityCMF.ECore;
		«ENDIF»
		
		namespace «ePackage.fullPackageName» {			 
			public interface «ePackage.factoryInterfaceName» {
				«FOR eClassifier:ePackage.EClassifiers»
					«IF eClassifier instanceof EClass»
						«(eClassifier as EClass).generatePropertiesForClassInterface»
					«ENDIF»
				«ENDFOR»
			}
			
			public class «ePackage.factoryImplementationName» : «ePackage.factoryInterfaceName» {
				«FOR eClassifier:ePackage.EClassifiers»
					«IF eClassifier instanceof EClass»
						«(eClassifier as EClass).generatePropertiesForClassImplementation»
					«ENDIF»
				«ENDFOR»
			}
		} // UnityCMF.«ePackage.name»
		''')
	}
	
	def generatePropertiesForClassInterface(EClass eClass) '''
		«eClass.classifierName» Create«eClass.name.toFirstUpper»();
	'''
	
	def generatePropertiesForClassImplementation(EClass eClass) '''
		public «eClass.classifierName» Create«eClass.name.toFirstUpper»() {
			UnityCMF.ECore.EClass eClass = «ePackage.metaName».cINSTANCE.Package.«eClass.name.toFirstUpper»;
			return new «eClass.classifierName»Impl(eClass);
		}		
	'''
}