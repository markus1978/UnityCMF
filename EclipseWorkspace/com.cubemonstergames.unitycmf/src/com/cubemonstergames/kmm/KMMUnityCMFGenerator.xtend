package com.cubemonstergames.kmm;

import com.cubemonstergames.unitycmf.UnityCMFStandaloneSetup
import com.cubemonstergames.unitycmf.generators.ModelGenerator
import org.eclipse.emf.common.util.URI
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.resource.impl.ResourceSetImpl
import org.eclipse.emf.ecore.util.EcoreUtil
import org.eclipse.emf.ecore.EClass
import java.io.File

class KMMUnityCMFGenerator {
	def static void main(String[] args) {
		val injector = new UnityCMFStandaloneSetup().createInjectorAndDoEMFRegistration();
		val generator = injector.getInstance(typeof(ModelGenerator));
				
		val rs = new ResourceSetImpl();
		val resource = rs.getResource(URI::createFileURI(new File("model/KMM.ecore").absolutePath), true);
		EcoreUtil.resolveAll(rs);
		
		val ePackage = resource.contents.get(0) as EPackage;
		val t = (ePackage.getEClassifier("Tile") as EClass).getEStructuralFeature("onCurrentPath").EType;
		EcoreUtil.resolve(t, rs);
		
		generator.generateModel(ePackage, "../../Assets/Scripts/Model/");
		generator.generateView(ePackage, "../../Assets/Scripts/View/");
		
	}
}