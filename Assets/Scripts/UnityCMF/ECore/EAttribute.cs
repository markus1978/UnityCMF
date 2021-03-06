using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EAttribute.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EAttribute : EModelElement,ENamedElement,ETypedElement,EStructuralFeature {
		bool ID { get; set; }
		void SetID(bool value, object data);
		EDataType EAttributeType { get;  }
		
		
	}
	public class EAttributeImpl : EStructuralFeatureImpl, EAttribute {
	
		public EAttributeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EAttribute.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EAttribute.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		public  EDataType EAttributeType {
			get {
				// PROTECTED REGION ID(EAttribute.EAttributeType) ENABLED START
				return default(EDataType);
				// PROTECTED REGION END
			}
		}
		
		
		#endregion
		
		private bool _iD;
		public  bool ID {
			get {
				return _iD;
			}
			set {
				bool oldValue = _iD;
				_iD = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAttribute_ID)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAttribute_ID, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetID(bool value, object data) {
			bool oldValue = _iD;
			_iD = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAttribute_ID)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAttribute_ID, oldValue, value, -1, data));
			}
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "iD" : 
					ID = (bool)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "iD" : 
					return ID;
				case "eAttributeType" : 
					return EAttributeType;
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
