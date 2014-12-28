using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EEnumLiteral.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EEnumLiteral : EModelElement,ENamedElement {
		int Value { get; set; }
		void SetValue(int value, object data);
		string Literal { get; set; }
		void SetLiteral(string value, object data);
		EEnum EEnum { get; set; }
		void SetEEnum(EEnum value, object data);
		
		
	}
	public class EEnumLiteralImpl : ENamedElementImpl, EEnumLiteral {
	
		public EEnumLiteralImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EEnumLiteral.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EEnumLiteral.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private int _value;
		public  int Value {
			get {
				return _value;
			}
			set {
				int oldValue = _value;
				_value = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_Value)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_Value, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetValue(int value, object data) {
			int oldValue = _value;
			_value = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_Value)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_Value, oldValue, value, -1, data));
			}
		}
		
		private string _literal;
		public  string Literal {
			get {
				return _literal;
			}
			set {
				string oldValue = _literal;
				_literal = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_Literal)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_Literal, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetLiteral(string value, object data) {
			string oldValue = _literal;
			_literal = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_Literal)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_Literal, oldValue, value, -1, data));
			}
		}
		
		private EEnum _eEnum;
		public  EEnum EEnum {
			get {
				return _eEnum;
			}
			set {
				EEnum oldValue = _eEnum;
				_eEnum = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_EEnum)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_EEnum, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetEEnum(EEnum value, object data) {
			EEnum oldValue = _eEnum;
			_eEnum = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EEnumLiteral_EEnum)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EEnumLiteral_EEnum, oldValue, value, -1, data));
			}
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "value" : 
					Value = (int)value;
					break;															
				case "literal" : 
					Literal = (string)value;
					break;															
				case "eEnum" : 
					EEnum = (EEnum)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "value" : 
					return Value;
				case "literal" : 
					return Literal;
				case "eEnum" : 
					return EEnum;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
