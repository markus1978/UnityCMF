using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EEnum : EModelElement,ENamedElement,EClassifier,EDataType {
		CList<EEnumLiteral> ELiterals { get; }
	}
	
	public class EEnumImpl : CObjectImpl, EEnum {
		public EEnumImpl(UnityCMF.ECore.EClass eClass) {
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
		private bool _IsSerializable;
		public bool IsSerializable {
			get { return _IsSerializable; }
			set {
				bool oldValue = _IsSerializable;
				_IsSerializable = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EDataType_serializable)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EDataType_serializable, oldValue, value, -1));
				}	
			}
		}
		private CList<EEnumLiteral> _ELiterals;
		public CList<EEnumLiteral> ELiterals {
			get {
				if (_ELiterals == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EEnum_eLiterals;
					_ELiterals = new CList<EEnumLiteral>(this, feature);
				}
				return _ELiterals;
			}
		}
	}
} // UnityCMF.ecore
