package com.cubemonstergames.unitycmf.generators

import com.google.inject.Inject
import com.google.inject.Singleton
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EPackage
import org.eclipse.xtext.generator.JavaIoFileSystemAccess

@Singleton
class ModelGenerator extends AbstractGenerator {
	
	public var EPackage model;
	public var boolean isGeneratingOperations;
	public var boolean withAbstractViews;
	
	@Inject	val JavaIoFileSystemAccess modelFsa = null;
	@Inject	val JavaIoFileSystemAccess viewFsa = null;
	
	def configure(EPackage model, boolean isGeneratingOperations, boolean withAbstractViews) {
		this.model = model;
		this.isGeneratingOperations = isGeneratingOperations;
		this.withAbstractViews = withAbstractViews;
	}
	
	def generateModel(String modelPath, String viewPath) {
		modelFsa.setOutputPath(modelPath);
		if (viewPath != null) {
			viewFsa.setOutputPath(viewPath);
		}
		
		modelFsa.generateFile(metaGenerator.cName(model) + ".cs", metaGenerator.generateMeta(model));
		
		for (EClassifier eClassifier: model.EClassifiers) {
			if (eClassifier instanceof EClass) {
				val eClass = eClassifier as EClass;
				modelFsa.generateFile(classifierGenerator.cName(eClass) + ".cs", classifierGenerator.generate(eClass));
				if (!viewGenerator.filter(eClass)) {
					viewFsa.generateFile(viewGenerator.cViewName(eClass) + ".cs", viewGenerator.generate(eClass));				
				}
			}
		}
	}
}