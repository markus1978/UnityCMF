package com.cubemonstergames.unitycmf

import com.cubemonstergames.unitycmf.generators.ModelGenerator2
import org.eclipse.emf.common.util.URI
import org.eclipse.emf.ecore.EAttribute
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.EcoreFactory
import org.eclipse.emf.ecore.EcorePackage
import org.eclipse.emf.ecore.resource.impl.ResourceSetImpl
import org.eclipse.emf.ecore.EClass

class BootstrapECore {
	def static void main(String[] args) {
		val injector = new UnityCMFStandaloneSetup().createInjectorAndDoEMFRegistration();
		val generator = injector.getInstance(typeof(ModelGenerator2));
		
		// generate CCore classes, package, and factory
		val rs = new ResourceSetImpl();
		val resource = rs.getResource(URI::createFileURI("model/CCore.ecore"), true);
		val ccore = resource.contents.get(0) as EPackage;
		val cPackageDataType = ccore.getEClassifier("CPackage") as EDataType;
		
		val EPackage ecore = EcorePackage.eINSTANCE;
		val EAttribute cPackageAttr = EcoreFactory.eINSTANCE.createEAttribute();
		cPackageAttr.name = "cPackage";
		cPackageAttr.setEType(cPackageDataType);
		(ecore.getEClassifier("EClassifier") as EClass).EStructuralFeatures.add(cPackageAttr);
		
		generator.setModel(ecore, false);
		generator.generateModel("../../Assets/Scripts/UnityCMF/ECore/");	
		
		generator.setModel(ccore, true);
		generator.generateModel("../../Assets/Scripts/UnityCMF/CCore/");
	}
}