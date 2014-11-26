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
				public static «ePackage.factoryInterfaceName»Factory cINSTANCE = new «ePackage.factoryImplementationName»();
				
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
		UnityCMF.ECore.EClass Create«eClass.name.toFirstUpper»();
	'''
	
	def generatePropertiesForClassImplementation(EClass eClass) '''
		public UnityCMF.ECore.EClass Create«eClass.name.toFirstUpper»() {
			UnityCMF.ECore.EClass eClass = UnityCMF.«ePackage.name.toFirstUpper».«ePackage.name.toFirstUpper»Package.cINSTANCE.«eClass.name.toFirstUpper»;
			return new UnityCMF.«ePackage.name.toFirstUpper».«eClass.name.toFirstLower»Impl(eClass);
		}		
	'''
}