using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(Content.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.Ccoretest {
	public interface Content : Interface {
		
	}
	public class ContentImpl : CObjectImpl, Content {
	
		public ContentImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Content.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(Content.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		public virtual void Operation() {
			// PROTECTED REGION ID(Interface.operation_) ENABLED START
			throw new System.InvalidOperationException("Unsupported Operation Interface.operation()");
			// PROTECTED REGION END
		}
		#endregion
		
		private string _attribute;
		public string Attribute {
			get {
				return _attribute;
			}
			set {
				string oldValue = _attribute;
				_attribute = value;
				if (CNotificationRequired(CcoretestMeta.cINSTANCE.Package.Interface_Attribute)) {
					CNotify(new CAction(this, CActionType.SET, CcoretestMeta.cINSTANCE.Package.Interface_Attribute, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "attribute" : 
				Attribute = (string)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "attribute" : 
				return Attribute;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ccoretest
