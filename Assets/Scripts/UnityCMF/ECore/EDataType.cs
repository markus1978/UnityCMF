using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EDataType.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EDataType : EModelElement,ENamedElement,EClassifier {
		bool Serializable { get; set; }
		void SetSerializable(bool value, object data);
		
		
	}
	public class EDataTypeImpl : EClassifierImpl, EDataType {
	
		public EDataTypeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EDataType.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EDataType.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private bool _serializable;
		public  bool Serializable {
			get {
				return _serializable;
			}
			set {
				bool oldValue = _serializable;
				_serializable = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EDataType_Serializable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EDataType_Serializable, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetSerializable(bool value, object data) {
			bool oldValue = _serializable;
			_serializable = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EDataType_Serializable)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EDataType_Serializable, oldValue, value, -1, data));
			}
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "serializable" : 
					Serializable = (bool)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "serializable" : 
					return Serializable;
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
