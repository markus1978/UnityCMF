package com.cubemonstergames.unitycmf.generators

import com.google.inject.Inject
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EPackage
import org.eclipse.xtext.generator.JavaIoFileSystemAccess

class ModelGenerator2 {
	
	public var EPackage model;
	
	public var MetaGenerator metaGenerator;
	public var ClassifierGenerator classifierGenerator;
	public var FeatureGenerator featureGenerator;
	
	@Inject	val JavaIoFileSystemAccess fsa = null;
	
	def setModel(EPackage model, boolean isGeneratingOperations) {
		this.model = model;
		
		metaGenerator = new MetaGenerator(this);
		classifierGenerator = new ClassifierGenerator(this, isGeneratingOperations);
		featureGenerator = new FeatureGenerator(this);
	}
	
	def generateModel(String targetPath) {
		generateModel(targetPath, true);
	}
	
	def generateModel(String targetPath, boolean isGeneratingOperations) {
		fsa.setOutputPath(targetPath);
		fsa.generateFile(metaGenerator.cName(model) + ".cs", metaGenerator.generateMeta(model));
		
		
		for (EClassifier eClassifier: model.EClassifiers) {
			if (eClassifier instanceof EClass) {
				fsa.generateFile(classifierGenerator.cName(eClassifier) + ".cs", classifierGenerator.generate(eClassifier as EClass));
			}
		}
		new EPackageGenerator(model).generate(fsa);
		new EFactoryGenerator(model).generate(fsa);
	}
	
	def generateMeta() {
		
	}
	
	def generateClassifier(EClassifier eClassifier) {
		
	}
	
	def generateView(String targetPath) {
		fsa.setOutputPath(targetPath);
		for (EClassifier eClassifier: model.EClassifiers) {
			if (eClassifier instanceof EClass) {		
				new CViewGenerator(model).generate(eClassifier as EClass, fsa);
			}
		}
	}
}

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