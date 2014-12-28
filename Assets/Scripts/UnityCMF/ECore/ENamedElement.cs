using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(ENamedElement.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface ENamedElement : EModelElement {
		string Name { get; set; }
		void SetName(string value, object data);
		
		
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
		public  string Name {
			get {
				return _name;
			}
			set {
				string oldValue = _name;
				_name = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ENamedElement_Name)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ENamedElement_Name, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetName(string value, object data) {
			string oldValue = _name;
			_name = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ENamedElement_Name)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ENamedElement_Name, oldValue, value, -1, data));
			}
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "name" : 
					Name = (string)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "name" : 
					return Name;
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
