using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EClass : EModelElement,ENamedElement,EClassifier {
		bool IsAbstract { get; set; }
		bool IsInterface { get; set; }
		CList<EClass> ESuperTypes { get;  }
		CList<EOperation> EOperations { get;  }
		CList<EAttribute> EAllAttributes { get;  }
		CList<EReference> EAllReferences { get;  }
		CList<EReference> EReferences { get;  }
		CList<EAttribute> EAttributes { get;  }
		CList<EReference> EAllContainments { get;  }
		CList<EOperation> EAllOperations { get;  }
		CList<EStructuralFeature> EAllStructuralFeatures { get;  }
		CList<EClass> EAllSuperTypes { get;  }
		EAttribute EIDAttribute { get;  }
		CList<EStructuralFeature> EStructuralFeatures { get;  }
		CList<EGenericType> EGenericSuperTypes { get;  }
		CList<EGenericType> EAllGenericSuperTypes { get;  }
		
	}
	
	public class EClassImpl : EClassifierImpl, EClass {
		// PROTECTED REGION ID(EClass.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EClassImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EClass.constructor) ENABLED START
	
			// PROTECTED REGION END
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
		private CList<EAttribute> _EAllAttributes;
		public CList<EAttribute> EAllAttributes {
			get {
				// PROTECTED REGION ID(EClass.eAllAttributes) ENABLED START
				return default(CList<EAttribute>);
				// PROTECTED REGION END
			}
		}
		private CList<EReference> _EAllReferences;
		public CList<EReference> EAllReferences {
			get {
				// PROTECTED REGION ID(EClass.eAllReferences) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		private CList<EReference> _EReferences;
		public CList<EReference> EReferences {
			get {
				// PROTECTED REGION ID(EClass.eReferences) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		private CList<EAttribute> _EAttributes;
		public CList<EAttribute> EAttributes {
			get {
				// PROTECTED REGION ID(EClass.eAttributes) ENABLED START
				return default(CList<EAttribute>);
				// PROTECTED REGION END
			}
		}
		private CList<EReference> _EAllContainments;
		public CList<EReference> EAllContainments {
			get {
				// PROTECTED REGION ID(EClass.eAllContainments) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		private CList<EOperation> _EAllOperations;
		public CList<EOperation> EAllOperations {
			get {
				// PROTECTED REGION ID(EClass.eAllOperations) ENABLED START
				return default(CList<EOperation>);
				// PROTECTED REGION END
			}
		}
		private CList<EStructuralFeature> _EAllStructuralFeatures;
		public CList<EStructuralFeature> EAllStructuralFeatures {
			get {
				// PROTECTED REGION ID(EClass.eAllStructuralFeatures) ENABLED START
				return default(CList<EStructuralFeature>);
				// PROTECTED REGION END
			}
		}
		private CList<EClass> _EAllSuperTypes;
		public CList<EClass> EAllSuperTypes {
			get {
				// PROTECTED REGION ID(EClass.eAllSuperTypes) ENABLED START
				return default(CList<EClass>);
				// PROTECTED REGION END
			}
		}
		private EAttribute _EIDAttribute;
		public EAttribute EIDAttribute {
			get {
				// PROTECTED REGION ID(EClass.eIDAttribute) ENABLED START
				return default(EAttribute);
				// PROTECTED REGION END
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
		private CList<EGenericType> _EAllGenericSuperTypes;
		public CList<EGenericType> EAllGenericSuperTypes {
			get {
				// PROTECTED REGION ID(EClass.eAllGenericSuperTypes) ENABLED START
				return default(CList<EGenericType>);
				// PROTECTED REGION END
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "abstract" : 
				IsAbstract = (bool)value;
				break;															
			case "interface" : 
				IsInterface = (bool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "abstract" : 
				return IsAbstract;															
			case "interface" : 
				return IsInterface;															
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
