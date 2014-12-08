package com.cubemonstergames.unitycmf

import com.cubemonstergames.unitycmf.generators.ModelGenerator
import org.eclipse.emf.common.util.URI
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.EcorePackage
import org.eclipse.emf.ecore.resource.impl.ResourceSetImpl

class BootstrapECore {
	def static void main(String[] args) {
		val injector = new UnityCMFStandaloneSetup().createInjectorAndDoEMFRegistration();
		val generator = injector.getInstance(typeof(ModelGenerator));
		
		// generate ECore classes, package, and factory
		generator.generateModel(EcorePackage.eINSTANCE, "../../Assets/Scripts/UnityCMF/ECore/", false);	
		
		// generate CCore classes, package, and factory
		val rs = new ResourceSetImpl();
		val resource = rs.getResource(URI::createFileURI("model/CCore.ecore"), true);
		val ccore = resource.contents.get(0) as EPackage;
		generator.generateModel(ccore, "../../Assets/Scripts/UnityCMF/CCore/");
	}
}