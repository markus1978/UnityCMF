using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(ETypedElement.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface ETypedElement : EModelElement,ENamedElement {
		bool Ordered { get; set; }
		void SetOrdered(bool value, object data);
		bool Unique { get; set; }
		void SetUnique(bool value, object data);
		int LowerBound { get; set; }
		void SetLowerBound(int value, object data);
		int UpperBound { get; set; }
		void SetUpperBound(int value, object data);
		bool Many { get;  }
		bool Required { get;  }
		EClassifier EType { get; set; }
		void SetEType(EClassifier value, object data);
		EGenericType EGenericType { get; set; }
		void SetEGenericType(EGenericType value, object data);
		
		
	}
	public class ETypedElementImpl : ENamedElementImpl, ETypedElement {
	
		public ETypedElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(ETypedElement.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(ETypedElement.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		public  bool Many {
			get {
				// PROTECTED REGION ID(ETypedElement.Many) ENABLED START
				return UpperBound == -1 || UpperBound > 1;
				// PROTECTED REGION END
			}
		}
		
		public  bool Required {
			get {
				// PROTECTED REGION ID(ETypedElement.Required) ENABLED START
				return default(bool);
				// PROTECTED REGION END
			}
		}
		
		
		#endregion
		
		private bool _ordered;
		public  bool Ordered {
			get {
				return _ordered;
			}
			set {
				bool oldValue = _ordered;
				_ordered = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_Ordered)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_Ordered, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetOrdered(bool value, object data) {
			bool oldValue = _ordered;
			_ordered = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_Ordered)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_Ordered, oldValue, value, -1, data));
			}
		}
		
		private bool _unique;
		public  bool Unique {
			get {
				return _unique;
			}
			set {
				bool oldValue = _unique;
				_unique = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_Unique)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_Unique, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetUnique(bool value, object data) {
			bool oldValue = _unique;
			_unique = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_Unique)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_Unique, oldValue, value, -1, data));
			}
		}
		
		private int _lowerBound;
		public  int LowerBound {
			get {
				return _lowerBound;
			}
			set {
				int oldValue = _lowerBound;
				_lowerBound = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_LowerBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_LowerBound, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetLowerBound(int value, object data) {
			int oldValue = _lowerBound;
			_lowerBound = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_LowerBound)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_LowerBound, oldValue, value, -1, data));
			}
		}
		
		private int _upperBound;
		public  int UpperBound {
			get {
				return _upperBound;
			}
			set {
				int oldValue = _upperBound;
				_upperBound = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_UpperBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_UpperBound, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetUpperBound(int value, object data) {
			int oldValue = _upperBound;
			_upperBound = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_UpperBound)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_UpperBound, oldValue, value, -1, data));
			}
		}
		
		private EClassifier _eType;
		public  EClassifier EType {
			get {
				return _eType;
			}
			set {
				EClassifier oldValue = _eType;
				_eType = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_EType)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_EType, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetEType(EClassifier value, object data) {
			EClassifier oldValue = _eType;
			_eType = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_EType)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_EType, oldValue, value, -1, data));
			}
		}
		
		private EGenericType _eGenericType;
		public  EGenericType EGenericType {
			get {
				return _eGenericType;
			}
			set {
				EGenericType oldValue = _eGenericType;
				_eGenericType = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_EGenericType)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_EGenericType, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetEGenericType(EGenericType value, object data) {
			EGenericType oldValue = _eGenericType;
			_eGenericType = value;
			if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
			if (value != null) (value as CObjectImpl).CContainer = this;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.ETypedElement_EGenericType)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.ETypedElement_EGenericType, oldValue, value, -1, data));
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
					base.CSet(feature, value);
					break;
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
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eGenericType" :
					EGenericType = null;
					break;
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
