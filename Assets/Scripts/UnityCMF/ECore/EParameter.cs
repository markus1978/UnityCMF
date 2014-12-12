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
		
		private EOperation _eOperation;
		public EOperation EOperation {
			get { return _eOperation; }
			set {
				EOperation oldValue = _eOperation;
				_eOperation = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EParameter_EOperation)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EParameter_EOperation, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "eOperation" : 
				EOperation = (EOperation)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "eOperation" : 
				return EOperation;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
