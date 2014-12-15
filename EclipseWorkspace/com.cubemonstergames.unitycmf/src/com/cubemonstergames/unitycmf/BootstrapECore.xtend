package com.cubemonstergames.unitycmf

import com.cubemonstergames.unitycmf.ccore.CcorePackage
import com.cubemonstergames.unitycmf.generators.ModelGenerator
import org.eclipse.emf.ecore.EAttribute
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.EcoreFactory
import org.eclipse.emf.ecore.EcorePackage

class BootstrapECore {
	def static void bootstrapECore(String basePath) {
		val injector = new UnityCMFStandaloneSetup().createInjectorAndDoEMFRegistration();
		val generator = injector.getInstance(typeof(ModelGenerator));
		

		val ccore = CcorePackage.eINSTANCE;
		val cPackageDataType = ccore.getEClassifier("CPackage") as EDataType;
		
		val EPackage ecore = EcorePackage.eINSTANCE;
		val EAttribute cPackageAttr = EcoreFactory.eINSTANCE.createEAttribute();
		cPackageAttr.name = "cPackage";
		cPackageAttr.setEType(cPackageDataType);
		(ecore.getEClassifier("EClassifier") as EClass).EStructuralFeatures.add(cPackageAttr);
		
		generator.configure(ecore, false);
		generator.generateModel(basePath + "/ECore/", null);	
		
		generator.configure(ccore, true);
		generator.generateModel(basePath + "/CCore/", null);
	}
	
	def static void main(String[] args) {
		bootstrapECore("../../Assets/Scripts/UnityCMF/");
	}
}