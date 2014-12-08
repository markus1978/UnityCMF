using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EParameter : EModelElement,ENamedElement,ETypedElement {
		EOperation EOperation { get; set; }
		
	}
	
	public class EParameterImpl : ETypedElementImpl, EParameter {
		// PROTECTED REGION ID(EParameter.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EParameterImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EParameter.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private EOperation _EOperation;
		public EOperation EOperation {
			get { return _EOperation; }
			set {
				EOperation oldValue = _EOperation;
				_EOperation = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EParameter_eOperation)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EParameter_eOperation, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
