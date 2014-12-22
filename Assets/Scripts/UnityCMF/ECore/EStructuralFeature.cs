using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EStructuralFeature.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EStructuralFeature : EModelElement,ENamedElement,ETypedElement {
		bool Changeable { get; set; }
		bool Volatile { get; set; }
		bool Transient { get; set; }
		string DefaultValueLiteral { get; set; }
		bool Unsettable { get; set; }
		bool Derived { get; set; }
		EClass EContainingClass { get; set; }
		
		
	}
	public class EStructuralFeatureImpl : ETypedElementImpl, EStructuralFeature {
	
		public EStructuralFeatureImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EStructuralFeature.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EStructuralFeature.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private bool _changeable;
		public bool Changeable {
			get {
				return _changeable;
			}
			set {
				bool oldValue = _changeable;
				_changeable = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_Changeable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_Changeable, oldValue, value, -1));
				}	
			}
		}
		private bool _volatile;
		public bool Volatile {
			get {
				return _volatile;
			}
			set {
				bool oldValue = _volatile;
				_volatile = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_Volatile)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_Volatile, oldValue, value, -1));
				}	
			}
		}
		private bool _transient;
		public bool Transient {
			get {
				return _transient;
			}
			set {
				bool oldValue = _transient;
				_transient = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_Transient)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_Transient, oldValue, value, -1));
				}	
			}
		}
		private string _defaultValueLiteral;
		public string DefaultValueLiteral {
			get {
				return _defaultValueLiteral;
			}
			set {
				string oldValue = _defaultValueLiteral;
				_defaultValueLiteral = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_DefaultValueLiteral)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_DefaultValueLiteral, oldValue, value, -1));
				}	
			}
		}
		private bool _unsettable;
		public bool Unsettable {
			get {
				return _unsettable;
			}
			set {
				bool oldValue = _unsettable;
				_unsettable = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_Unsettable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_Unsettable, oldValue, value, -1));
				}	
			}
		}
		private bool _derived;
		public bool Derived {
			get {
				return _derived;
			}
			set {
				bool oldValue = _derived;
				_derived = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_Derived)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_Derived, oldValue, value, -1));
				}	
			}
		}
		private EClass _eContainingClass;
		public EClass EContainingClass {
			get {
				return _eContainingClass;
			}
			set {
				EClass oldValue = _eContainingClass;
				_eContainingClass = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_EContainingClass)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_EContainingClass, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "changeable" : 
					Changeable = (bool)value;
					break;															
				case "volatile" : 
					Volatile = (bool)value;
					break;															
				case "transient" : 
					Transient = (bool)value;
					break;															
				case "defaultValueLiteral" : 
					DefaultValueLiteral = (string)value;
					break;															
				case "unsettable" : 
					Unsettable = (bool)value;
					break;															
				case "derived" : 
					Derived = (bool)value;
					break;															
				case "eContainingClass" : 
					EContainingClass = (EClass)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "changeable" : 
					return Changeable;
				case "volatile" : 
					return Volatile;
				case "transient" : 
					return Transient;
				case "defaultValueLiteral" : 
					return DefaultValueLiteral;
				case "unsettable" : 
					return Unsettable;
				case "derived" : 
					return Derived;
				case "eContainingClass" : 
					return EContainingClass;
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
