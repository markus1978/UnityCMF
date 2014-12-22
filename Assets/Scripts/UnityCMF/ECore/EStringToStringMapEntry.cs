using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EStringToStringMapEntry.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EStringToStringMapEntry : CObject {
		string Key { get; set; }
		string Value { get; set; }
		EAnnotation EAnnotation { get; }
		
		
	}
	public class EStringToStringMapEntryImpl : CObjectImpl, EStringToStringMapEntry {
	
		public EStringToStringMapEntryImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EStringToStringMapEntry.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EStringToStringMapEntry.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private string _key;
		public string Key {
			get {
				return _key;
			}
			set {
				string oldValue = _key;
				_key = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_Key)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_Key, oldValue, value, -1));
				}	
			}
		}
		private string _value;
		public string Value {
			get {
				return _value;
			}
			set {
				string oldValue = _value;
				_value = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_Value)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStringToStringMapEntry_Value, oldValue, value, -1));
				}	
			}
		}
		public EAnnotation EAnnotation { 
			get { 
				return CContainer as EAnnotation;
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
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				default:
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
