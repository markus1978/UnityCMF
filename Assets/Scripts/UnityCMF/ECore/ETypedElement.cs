using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface ETypedElement : EModelElement,ENamedElement {
		bool IsOrdered { get; set; }
		bool IsUnique { get; set; }
		int LowerBound { get; set; }
		int UpperBound { get; set; }
		bool IsMany { get;  }
		bool IsRequired { get;  }
		EClassifier EType { get; set; }
		EGenericType EGenericType { get; set; }
		
	}
	
	public class ETypedElementImpl : ENamedElementImpl, ETypedElement {
		// PROTECTED REGION ID(ETypedElement.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ETypedElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(ETypedElement.constructor) ENABLED START
	
			// PROTECTED REGION END
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
		private bool _IsMany;
		public bool IsMany {
			get {
				// PROTECTED REGION ID(ETypedElement.many) ENABLED START
				return default(bool);
				// PROTECTED REGION END
			}
		}
		private bool _IsRequired;
		public bool IsRequired {
			get {
				// PROTECTED REGION ID(ETypedElement.required) ENABLED START
				return default(bool);
				// PROTECTED REGION END
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
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "ordered" : 
				IsOrdered = (bool)value;
				break;															
			case "unique" : 
				IsUnique = (bool)value;
				break;															
			case "lowerBound" : 
				LowerBound = (int)value;
				break;															
			case "upperBound" : 
				UpperBound = (int)value;
				break;															
			case "eType" : 
				EType = (EClassifier)value;
				break;															
			case "eGenericType" : 
				EGenericType = (EGenericType)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "ordered" : 
				return IsOrdered;															
			case "unique" : 
				return IsUnique;															
			case "lowerBound" : 
				return LowerBound;															
			case "upperBound" : 
				return UpperBound;															
			case "many" : 
				return IsMany;															
			case "required" : 
				return IsRequired;															
			case "eType" : 
				return EType;															
			case "eGenericType" : 
				return EGenericType;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.ecore
