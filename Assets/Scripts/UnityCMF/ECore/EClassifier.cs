using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EClassifier.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EClassifier : EModelElement,ENamedElement {
		string InstanceClassName { get; set; }
		void SetInstanceClassName(string value, object data);
		string InstanceTypeName { get; set; }
		void SetInstanceTypeName(string value, object data);
		EPackage EPackage { get; set; }
		void SetEPackage(EPackage value, object data);
		CList<ETypeParameter> ETypeParameters { get; }
		UnityCMF.CCore.CPackage CPackage { get; set; }
		void SetCPackage(UnityCMF.CCore.CPackage value, object data);
		
		
	}
	public class EClassifierImpl : ENamedElementImpl, EClassifier {
	
		public EClassifierImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EClassifier.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EClassifier.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private string _instanceClassName;
		public  string InstanceClassName {
			get {
				return _instanceClassName;
			}
			set {
				string oldValue = _instanceClassName;
				_instanceClassName = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_InstanceClassName)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_InstanceClassName, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetInstanceClassName(string value, object data) {
			string oldValue = _instanceClassName;
			_instanceClassName = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_InstanceClassName)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_InstanceClassName, oldValue, value, -1, data));
			}
		}
		
		private string _instanceTypeName;
		public  string InstanceTypeName {
			get {
				return _instanceTypeName;
			}
			set {
				string oldValue = _instanceTypeName;
				_instanceTypeName = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_InstanceTypeName)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_InstanceTypeName, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetInstanceTypeName(string value, object data) {
			string oldValue = _instanceTypeName;
			_instanceTypeName = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_InstanceTypeName)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_InstanceTypeName, oldValue, value, -1, data));
			}
		}
		
		private EPackage _ePackage;
		public  EPackage EPackage {
			get {
				return _ePackage;
			}
			set {
				EPackage oldValue = _ePackage;
				_ePackage = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_EPackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_EPackage, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetEPackage(EPackage value, object data) {
			EPackage oldValue = _ePackage;
			_ePackage = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_EPackage)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_EPackage, oldValue, value, -1, data));
			}
		}
		
		private CList<ETypeParameter> _eTypeParameters;
		public  CList<ETypeParameter> ETypeParameters {
			get {
				if (_eTypeParameters == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClassifier_ETypeParameters;
					_eTypeParameters = new CList<ETypeParameter>(false, this, feature);
				}
				return _eTypeParameters;
			}
		}
		private UnityCMF.CCore.CPackage _cPackage;
		public  UnityCMF.CCore.CPackage CPackage {
			get {
				return _cPackage;
			}
			set {
				UnityCMF.CCore.CPackage oldValue = _cPackage;
				_cPackage = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_CPackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_CPackage, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetCPackage(UnityCMF.CCore.CPackage value, object data) {
			UnityCMF.CCore.CPackage oldValue = _cPackage;
			_cPackage = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_CPackage)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_CPackage, oldValue, value, -1, data));
			}
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "instanceClassName" : 
					InstanceClassName = (string)value;
					break;															
				case "instanceTypeName" : 
					InstanceTypeName = (string)value;
					break;															
				case "ePackage" : 
					EPackage = (EPackage)value;
					break;															
				case "cPackage" : 
					CPackage = (UnityCMF.CCore.CPackage)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "instanceClassName" : 
					return InstanceClassName;
				case "instanceTypeName" : 
					return InstanceTypeName;
				case "ePackage" : 
					return EPackage;
				case "eTypeParameters" : 
					return ETypeParameters;
				case "cPackage" : 
					return CPackage;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eTypeParameters" :
					_eTypeParameters.RemoveAt(_eTypeParameters.IndexOf(value)); 
					break;
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
