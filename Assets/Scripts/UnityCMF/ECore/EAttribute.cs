using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EAttribute : EModelElement,ENamedElement,ETypedElement,EStructuralFeature {
		bool IsID { get; set; }
		
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
	}
} // UnityCMF.ecore
