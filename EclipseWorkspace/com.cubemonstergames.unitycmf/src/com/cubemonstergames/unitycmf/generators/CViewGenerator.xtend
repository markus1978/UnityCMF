package com.cubemonstergames.unitycmf.generators

import org.eclipse.emf.ecore.EAnnotation
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EPackage
import org.eclipse.xtext.generator.IFileSystemAccess
import static extension com.cubemonstergames.unitycmf.generators.GenUtil.*
import org.eclipse.emf.ecore.EStructuralFeature

class CViewGenerator {
	
	val EPackage ePackage;
	
	new(EPackage ePackage) {
		this.ePackage = ePackage;
	}
	
	def viewClassName(EClass eClass) {
		return eClass.classifierName + "View";
	}
	
	def generate(EClass eClass, IFileSystemAccess fsa) {		
		if (!eClass.EAnnotations
				.filter[EAnnotation eAnnotation| eAnnotation.source.endsWith("UnityCMF")]
				.exists[EAnnotation eAnnotation| "true".equals(eAnnotation.details.get("hasView"))]) {
			return;		
		}

		
		fsa.generateFile(eClass.viewClassName + ".cs", '''
			using UnityEngine;
			using UnityCMF.CCore;
			
			namespace «ePackage.fullPackageName» {
				
				public class «eClass.viewClassName» : MonoBehaviour {
					private «eClass.classifierName» _model;
					public «eClass.classifierName» Model { 
						get { return _model; }
						set {
							if (_model != null) {
								_model.CNotification -= OnNotification;
							}
							_model = value;
							_model.CNotification += OnNotification;
						}
					}
					
					private void OnNotification(CAction action)
					{
						«FOR eFeature:eClass.EAllStructuralFeatures»
							«IF !eFeature.filter»
								if (action.Feature == «ePackage.metaName».cINSTANCE.Package.«EPackageGenerator::packageFeatureProperty(eFeature)») {
									«eFeature.onFeatureChangedMethodName»(action);
								}
							«ENDIF»
						«ENDFOR»
					}
					
					«FOR eFeature:eClass.EAllStructuralFeatures»
						«IF !eFeature.filter»
							public virtual void «eFeature.onFeatureChangedMethodName»(CAction action) 
							{
								// PROTECTED REGION ID(«eClass.viewClassName».«eFeature.onFeatureChangedMethodName») ENABLED START
								
								// PROTECTED REGION END
							}
						«ENDIF»
					«ENDFOR»
				}
			} // UnityCMF.«eClass.EPackage.name»
		''')
	} 
	
	def onFeatureChangedMethodName(EStructuralFeature feature) {
		return "On" + feature.name.toFirstUpper + "Changed";
	}
}