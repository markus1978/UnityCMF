using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EDataType : EModelElement,ENamedElement,EClassifier {
		bool Serializable { get; set; }
		
	}
	public class EDataTypeImpl : EClassifierImpl, EDataType {
		// PROTECTED REGION ID(EDataType.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EDataTypeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EDataType.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private bool _serializable;
		public bool Serializable {
			get { return _serializable; }
			set {
				bool oldValue = _serializable;
				_serializable = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EDataType_Serializable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EDataType_Serializable, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "serializable" : 
				Serializable = (bool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "serializable" : 
				return Serializable;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
