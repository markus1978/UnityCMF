using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EStringToStringMapEntry : CObject {
		string Key { get; set; }
		string Value { get; set; }
		
	}
	
	public class EStringToStringMapEntryImpl : CObjectImpl, EStringToStringMapEntry {
		// PROTECTED REGION ID(EStringToStringMapEntry.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EStringToStringMapEntryImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EStringToStringMapEntry.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private string _Key;
		public string Key {
			get { return _Key; }
			set {
				string oldValue = _Key;
				_Key = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_key)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_key, oldValue, value, -1));
				}	
			}
		}
		private string _Value;
		public string Value {
			get { return _Value; }
			set {
				string oldValue = _Value;
				_Value = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_value)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_value, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "key" : 
				Key = (string)value;
				break;															
			case "value" : 
				Value = (string)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "key" : 
				return Key;															
			case "value" : 
				return Value;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.ecore
