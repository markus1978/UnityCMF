package com.cubemonstergames.kmm;

import com.cubemonstergames.unitycmf.UnityCMFStandaloneSetup
import com.cubemonstergames.unitycmf.generators.ModelGenerator
import java.io.File
import org.eclipse.emf.common.util.URI
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.resource.impl.ResourceSetImpl
import org.eclipse.emf.ecore.util.EcoreUtil

class KMMUnityCMFGenerator {
	
	def static void generate() {
		val injector = new UnityCMFStandaloneSetup().createInjectorAndDoEMFRegistration();
		val generator = injector.getInstance(typeof(ModelGenerator));
				
		val rs = new ResourceSetImpl();
		val resource = rs.getResource(URI::createFileURI(new File("model/KMM.ecore").absolutePath), true);
		EcoreUtil.resolveAll(rs);
		
		val ePackage = resource.contents.get(0) as EPackage;
		
		generator.configure(ePackage, true);
		generator.generateModel("../../Assets/Scripts/Model/", "../../Assets/Scripts/View/");
	}
	
	def static void main(String[] args) {
		generate();		
	}
}