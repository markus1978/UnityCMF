using UnityEngine;
using UnityCMF.CCore;
// PROTECTED REGION ID(ContentView.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.Ccoretest {
	
	public class ContentView : MonoBehaviour {
		
		#region client code
		// PROTECTED REGION ID(ContentView.ClientCode) ENABLED START

		// PROTECTED REGION END
		#endregion
		
		#region notification handlers
		public virtual void OnAttributeChanged(CAction action) 
		{
			// PROTECTED REGION ID(ContentView.OnAttributeChanged) ENABLED START

			// PROTECTED REGION END
		}
		#endregion
		
		#region generated code
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
		#endregion
	}
} // UnityCMF.ccoretest
