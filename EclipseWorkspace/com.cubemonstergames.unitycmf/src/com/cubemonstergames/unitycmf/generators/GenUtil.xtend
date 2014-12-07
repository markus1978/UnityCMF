package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EPackage
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.emf.ecore.EcorePackage

class GenUtil {
	def static isSupportedType(EClassifier eClassifier) {
		return eClassifier instanceof EClass || 
			eClassifier.name.equals("EInt") ||
			eClassifier.name.equals("EString") ||
			eClassifier.name.equals("EDouble") ||
			eClassifier.name.equals("EBoolean") ||
			eClassifier.EAnnotations.exists[a|a.source.endsWith("UnityCMF") && a.details.get("CInstanceClass") != null]
	}
	
	def static primitiveTypeReference(EDataType type) {
		if (type.name.equals("EInt")) return "int"
		else if (type.name.equals("EString")) return "string"
		else if (type.name.equals("EDouble")) return "float"
		else if (type.name.equals("EBoolean")) return "bool"
		else return type.instanceTypeName		
	}
	
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
		eFeature.derived || !eFeature.EType.isSupportedType;
	}
	
	def static packageInterfaceName(EPackage ePackage) {
		return ePackage.packageName + "Package";
	}
	
	def static packageImplementationName(EPackage ePackage) {
		return ePackage.packageInterfaceName + "Impl";
	}
	
	def static metaName(EPackage ePackage) {
		return ePackage.packageName + "Meta";
	}
	
	def static factoryInterfaceName(EPackage ePackage) {
		return ePackage.packageName + "Factory";
	}
	
	def static factoryImplementationName(EPackage ePackage) {
		return ePackage.factoryInterfaceName + "Impl";
	}
}