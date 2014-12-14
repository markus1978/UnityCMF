using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface ETypedElement : EModelElement,ENamedElement {
		bool Ordered { get; set; }
		bool Unique { get; set; }
		int LowerBound { get; set; }
		int UpperBound { get; set; }
		bool Many { get;  }
		bool Required { get;  }
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
		
		private bool _ordered;
		public bool Ordered {
			get { return _ordered; }
			set {
				bool oldValue = _ordered;
				_ordered = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_Ordered)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_Ordered, oldValue, value, -1));
				}	
			}
		}
		private bool _unique;
		public bool Unique {
			get { return _unique; }
			set {
				bool oldValue = _unique;
				_unique = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_Unique)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_Unique, oldValue, value, -1));
				}	
			}
		}
		private int _lowerBound;
		public int LowerBound {
			get { return _lowerBound; }
			set {
				int oldValue = _lowerBound;
				_lowerBound = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_LowerBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_LowerBound, oldValue, value, -1));
				}	
			}
		}
		private int _upperBound;
		public int UpperBound {
			get { return _upperBound; }
			set {
				int oldValue = _upperBound;
				_upperBound = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_UpperBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_UpperBound, oldValue, value, -1));
				}	
			}
		}
		public bool Many {
			get {
				// PROTECTED REGION ID(ETypedElement.Many) ENABLED START
				return UpperBound == -1 || UpperBound > 1;
				// PROTECTED REGION END
			}
		}
		public bool Required {
			get {
				// PROTECTED REGION ID(ETypedElement.Required) ENABLED START
				return default(bool);
				// PROTECTED REGION END
			}
		}
		private EClassifier _eType;
		public EClassifier EType {
			get { return _eType; }
			set {
				EClassifier oldValue = _eType;
				_eType = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_EType)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_EType, oldValue, value, -1));
				}	
			}
		}
		private EGenericType _eGenericType;
		public EGenericType EGenericType {
			get { return _eGenericType; }
			set {
				EGenericType oldValue = _eGenericType;
				_eGenericType = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_EGenericType)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_EGenericType, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "ordered" : 
				Ordered = (bool)value;
				break;															
			case "unique" : 
				Unique = (bool)value;
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
				return Ordered;															
			case "unique" : 
				return Unique;															
			case "lowerBound" : 
				return LowerBound;															
			case "upperBound" : 
				return UpperBound;															
			case "many" : 
				return Many;															
			case "required" : 
				return Required;															
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
