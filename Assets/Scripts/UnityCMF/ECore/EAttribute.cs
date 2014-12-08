using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EAttribute : EModelElement,ENamedElement,ETypedElement,EStructuralFeature {
		bool IsID { get; set; }
		EDataType EAttributeType { get;  }
		
	}
	
	public class EAttributeImpl : EStructuralFeatureImpl, EAttribute {
		// PROTECTED REGION ID(EAttribute.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EAttributeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EAttribute.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private bool _IsID;
		public bool IsID {
			get { return _IsID; }
			set {
				bool oldValue = _IsID;
				_IsID = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAttribute_iD)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAttribute_iD, oldValue, value, -1));
				}	
			}
		}
		private EDataType _EAttributeType;
		public EDataType EAttributeType {
			get {
				// PROTECTED REGION ID(EAttribute.eAttributeType) ENABLED START
				return default(EDataType);
				// PROTECTED REGION END
			}
		}
	}
} // UnityCMF.ecore
