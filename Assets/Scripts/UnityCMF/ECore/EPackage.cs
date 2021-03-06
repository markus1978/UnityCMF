using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EPackage.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EPackage : EModelElement,ENamedElement {
		string NsURI { get; set; }
		void SetNsURI(string value, object data);
		string NsPrefix { get; set; }
		void SetNsPrefix(string value, object data);
		EFactory EFactoryInstance { get; set; }
		void SetEFactoryInstance(EFactory value, object data);
		CList<EClassifier> EClassifiers { get; }
		CList<EPackage> ESubpackages { get; }
		EPackage ESuperPackage { get; set; }
		void SetESuperPackage(EPackage value, object data);
		
		
	}
	public class EPackageImpl : ENamedElementImpl, EPackage {
	
		public EPackageImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EPackage.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EPackage.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private string _nsURI;
		public  string NsURI {
			get {
				return _nsURI;
			}
			set {
				string oldValue = _nsURI;
				_nsURI = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_NsURI)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_NsURI, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetNsURI(string value, object data) {
			string oldValue = _nsURI;
			_nsURI = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_NsURI)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_NsURI, oldValue, value, -1, data));
			}
		}
		
		private string _nsPrefix;
		public  string NsPrefix {
			get {
				return _nsPrefix;
			}
			set {
				string oldValue = _nsPrefix;
				_nsPrefix = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_NsPrefix)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_NsPrefix, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetNsPrefix(string value, object data) {
			string oldValue = _nsPrefix;
			_nsPrefix = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_NsPrefix)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_NsPrefix, oldValue, value, -1, data));
			}
		}
		
		private EFactory _eFactoryInstance;
		public  EFactory EFactoryInstance {
			get {
				return _eFactoryInstance;
			}
			set {
				EFactory oldValue = _eFactoryInstance;
				_eFactoryInstance = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_EFactoryInstance)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_EFactoryInstance, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetEFactoryInstance(EFactory value, object data) {
			EFactory oldValue = _eFactoryInstance;
			_eFactoryInstance = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_EFactoryInstance)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_EFactoryInstance, oldValue, value, -1, data));
			}
		}
		
		private CList<EClassifier> _eClassifiers;
		public  CList<EClassifier> EClassifiers {
			get {
				if (_eClassifiers == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EPackage_EClassifiers;
					_eClassifiers = new CList<EClassifier>(false, this, feature);
				}
				return _eClassifiers;
			}
		}
		private CList<EPackage> _eSubpackages;
		public  CList<EPackage> ESubpackages {
			get {
				if (_eSubpackages == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EPackage_ESubpackages;
					_eSubpackages = new CList<EPackage>(false, this, feature);
				}
				return _eSubpackages;
			}
		}
		private EPackage _eSuperPackage;
		public  EPackage ESuperPackage {
			get {
				return _eSuperPackage;
			}
			set {
				EPackage oldValue = _eSuperPackage;
				_eSuperPackage = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_ESuperPackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_ESuperPackage, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetESuperPackage(EPackage value, object data) {
			EPackage oldValue = _eSuperPackage;
			_eSuperPackage = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_ESuperPackage)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_ESuperPackage, oldValue, value, -1, data));
			}
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "nsURI" : 
					NsURI = (string)value;
					break;															
				case "nsPrefix" : 
					NsPrefix = (string)value;
					break;															
				case "eFactoryInstance" : 
					EFactoryInstance = (EFactory)value;
					break;															
				case "eSuperPackage" : 
					ESuperPackage = (EPackage)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "nsURI" : 
					return NsURI;
				case "nsPrefix" : 
					return NsPrefix;
				case "eFactoryInstance" : 
					return EFactoryInstance;
				case "eClassifiers" : 
					return EClassifiers;
				case "eSubpackages" : 
					return ESubpackages;
				case "eSuperPackage" : 
					return ESuperPackage;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eClassifiers" :
					_eClassifiers.RemoveAt(_eClassifiers.IndexOf(value)); 
					break;
				case "eSubpackages" :
					_eSubpackages.RemoveAt(_eSubpackages.IndexOf(value)); 
					break;
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
