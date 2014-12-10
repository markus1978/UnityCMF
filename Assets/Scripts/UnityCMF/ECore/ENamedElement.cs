using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface ENamedElement : EModelElement {
		string Name { get; set; }
		
	}
	
	public class ENamedElementImpl : EModelElementImpl, ENamedElement {
		// PROTECTED REGION ID(ENamedElement.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ENamedElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(ENamedElement.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private string _Name;
		public string Name {
			get { return _Name; }
			set {
				string oldValue = _Name;
				_Name = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ENamedElement_name)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ENamedElement_name, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "name" : 
				Name = (string)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "name" : 
				return Name;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.ecore
