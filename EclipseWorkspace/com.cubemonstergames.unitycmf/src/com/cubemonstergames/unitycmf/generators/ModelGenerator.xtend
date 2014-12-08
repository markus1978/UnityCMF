package com.cubemonstergames.unitycmf.generators

import com.google.inject.Inject
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EPackage
import org.eclipse.xtext.generator.JavaIoFileSystemAccess

class ModelGenerator {
	@Inject	val JavaIoFileSystemAccess fsa = null;
	
	def generateModel(EPackage model, String targetPath) {
		generateModel(model, targetPath, true);
	}
	
	def generateModel(EPackage model, String targetPath, boolean isGeneratingOperations) {
		fsa.setOutputPath(targetPath);
		for (EClassifier eClassifier: model.EClassifiers) {
			if (eClassifier instanceof EClass) {
				new EClassGenerator(model, isGeneratingOperations).generate(eClassifier as EClass, fsa);
			}
		}
		new EPackageGenerator(model).generate(fsa);
		new EFactoryGenerator(model).generate(fsa);
	}
	
	def generateView(EPackage ePackage, String targetPath) {
		fsa.setOutputPath(targetPath);
		for (EClassifier eClassifier: ePackage.EClassifiers) {
			if (eClassifier instanceof EClass) {		
				new CViewGenerator(ePackage).generate(eClassifier as EClass, fsa);
			}
		}
	}
}