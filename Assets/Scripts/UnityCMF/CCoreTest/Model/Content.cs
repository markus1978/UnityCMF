using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Ccoretest {
	public interface Content : Interface {
		
	}
	public class ContentImpl : CObjectImpl, Content {
		// PROTECTED REGION ID(Content.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ContentImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Content.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		public virtual void Operation() {
			// PROTECTED REGION ID(Interface.operation_) ENABLED START
			throw new System.InvalidOperationException("Unsupported Operation Interface.operation()");
			// PROTECTED REGION END
		}
		
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
