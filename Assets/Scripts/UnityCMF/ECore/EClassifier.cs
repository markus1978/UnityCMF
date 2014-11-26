using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EClassifier : EModelElement,ENamedElement {
		string InstanceClassName { get; set; }
		string InstanceTypeName { get; set; }
		EPackage EPackage { get; set; }
		CList<ETypeParameter> ETypeParameters { get; }
	}
	
	public class EClassifierImpl : CObjectImpl, EClassifier {
		public EClassifierImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private CList<EAnnotation> _EAnnotations;
		public CList<EAnnotation> EAnnotations {
			get {
				if (_EAnnotations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EModelElement_eAnnotations;
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
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ENamedElement_name)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ENamedElement_name, oldValue, value, -1));
				}	
			}
		}
		private string _InstanceClassName;
		public string InstanceClassName {
			get { return _InstanceClassName; }
			set {
				string oldValue = _InstanceClassName;
				_InstanceClassName = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_instanceClassName)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_instanceClassName, oldValue, value, -1));
				}	
			}
		}
		private string _InstanceTypeName;
		public string InstanceTypeName {
			get { return _InstanceTypeName; }
			set {
				string oldValue = _InstanceTypeName;
				_InstanceTypeName = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_instanceTypeName)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_instanceTypeName, oldValue, value, -1));
				}	
			}
		}
		private EPackage _EPackage;
		public EPackage EPackage {
			get { return _EPackage; }
			set {
				EPackage oldValue = _EPackage;
				_EPackage = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_ePackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_ePackage, oldValue, value, -1));
				}	
			}
		}
		private CList<ETypeParameter> _ETypeParameters;
		public CList<ETypeParameter> ETypeParameters {
			get {
				if (_ETypeParameters == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClassifier_eTypeParameters;
					_ETypeParameters = new CList<ETypeParameter>(this, feature);
				}
				return _ETypeParameters;
			}
		}
	}
} // UnityCMF.ecore
