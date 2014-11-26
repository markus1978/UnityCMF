using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EClassifier : EModelElement,ENamedElement {
		string InstanceClassName { get; set; }
		string InstanceTypeName { get; set; }
		EPackage EPackage { get; set; }
		CList<ETypeParameter> ETypeParameters { get; }
	}
	
	public class EClassifierImpl : CObjectImpl, EClassifier {
		public EClassifierImpl(UnityCMF.ECore.EClass eClass) {
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
		private string _InstanceClassName;
		public string InstanceClassName {
			get { return _InstanceClassName; }
			set {
				string oldValue = _InstanceClassName;
				_InstanceClassName = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EClassifier_instanceClassName)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EClassifier_instanceClassName, oldValue, value, -1));
				}	
			}
		}
		private string _InstanceTypeName;
		public string InstanceTypeName {
			get { return _InstanceTypeName; }
			set {
				string oldValue = _InstanceTypeName;
				_InstanceTypeName = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EClassifier_instanceTypeName)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EClassifier_instanceTypeName, oldValue, value, -1));
				}	
			}
		}
		private EPackage _EPackage;
		public EPackage EPackage {
			get { return _EPackage; }
			set {
				EPackage oldValue = _EPackage;
				_EPackage = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EClassifier_ePackage)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EClassifier_ePackage, oldValue, value, -1));
				}	
			}
		}
		private CList<ETypeParameter> _ETypeParameters;
		public CList<ETypeParameter> ETypeParameters {
			get {
				if (_ETypeParameters == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EClassifier_eTypeParameters;
					_ETypeParameters = new CList<ETypeParameter>(this, feature);
				}
				return _ETypeParameters;
			}
		}
	}
} // UnityCMF.ecore
