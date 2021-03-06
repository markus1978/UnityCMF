package com.cubemonstergames.unitycmf

import com.google.inject.Binder
import com.google.inject.Provides
import net.danieldietrich.protectedregions.ParserFactory
import net.danieldietrich.protectedregions.xtext.ProtectedRegionJavaIoFileSystemAccess
import org.eclipse.xtext.XtextRuntimeModule
import org.eclipse.xtext.generator.JavaIoFileSystemAccess

class UnityCMFRuntimeModule extends XtextRuntimeModule {

	override configure(Binder binder) {
		super.configure(binder)
	}

	@Provides
	def JavaIoFileSystemAccess createJavaIoFileSystemAccess(ProtectedRegionJavaIoFileSystemAccess fsa,
		ParserFactory factory) {
		fsa.support().addParser(factory.genericParser(), ".cs");
		return fsa;
	}
}
