package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EClassifier
import org.eclipse.emf.ecore.EDataType
import org.eclipse.emf.ecore.EStructuralFeature
import org.eclipse.xtext.generator.IFileSystemAccess
import org.eclipse.emf.ecore.EPackage

import static extension com.cubemonstergames.unitycmf.generators.GenUtil.*

class EClassGenerator {
	
	val EPackage ePackage;
	
	new(EPackage ePackage) {
		this.ePackage = ePackage;
	}
	
	def generate(EClass eClass, IFileSystemAccess fsa) {
		fsa.generateFile(eClass.getName() + ".cs", '''
		using UnityCMF.CCore;
		
		namespace «ePackage.fullPackageName» {
			 
			public interface «eClass.classifierName» : «eClass.superInterfaceDeclaration» {
				«FOR eFeature:eClass.EStructuralFeatures»
					«IF !eFeature.filter»
						«eFeature.generateFeatureInterface»
					«ENDIF»
				«ENDFOR»
			}
			
			public class «eClass.classifierName»Impl : CObjectImpl, «eClass.classifierName» {
				public «eClass.name.toFirstUpper»Impl(UnityCMF.ECore.EClass eClass) {
					EObjectImpl(eClass);
				}
				
				«FOR eFeature:eClass.EAllStructuralFeatures»
					«IF !eFeature.filter»
						«eFeature.generateFeatureImplementation»
					«ENDIF»
				«ENDFOR»
			}
		} // UnityCMF.«eClass.EPackage.name»
		''')
	} 
	
	def superInterfaceDeclaration(EClass eClass) '''«IF eClass.EAllSuperTypes.empty»CObject«ELSE»«FOR superClass:eClass.EAllSuperTypes SEPARATOR ','»«superClass.name»«ENDFOR»«ENDIF»'''
	
	def generateFeatureInterface(EStructuralFeature eFeature) '''
		«IF eFeature.many»
			CList<«eFeature.EType.typeReference»> «eFeature.propertyName» { get; }
		«ELSE» 
			«eFeature.EType.typeReference» «eFeature.propertyName» { get; set; }
		«ENDIF»
	'''
	
	def featureMetaReference(EStructuralFeature feature) '''UnityCMF.«ePackage.name».«ePackage.name.toFirstUpper»Package.cINSTANCE.«feature.EContainingClass.name»_«feature.name»'''
	
	def generateFeatureImplementation(EStructuralFeature eFeature) '''
		«IF eFeature.many»
			private CList<«eFeature.EType.typeReference»> _«eFeature.propertyName»;
			public CList<«eFeature.EType.typeReference»> «eFeature.propertyName» {
				get {
					if (_«eFeature.propertyName» == null) {
						CStructuralFeature feature = «eFeature.featureMetaReference»;
						_«eFeature.propertyName» = new CList<«eFeature.EType.typeReference»>(this, feature);
					}
					return _«eFeature.propertyName»;
				}
			}
		«ELSE»
			private «eFeature.EType.typeReference» _«eFeature.propertyName»;
			public «eFeature.EType.typeReference» «eFeature.propertyName» {
				get { return _«eFeature.propertyName»; }
				set {
					«eFeature.EType.typeReference» oldValue = _«eFeature.propertyName»;
					_«eFeature.propertyName» = value;
					
					if (CNotificationRequired(«eFeature.featureMetaReference()»)) {
						CNotify(new Action(this, CAction.SET, «eFeature.featureMetaReference», oldValue, value, -1));
					}	
				}
			}
		«ENDIF»
	'''
	def typeReference(EClassifier type) {
		if (type instanceof EDataType) {
			if (type.name.equals("EInt")) return "int"
			else if (type.name.equals("EString")) return "string"
			else if (type.name.equals("EDouble")) return "float"
			else if (type.name.equals("EBoolean")) return "bool"
			else return type.instanceTypeName
		} else if (type instanceof EClass) {
			if (type.EPackage == ePackage) {
				return type.classifierName;
			}
			return '''«type.EPackage.fullPackageName».«type.classifierName»'''
		}
	}
}