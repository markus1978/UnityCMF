using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EFactory.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EFactory : EModelElement {
		EPackage EPackage { get; set; }
		
		
	}
	public class EFactoryImpl : EModelElementImpl, EFactory {
	
		public EFactoryImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EFactory.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EFactory.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private EPackage _ePackage;
		public EPackage EPackage {
			get {
				return _ePackage;
			}
			set {
				EPackage oldValue = _ePackage;
				_ePackage = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EFactory_EPackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EFactory_EPackage, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "ePackage" : 
					EPackage = (EPackage)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "ePackage" : 
					return EPackage;
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
