using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EClass : EModelElement,ENamedElement,EClassifier {
		bool Abstract { get; set; }
		bool Interface { get; set; }
		CList<EClass> ESuperTypes { get; }
		CList<EOperation> EOperations { get; }
		CList<EAttribute> EAllAttributes { get; }
		CList<EReference> EAllReferences { get; }
		CList<EReference> EReferences { get; }
		CList<EAttribute> EAttributes { get; }
		CList<EReference> EAllContainments { get; }
		CList<EOperation> EAllOperations { get; }
		CList<EStructuralFeature> EAllStructuralFeatures { get; }
		CList<EClass> EAllSuperTypes { get; }
		EAttribute EIDAttribute { get;  }
		CList<EStructuralFeature> EStructuralFeatures { get; }
		CList<EGenericType> EGenericSuperTypes { get; }
		CList<EGenericType> EAllGenericSuperTypes { get; }
		
	}
	public class EClassImpl : EClassifierImpl, EClass {
		// PROTECTED REGION ID(EClass.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EClassImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EClass.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private bool _abstract;
		public bool Abstract {
			get { return _abstract; }
			set {
				bool oldValue = _abstract;
				_abstract = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_Abstract)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_Abstract, oldValue, value, -1));
				}	
			}
		}
		private bool _interface;
		public bool Interface {
			get { return _interface; }
			set {
				bool oldValue = _interface;
				_interface = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_Interface)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_Interface, oldValue, value, -1));
				}	
			}
		}
		private CList<EClass> _eSuperTypes;
		public CList<EClass> ESuperTypes {
			get {
				if (_eSuperTypes == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_ESuperTypes;
					_eSuperTypes = new CList<EClass>(this, feature);
				}
				return _eSuperTypes;
			}
		}
		private CList<EOperation> _eOperations;
		public CList<EOperation> EOperations {
			get {
				if (_eOperations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_EOperations;
					_eOperations = new CList<EOperation>(this, feature);
				}
				return _eOperations;
			}
		}
		private CList<EAttribute> _eAllAttributes;
		public CList<EAttribute> EAllAttributes {
			get {
				// PROTECTED REGION ID(EClass.EAllAttributes) ENABLED START
				return default(CList<EAttribute>);
				// PROTECTED REGION END
			}
		}
		private CList<EReference> _eAllReferences;
		public CList<EReference> EAllReferences {
			get {
				// PROTECTED REGION ID(EClass.EAllReferences) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		private CList<EReference> _eReferences;
		public CList<EReference> EReferences {
			get {
				// PROTECTED REGION ID(EClass.EReferences) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		private CList<EAttribute> _eAttributes;
		public CList<EAttribute> EAttributes {
			get {
				// PROTECTED REGION ID(EClass.EAttributes) ENABLED START
				return default(CList<EAttribute>);
				// PROTECTED REGION END
			}
		}
		private CList<EReference> _eAllContainments;
		public CList<EReference> EAllContainments {
			get {
				// PROTECTED REGION ID(EClass.EAllContainments) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		private CList<EOperation> _eAllOperations;
		public CList<EOperation> EAllOperations {
			get {
				// PROTECTED REGION ID(EClass.EAllOperations) ENABLED START
				return default(CList<EOperation>);
				// PROTECTED REGION END
			}
		}
		private CList<EStructuralFeature> _eAllStructuralFeatures;
		public CList<EStructuralFeature> EAllStructuralFeatures {
			get {
				// PROTECTED REGION ID(EClass.EAllStructuralFeatures) ENABLED START
				return default(CList<EStructuralFeature>);
				// PROTECTED REGION END
			}
		}
		private CList<EClass> _eAllSuperTypes;
		public CList<EClass> EAllSuperTypes {
			get {
				// PROTECTED REGION ID(EClass.EAllSuperTypes) ENABLED START
				return default(CList<EClass>);
				// PROTECTED REGION END
			}
		}
		private EAttribute _eIDAttribute;
		public EAttribute EIDAttribute {
			get {
				// PROTECTED REGION ID(EClass.EIDAttribute) ENABLED START
				return default(EAttribute);
				// PROTECTED REGION END
			}
		}
		private CList<EStructuralFeature> _eStructuralFeatures;
		public CList<EStructuralFeature> EStructuralFeatures {
			get {
				if (_eStructuralFeatures == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_EStructuralFeatures;
					_eStructuralFeatures = new CList<EStructuralFeature>(this, feature);
				}
				return _eStructuralFeatures;
			}
		}
		private CList<EGenericType> _eGenericSuperTypes;
		public CList<EGenericType> EGenericSuperTypes {
			get {
				if (_eGenericSuperTypes == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_EGenericSuperTypes;
					_eGenericSuperTypes = new CList<EGenericType>(this, feature);
				}
				return _eGenericSuperTypes;
			}
		}
		private CList<EGenericType> _eAllGenericSuperTypes;
		public CList<EGenericType> EAllGenericSuperTypes {
			get {
				// PROTECTED REGION ID(EClass.EAllGenericSuperTypes) ENABLED START
				return default(CList<EGenericType>);
				// PROTECTED REGION END
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "abstract" : 
				Abstract = (bool)value;
				break;															
			case "interface" : 
				Interface = (bool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "abstract" : 
				return Abstract;															
			case "interface" : 
				return Interface;															
			case "eSuperTypes" : 
				return ESuperTypes;															
			case "eOperations" : 
				return EOperations;															
			case "eAllAttributes" : 
				return EAllAttributes;															
			case "eAllReferences" : 
				return EAllReferences;															
			case "eReferences" : 
				return EReferences;															
			case "eAttributes" : 
				return EAttributes;															
			case "eAllContainments" : 
				return EAllContainments;															
			case "eAllOperations" : 
				return EAllOperations;															
			case "eAllStructuralFeatures" : 
				return EAllStructuralFeatures;															
			case "eAllSuperTypes" : 
				return EAllSuperTypes;															
			case "eIDAttribute" : 
				return EIDAttribute;															
			case "eStructuralFeatures" : 
				return EStructuralFeatures;															
			case "eGenericSuperTypes" : 
				return EGenericSuperTypes;															
			case "eAllGenericSuperTypes" : 
				return EAllGenericSuperTypes;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
