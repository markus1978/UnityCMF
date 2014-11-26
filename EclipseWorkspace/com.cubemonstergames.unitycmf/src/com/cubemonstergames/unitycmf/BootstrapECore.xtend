package com.cubemonstergames.unitycmf

import com.cubemonstergames.unitycmf.generators.EClassGenerator
import com.cubemonstergames.unitycmf.generators.EFactoryGenerator
import com.cubemonstergames.unitycmf.generators.EPackageGenerator
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EcorePackage
import org.eclipse.xtend.core.XtendInjectorSingleton
import org.eclipse.xtext.generator.JavaIoFileSystemAccess

class BootstrapECore {
	def static void main(String[] args) {
		val injector = XtendInjectorSingleton.INJECTOR;
		val fsa = injector.getInstance(typeof(JavaIoFileSystemAccess));		
		fsa.setOutputPath("../../Assets/UnityCMF/ECore/");
		
		for (EClassifier eClassifier: EcorePackage.eINSTANCE.EClassifiers) {
			if (eClassifier instanceof EClass) {
				new EClassGenerator(EcorePackage.eINSTANCE).generate(eClassifier as EClass, fsa);
			}
		}
		new EPackageGenerator(EcorePackage.eINSTANCE).generate(fsa);
		new EFactoryGenerator(EcorePackage.eINSTANCE).generate(fsa);
	}
}