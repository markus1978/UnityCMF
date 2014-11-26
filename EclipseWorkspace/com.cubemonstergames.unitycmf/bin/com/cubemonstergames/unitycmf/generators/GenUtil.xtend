package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.emf.ecore.EcorePackage
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.EClassifier

class GenUtil {
	def static propertyName(EStructuralFeature eFeature) {
		if (eFeature.EType == EcorePackage.eINSTANCE.EBoolean && !eFeature.many) {
			return '''Is«eFeature.name.toFirstUpper»'''
		} else {
			return eFeature.name.toFirstUpper;
		}
	}
	
	def static packageName(EPackage ePackage) {
		if (ePackage == EcorePackage.eINSTANCE) {
			return "ECore";
		} else {
			return ePackage.name.toFirstUpper;
		}
	}	
	
	def static fullPackageName(EPackage ePackage) {
		if (ePackage == EcorePackage.eINSTANCE) {
			return "UnityCMF.ECore";
		} else {
			return '''UnityCMF.«ePackage.name.toFirstUpper»''';
		}
	}
	
	def static classifierName(EClassifier eClassifier) {
		return eClassifier.name.toFirstUpper;
	}
	
	def static filter(EStructuralFeature eFeature) {
		eFeature.derived;
	}
	
	def static packageInterfaceName(EPackage ePackage) {
		return ePackage.packageName + "Package";
	}
	
	def static packageImplementationName(EPackage ePackage) {
		return ePackage.packageInterfaceName + "Impl";
	}
	
	def static factoryInterfaceName(EPackage ePackage) {
		return ePackage.packageName + "Factory";
	}
	
	def static factoryImplementationName(EPackage ePackage) {
		return ePackage.factoryInterfaceName + "Impl";
	}
}