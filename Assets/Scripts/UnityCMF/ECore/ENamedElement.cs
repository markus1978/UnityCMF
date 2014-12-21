using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(ENamedElement.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface ENamedElement : EModelElement {
		string Name { get; set; }
		
	}
	public class ENamedElementImpl : EModelElementImpl, ENamedElement {
	
		public ENamedElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(ENamedElement.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(ENamedElement.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private string _name;
		public string Name {
			get {
				return _name;
			}
			set {
				string oldValue = _name;
				_name = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ENamedElement_Name)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ENamedElement_Name, oldValue, value, -1));
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
