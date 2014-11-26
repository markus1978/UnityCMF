using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EReference : EModelElement,ENamedElement,ETypedElement,EStructuralFeature {
		bool IsContainment { get; set; }
		bool IsResolveProxies { get; set; }
		EReference EOpposite { get; set; }
		CList<EAttribute> EKeys { get; }
	}
	
	public class EReferenceImpl : CObjectImpl, EReference {
		public EReferenceImpl(UnityCMF.ECore.EClass eClass) {
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
		private bool _IsChangeable;
		public bool IsChangeable {
			get { return _IsChangeable; }
			set {
				bool oldValue = _IsChangeable;
				_IsChangeable = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_changeable)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_changeable, oldValue, value, -1));
				}	
			}
		}
		private bool _IsVolatile;
		public bool IsVolatile {
			get { return _IsVolatile; }
			set {
				bool oldValue = _IsVolatile;
				_IsVolatile = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_volatile)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_volatile, oldValue, value, -1));
				}	
			}
		}
		private bool _IsTransient;
		public bool IsTransient {
			get { return _IsTransient; }
			set {
				bool oldValue = _IsTransient;
				_IsTransient = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_transient)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_transient, oldValue, value, -1));
				}	
			}
		}
		private string _DefaultValueLiteral;
		public string DefaultValueLiteral {
			get { return _DefaultValueLiteral; }
			set {
				string oldValue = _DefaultValueLiteral;
				_DefaultValueLiteral = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_defaultValueLiteral)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_defaultValueLiteral, oldValue, value, -1));
				}	
			}
		}
		private bool _IsUnsettable;
		public bool IsUnsettable {
			get { return _IsUnsettable; }
			set {
				bool oldValue = _IsUnsettable;
				_IsUnsettable = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_unsettable)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_unsettable, oldValue, value, -1));
				}	
			}
		}
		private bool _IsDerived;
		public bool IsDerived {
			get { return _IsDerived; }
			set {
				bool oldValue = _IsDerived;
				_IsDerived = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_derived)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_derived, oldValue, value, -1));
				}	
			}
		}
		private EClass _EContainingClass;
		public EClass EContainingClass {
			get { return _EContainingClass; }
			set {
				EClass oldValue = _EContainingClass;
				_EContainingClass = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_eContainingClass)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EStructuralFeature_eContainingClass, oldValue, value, -1));
				}	
			}
		}
		private bool _IsContainment;
		public bool IsContainment {
			get { return _IsContainment; }
			set {
				bool oldValue = _IsContainment;
				_IsContainment = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EReference_containment)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EReference_containment, oldValue, value, -1));
				}	
			}
		}
		private bool _IsResolveProxies;
		public bool IsResolveProxies {
			get { return _IsResolveProxies; }
			set {
				bool oldValue = _IsResolveProxies;
				_IsResolveProxies = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EReference_resolveProxies)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EReference_resolveProxies, oldValue, value, -1));
				}	
			}
		}
		private EReference _EOpposite;
		public EReference EOpposite {
			get { return _EOpposite; }
			set {
				EReference oldValue = _EOpposite;
				_EOpposite = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EReference_eOpposite)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EReference_eOpposite, oldValue, value, -1));
				}	
			}
		}
		private CList<EAttribute> _EKeys;
		public CList<EAttribute> EKeys {
			get {
				if (_EKeys == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EReference_eKeys;
					_EKeys = new CList<EAttribute>(this, feature);
				}
				return _EKeys;
			}
		}
	}
} // UnityCMF.ecore
