using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EPackage : EModelElement,ENamedElement {
		string NsURI { get; set; }
		string NsPrefix { get; set; }
		EFactory EFactoryInstance { get; set; }
		CList<EClassifier> EClassifiers { get;  }
		CList<EPackage> ESubpackages { get;  }
		EPackage ESuperPackage { get; set; }
		
	}
	
	public class EPackageImpl : ENamedElementImpl, EPackage {
		// PROTECTED REGION ID(EPackage.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EPackageImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EPackage.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private string _NsURI;
		public string NsURI {
			get { return _NsURI; }
			set {
				string oldValue = _NsURI;
				_NsURI = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_nsURI)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_nsURI, oldValue, value, -1));
				}	
			}
		}
		private string _NsPrefix;
		public string NsPrefix {
			get { return _NsPrefix; }
			set {
				string oldValue = _NsPrefix;
				_NsPrefix = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_nsPrefix)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_nsPrefix, oldValue, value, -1));
				}	
			}
		}
		private EFactory _EFactoryInstance;
		public EFactory EFactoryInstance {
			get { return _EFactoryInstance; }
			set {
				EFactory oldValue = _EFactoryInstance;
				_EFactoryInstance = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_eFactoryInstance)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_eFactoryInstance, oldValue, value, -1));
				}	
			}
		}
		private CList<EClassifier> _EClassifiers;
		public CList<EClassifier> EClassifiers {
			get {
				if (_EClassifiers == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EPackage_eClassifiers;
					_EClassifiers = new CList<EClassifier>(this, feature);
				}
				return _EClassifiers;
			}
		}
		private CList<EPackage> _ESubpackages;
		public CList<EPackage> ESubpackages {
			get {
				if (_ESubpackages == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EPackage_eSubpackages;
					_ESubpackages = new CList<EPackage>(this, feature);
				}
				return _ESubpackages;
			}
		}
		private EPackage _ESuperPackage;
		public EPackage ESuperPackage {
			get { return _ESuperPackage; }
			set {
				EPackage oldValue = _ESuperPackage;
				_ESuperPackage = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EPackage_eSuperPackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EPackage_eSuperPackage, oldValue, value, -1));
				}	
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
					throw new System.ArgumentException();
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
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.ecore
