package com.cubemonstergames.kmm;

import com.cubemonstergames.unitycmf.UnityCMFStandaloneSetup
import com.cubemonstergames.unitycmf.generators.CViewGenerator
import com.cubemonstergames.unitycmf.generators.EClassGenerator
import com.cubemonstergames.unitycmf.generators.EFactoryGenerator
import com.cubemonstergames.unitycmf.generators.EPackageGenerator
import org.eclipse.emf.common.util.URI
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.resource.impl.ResourceSetImpl
import org.eclipse.xtext.generator.JavaIoFileSystemAccess

class KMMUnityCMFGenerator {
	def static void main(String[] args) {
		val injector = new UnityCMFStandaloneSetup().createInjectorAndDoEMFRegistration();
		val fsa = injector.getInstance(typeof(JavaIoFileSystemAccess));		
		fsa.setOutputPath("../../Assets/Scripts/Model/");
		
		val rs = new ResourceSetImpl();
		val resource = rs.getResource(URI::createFileURI("model/KMM.ecore"), true);
		val ePackage = resource.contents.get(0) as EPackage;
		
		for (EClassifier eClassifier: ePackage.EClassifiers) {
			if (eClassifier instanceof EClass) {
				new EClassGenerator(ePackage).generate(eClassifier as EClass, fsa);		
			}
		}
		new EPackageGenerator(ePackage).generate(fsa);
		new EFactoryGenerator(ePackage).generate(fsa);
		
		fsa.setOutputPath("../../Assets/Scripts/View/");
		for (EClassifier eClassifier: ePackage.EClassifiers) {
			if (eClassifier instanceof EClass) {		
				new CViewGenerator(ePackage).generate(eClassifier as EClass, fsa);
			}
		}
	}
}