package com.cubemonstergames.unitycmf.generators

import com.google.inject.Singleton
import org.eclipse.emf.ecore.EClass
import org.eclipse.emf.ecore.EStructuralFeature

@Singleton
class ViewGenerator extends AbstractGenerator {
	
	def generate(EClass eClass) '''
		using UnityEngine;
		using UnityCMF.CCore;
		// PROTECTED REGION ID(�eClass.cViewName�.Namespaces) ENABLED START
		
		// PROTECTED REGION END
		
		namespace �metaGenerator.cNamespaceName(eClass.EPackage)� {
			
			public class �eClass.cViewName� : MonoBehaviour {
				
				#region client code
				// PROTECTED REGION ID(�eClass.cViewName�.ClientCode) ENABLED START
				
				// PROTECTED REGION END
				#endregion
				
				#region notification handlers
				�FOR eFeature:eClass.EAllStructuralFeatures�
					�IF !featureGenerator.filter(eFeature)�
						�IF !eFeature.derived�
							public virtual void �eFeature.cFeatureChangedMethodName�(CAction action) 
							{
								// PROTECTED REGION ID(�eClass.cViewName�.�eFeature.cFeatureChangedMethodName�) ENABLED START
								
								// PROTECTED REGION END
							}
						�ENDIF�
					�ENDIF�
				�ENDFOR�
				#endregion
				
				#region generated code
				private �classifierGenerator.cRef(eClass)� _model;
				public �classifierGenerator.cRef(eClass)� Model { 
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
					�FOR eFeature:eClass.EAllStructuralFeatures�
						�IF !featureGenerator.filter(eFeature)�
							�IF !eFeature.derived�
								if (action.Feature == �featureGenerator.cInstanceRef(eFeature)�) {
									�eFeature.cFeatureChangedMethodName�(action);
								}
							�ENDIF�
						�ENDIF�
					�ENDFOR�
				}
				#endregion
			}
		} // UnityCMF.�eClass.EPackage.name�
	'''
	
	def cViewName(EClass eClass) '''�classifierGenerator.cName(eClass)�View'''
	
	def filter(EClass eClass) {
		return !eClass.EAnnotations.filter[eAnnotation| 
			eAnnotation.source.endsWith("UnityCMF")].exists[eAnnotation| 
			"true".equals(eAnnotation.details.get("hasView"))];
	}
	
	private def cFeatureChangedMethodName(EStructuralFeature eFeature) {
		return "On" + featureGenerator.cName(eFeature) + "Changed";
	}
}