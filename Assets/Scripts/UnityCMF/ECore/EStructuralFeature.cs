using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EStructuralFeature : EModelElement,ENamedElement,ETypedElement {
		bool IsChangeable { get; set; }
		bool IsVolatile { get; set; }
		bool IsTransient { get; set; }
		string DefaultValueLiteral { get; set; }
		bool IsUnsettable { get; set; }
		bool IsDerived { get; set; }
		EClass EContainingClass { get; set; }
	}
	
	public class EStructuralFeatureImpl : CObjectImpl, EStructuralFeature {
		public EStructuralFeatureImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
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
		private bool _IsOrdered;
		public bool IsOrdered {
			get { return _IsOrdered; }
			set {
				bool oldValue = _IsOrdered;
				_IsOrdered = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_ordered)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_ordered, oldValue, value, -1));
				}	
			}
		}
		private bool _IsUnique;
		public bool IsUnique {
			get { return _IsUnique; }
			set {
				bool oldValue = _IsUnique;
				_IsUnique = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_unique)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_unique, oldValue, value, -1));
				}	
			}
		}
		private int _LowerBound;
		public int LowerBound {
			get { return _LowerBound; }
			set {
				int oldValue = _LowerBound;
				_LowerBound = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_lowerBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_lowerBound, oldValue, value, -1));
				}	
			}
		}
		private int _UpperBound;
		public int UpperBound {
			get { return _UpperBound; }
			set {
				int oldValue = _UpperBound;
				_UpperBound = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_upperBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_upperBound, oldValue, value, -1));
				}	
			}
		}
		private EClassifier _EType;
		public EClassifier EType {
			get { return _EType; }
			set {
				EClassifier oldValue = _EType;
				_EType = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_eType)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_eType, oldValue, value, -1));
				}	
			}
		}
		private EGenericType _EGenericType;
		public EGenericType EGenericType {
			get { return _EGenericType; }
			set {
				EGenericType oldValue = _EGenericType;
				_EGenericType = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_eGenericType)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_eGenericType, oldValue, value, -1));
				}	
			}
		}
		private bool _IsChangeable;
		public bool IsChangeable {
			get { return _IsChangeable; }
			set {
				bool oldValue = _IsChangeable;
				_IsChangeable = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_changeable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_changeable, oldValue, value, -1));
				}	
			}
		}
		private bool _IsVolatile;
		public bool IsVolatile {
			get { return _IsVolatile; }
			set {
				bool oldValue = _IsVolatile;
				_IsVolatile = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_volatile)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_volatile, oldValue, value, -1));
				}	
			}
		}
		private bool _IsTransient;
		public bool IsTransient {
			get { return _IsTransient; }
			set {
				bool oldValue = _IsTransient;
				_IsTransient = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_transient)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_transient, oldValue, value, -1));
				}	
			}
		}
		private string _DefaultValueLiteral;
		public string DefaultValueLiteral {
			get { return _DefaultValueLiteral; }
			set {
				string oldValue = _DefaultValueLiteral;
				_DefaultValueLiteral = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_defaultValueLiteral)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_defaultValueLiteral, oldValue, value, -1));
				}	
			}
		}
		private bool _IsUnsettable;
		public bool IsUnsettable {
			get { return _IsUnsettable; }
			set {
				bool oldValue = _IsUnsettable;
				_IsUnsettable = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_unsettable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_unsettable, oldValue, value, -1));
				}	
			}
		}
		private bool _IsDerived;
		public bool IsDerived {
			get { return _IsDerived; }
			set {
				bool oldValue = _IsDerived;
				_IsDerived = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_derived)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_derived, oldValue, value, -1));
				}	
			}
		}
		private EClass _EContainingClass;
		public EClass EContainingClass {
			get { return _EContainingClass; }
			set {
				EClass oldValue = _EContainingClass;
				_EContainingClass = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_eContainingClass)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_eContainingClass, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
