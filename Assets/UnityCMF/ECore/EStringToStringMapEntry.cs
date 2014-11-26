using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EStringToStringMapEntry : CObject {
		string Key { get; set; }
		string Value { get; set; }
	}
	
	public class EStringToStringMapEntryImpl : CObjectImpl, EStringToStringMapEntry {
		public EStringToStringMapEntryImpl(UnityCMF.ECore.EClass eClass) {
			EObjectImpl(eClass);
		}
		
		private string _Key;
		public string Key {
			get { return _Key; }
			set {
				string oldValue = _Key;
				_Key = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStringToStringMapEntry_key)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStringToStringMapEntry_key, oldValue, value, -1));
				}	
			}
		}
		private string _Value;
		public string Value {
			get { return _Value; }
			set {
				string oldValue = _Value;
				_Value = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStringToStringMapEntry_value)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStringToStringMapEntry_value, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
