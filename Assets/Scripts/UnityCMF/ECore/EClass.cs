using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EClass : EModelElement,ENamedElement,EClassifier {
		bool IsAbstract { get; set; }
		bool IsInterface { get; set; }
		CList<EClass> ESuperTypes { get;  }
		CList<EOperation> EOperations { get;  }
		CList<EStructuralFeature> EStructuralFeatures { get;  }
		CList<EGenericType> EGenericSuperTypes { get;  }
		
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
