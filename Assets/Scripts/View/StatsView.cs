using UnityEngine;
using UnityCMF.CCore;

namespace �ePackage.fullPackageName� {
	
	public class �eClass.viewClassName� : MonoBehaviour {
		private �eClass.classifierName� _model;
		public �eClass.classifierName� Model { 
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
				�IF !eFeature.filter�
					if (action.Feature == �ePackage.metaName�.cINSTANCE.Package.�EPackageGenerator::packageFeatureProperty(eFeature)�) {
						�eFeature.onFeatureChangedMethodName�(action);
					}
				�ENDIF�
			�ENDFOR�
		}
		
		�FOR eFeature:eClass.EAllStructuralFeatures�
			�IF !eFeature.filter�
				public virtual void �eFeature.onFeatureChangedMethodName�(CAction action) 
				{
					
				}
			�ENDIF�
		�ENDFOR�
	}
} // UnityCMF.�eClass.EPackage.name�
