using UnityEngine;
	using UnityCMF.CCore;
	
	namespace UnityCMF.Ccoretest {
		
		public class ContentView : MonoBehaviour {
			private Content _model;
			public Content Model { 
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
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Interface_Attribute) {
					OnAttributeChanged(action);
				}
			}
			
			public virtual void OnAttributeChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContentView.OnAttributeChanged) ENABLED START
				
				// PROTECTED REGION END
			}
		}
	} // UnityCMF.ccoretest
