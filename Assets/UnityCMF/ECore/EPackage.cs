using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EPackage : EModelElement,ENamedElement {
		string NsURI { get; set; }
		string NsPrefix { get; set; }
		EFactory EFactoryInstance { get; set; }
		CList<EClassifier> EClassifiers { get; }
		CList<EPackage> ESubpackages { get; }
		EPackage ESuperPackage { get; set; }
	}
	
	public class EPackageImpl : CObjectImpl, EPackage {
		public EPackageImpl(UnityCMF.ECore.EClass eClass) {
			EObjectImpl(eClass);
		}
		
		private CList<EAnnotation> _EAnnotations;
		public CList<EAnnotation> EAnnotations {
			get {
				if (_EAnnotations == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EModelElement_eAnnotations;
					_EAnnotations = new CList<EAnnotation>(this, feature);
				}
				return _EAnnotations;
			}
		}
		private string _Name;
		public string Name {
			get { return _Name; }
			set {
				string oldValue = _Name;
				_Name = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ENamedElement_name)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ENamedElement_name, oldValue, value, -1));
				}	
			}
		}
		private string _NsURI;
		public string NsURI {
			get { return _NsURI; }
			set {
				string oldValue = _NsURI;
				_NsURI = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_nsURI)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_nsURI, oldValue, value, -1));
				}	
			}
		}
		private string _NsPrefix;
		public string NsPrefix {
			get { return _NsPrefix; }
			set {
				string oldValue = _NsPrefix;
				_NsPrefix = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_nsPrefix)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_nsPrefix, oldValue, value, -1));
				}	
			}
		}
		private EFactory _EFactoryInstance;
		public EFactory EFactoryInstance {
			get { return _EFactoryInstance; }
			set {
				EFactory oldValue = _EFactoryInstance;
				_EFactoryInstance = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_eFactoryInstance)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_eFactoryInstance, oldValue, value, -1));
				}	
			}
		}
		private CList<EClassifier> _EClassifiers;
		public CList<EClassifier> EClassifiers {
			get {
				if (_EClassifiers == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_eClassifiers;
					_EClassifiers = new CList<EClassifier>(this, feature);
				}
				return _EClassifiers;
			}
		}
		private CList<EPackage> _ESubpackages;
		public CList<EPackage> ESubpackages {
			get {
				if (_ESubpackages == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_eSubpackages;
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
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_eSuperPackage)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EPackage_eSuperPackage, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
