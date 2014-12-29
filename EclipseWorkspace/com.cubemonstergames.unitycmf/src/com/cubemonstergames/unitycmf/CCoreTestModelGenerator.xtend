package com.cubemonstergames.unitycmf

import com.cubemonstergames.unitycmf.generators.ModelGenerator
import java.io.File
import org.eclipse.emf.common.util.URI
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.resource.impl.ResourceSetImpl
import org.eclipse.emf.ecore.util.EcoreUtil

class CCoreTestModelGenerator {
	def static void main(String[] args) {
		val injector = new UnityCMFStandaloneSetup().createInjectorAndDoEMFRegistration();
		val generator = injector.getInstance(typeof(ModelGenerator));
				
		val rs = new ResourceSetImpl();
		val resource = rs.getResource(URI::createFileURI(new File("model/CCoreTest.ecore").absolutePath), true);
		EcoreUtil.resolveAll(rs);
		
		val ePackage = resource.contents.get(0) as EPackage;
		
		generator.configure(ePackage, true, false);
		generator.generateModel("../../Assets/Scripts/UnityCMF/CCoreTest/Model", "../../Assets/Scripts/UnityCMF/CCoreTest/View/");
	}
}