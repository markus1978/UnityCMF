package com.cubemonstergames.unitycmf

import com.google.inject.Guice
import org.eclipse.xtext.XtextStandaloneSetup

class UnityCMFStandaloneSetup extends XtextStandaloneSetup {
	
	override createInjector() {
		return Guice.createInjector(new UnityCMFRuntimeModule());
	}
	
}