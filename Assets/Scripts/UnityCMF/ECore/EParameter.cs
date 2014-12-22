using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EParameter.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EParameter : EModelElement,ENamedElement,ETypedElement {
		EOperation EOperation { get; set; }
		
		
	}
	public class EParameterImpl : ETypedElementImpl, EParameter {
	
		public EParameterImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EParameter.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EParameter.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private EOperation _eOperation;
		public EOperation EOperation {
			get {
				return _eOperation;
			}
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
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "eOperation" : 
					return EOperation;
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
