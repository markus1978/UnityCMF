using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EClass : EModelElement,ENamedElement,EClassifier {
		bool IsAbstract { get; set; }
		bool IsInterface { get; set; }
		CList<EClass> ESuperTypes { get; }
		CList<EOperation> EOperations { get; }
		CList<EStructuralFeature> EStructuralFeatures { get; }
		CList<EGenericType> EGenericSuperTypes { get; }
	}
	
	public class EClassImpl : CObjectImpl, EClass {
		public EClassImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
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
		private bool _IsAbstract;
		public bool IsAbstract {
			get { return _IsAbstract; }
			set {
				bool oldValue = _IsAbstract;
				_IsAbstract = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_abstract)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_abstract, oldValue, value, -1));
				}	
			}
		}
		private bool _IsInterface;
		public bool IsInterface {
			get { return _IsInterface; }
			set {
				bool oldValue = _IsInterface;
				_IsInterface = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_interface)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_interface, oldValue, value, -1));
				}	
			}
		}
		private CList<EClass> _ESuperTypes;
		public CList<EClass> ESuperTypes {
			get {
				if (_ESuperTypes == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_eSuperTypes;
					_ESuperTypes = new CList<EClass>(this, feature);
				}
				return _ESuperTypes;
			}
		}
		private CList<EOperation> _EOperations;
		public CList<EOperation> EOperations {
			get {
				if (_EOperations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_eOperations;
					_EOperations = new CList<EOperation>(this, feature);
				}
				return _EOperations;
			}
		}
		private CList<EStructuralFeature> _EStructuralFeatures;
		public CList<EStructuralFeature> EStructuralFeatures {
			get {
				if (_EStructuralFeatures == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_eStructuralFeatures;
					_EStructuralFeatures = new CList<EStructuralFeature>(this, feature);
				}
				return _EStructuralFeatures;
			}
		}
		private CList<EGenericType> _EGenericSuperTypes;
		public CList<EGenericType> EGenericSuperTypes {
			get {
				if (_EGenericSuperTypes == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_eGenericSuperTypes;
					_EGenericSuperTypes = new CList<EGenericType>(this, feature);
				}
				return _EGenericSuperTypes;
			}
		}
	}
} // UnityCMF.ecore
