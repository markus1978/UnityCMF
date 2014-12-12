using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EAttribute : EModelElement,ENamedElement,ETypedElement,EStructuralFeature {
		bool ID { get; set; }
		EDataType EAttributeType { get;  }
		
	}
	public class EAttributeImpl : EStructuralFeatureImpl, EAttribute {
		// PROTECTED REGION ID(EAttribute.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EAttributeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EAttribute.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private bool _iD;
		public bool ID {
			get { return _iD; }
			set {
				bool oldValue = _iD;
				_iD = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAttribute_ID)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAttribute_ID, oldValue, value, -1));
				}	
			}
		}
		private EDataType _eAttributeType;
		public EDataType EAttributeType {
			get {
				// PROTECTED REGION ID(EAttribute.EAttributeType) ENABLED START
				return default(EDataType);
				// PROTECTED REGION END
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "iD" : 
				ID = (bool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "iD" : 
				return ID;															
			case "eAttributeType" : 
				return EAttributeType;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
