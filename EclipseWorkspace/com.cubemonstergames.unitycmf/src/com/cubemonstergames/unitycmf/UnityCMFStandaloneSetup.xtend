package com.cubemonstergames.unitycmf

import com.google.inject.Guice
import org.eclipse.xtext.XtextStandaloneSetup
import com.google.inject.Injector
import org.eclipse.emf.ecore.EPackage
import com.cubemonstergames.unitycmf.ccore.CcorePackage

class UnityCMFStandaloneSetup extends XtextStandaloneSetup {
	
	override createInjector() {
		return Guice.createInjector(new UnityCMFRuntimeModule());
	}
	
	override register(Injector injector) {
		EPackage.Registry.INSTANCE.put(CcorePackage.eINSTANCE.getNsURI(), CcorePackage.eINSTANCE);
		super.register(injector)
	}
	
}