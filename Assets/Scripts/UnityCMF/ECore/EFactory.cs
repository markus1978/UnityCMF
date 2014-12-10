using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EFactory : EModelElement {
		EPackage EPackage { get; set; }
		
	}
	
	public class EFactoryImpl : EModelElementImpl, EFactory {
		// PROTECTED REGION ID(EFactory.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EFactoryImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EFactory.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private EPackage _EPackage;
		public EPackage EPackage {
			get { return _EPackage; }
			set {
				EPackage oldValue = _EPackage;
				_EPackage = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EFactory_ePackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EFactory_ePackage, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "ePackage" : 
				EPackage = (EPackage)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "ePackage" : 
				return EPackage;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.ecore
