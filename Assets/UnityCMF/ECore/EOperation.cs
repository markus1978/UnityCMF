using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EOperation : EModelElement,ENamedElement,ETypedElement {
		EClass EContainingClass { get; set; }
		CList<ETypeParameter> ETypeParameters { get; }
		CList<EParameter> EParameters { get; }
		CList<EClassifier> EExceptions { get; }
		CList<EGenericType> EGenericExceptions { get; }
	}
	
	public class EOperationImpl : CObjectImpl, EOperation {
		public EOperationImpl(UnityCMF.ECore.EClass eClass) {
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
		private bool _IsOrdered;
		public bool IsOrdered {
			get { return _IsOrdered; }
			set {
				bool oldValue = _IsOrdered;
				_IsOrdered = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_ordered)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_ordered, oldValue, value, -1));
				}	
			}
		}
		private bool _IsUnique;
		public bool IsUnique {
			get { return _IsUnique; }
			set {
				bool oldValue = _IsUnique;
				_IsUnique = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_unique)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_unique, oldValue, value, -1));
				}	
			}
		}
		private int _LowerBound;
		public int LowerBound {
			get { return _LowerBound; }
			set {
				int oldValue = _LowerBound;
				_LowerBound = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_lowerBound)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_lowerBound, oldValue, value, -1));
				}	
			}
		}
		private int _UpperBound;
		public int UpperBound {
			get { return _UpperBound; }
			set {
				int oldValue = _UpperBound;
				_UpperBound = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_upperBound)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_upperBound, oldValue, value, -1));
				}	
			}
		}
		private EClassifier _EType;
		public EClassifier EType {
			get { return _EType; }
			set {
				EClassifier oldValue = _EType;
				_EType = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_eType)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_eType, oldValue, value, -1));
				}	
			}
		}
		private EGenericType _EGenericType;
		public EGenericType EGenericType {
			get { return _EGenericType; }
			set {
				EGenericType oldValue = _EGenericType;
				_EGenericType = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_eGenericType)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ETypedElement_eGenericType, oldValue, value, -1));
				}	
			}
		}
		private EClass _EContainingClass;
		public EClass EContainingClass {
			get { return _EContainingClass; }
			set {
				EClass oldValue = _EContainingClass;
				_EContainingClass = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EOperation_eContainingClass)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EOperation_eContainingClass, oldValue, value, -1));
				}	
			}
		}
		private CList<ETypeParameter> _ETypeParameters;
		public CList<ETypeParameter> ETypeParameters {
			get {
				if (_ETypeParameters == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EOperation_eTypeParameters;
					_ETypeParameters = new CList<ETypeParameter>(this, feature);
				}
				return _ETypeParameters;
			}
		}
		private CList<EParameter> _EParameters;
		public CList<EParameter> EParameters {
			get {
				if (_EParameters == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EOperation_eParameters;
					_EParameters = new CList<EParameter>(this, feature);
				}
				return _EParameters;
			}
		}
		private CList<EClassifier> _EExceptions;
		public CList<EClassifier> EExceptions {
			get {
				if (_EExceptions == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EOperation_eExceptions;
					_EExceptions = new CList<EClassifier>(this, feature);
				}
				return _EExceptions;
			}
		}
		private CList<EGenericType> _EGenericExceptions;
		public CList<EGenericType> EGenericExceptions {
			get {
				if (_EGenericExceptions == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EOperation_eGenericExceptions;
					_EGenericExceptions = new CList<EGenericType>(this, feature);
				}
				return _EGenericExceptions;
			}
		}
	}
} // UnityCMF.ecore
