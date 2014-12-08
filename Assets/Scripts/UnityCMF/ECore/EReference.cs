using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EReference : EModelElement,ENamedElement,ETypedElement,EStructuralFeature {
		bool IsContainment { get; set; }
		bool IsContainer { get;  }
		bool IsResolveProxies { get; set; }
		EReference EOpposite { get; set; }
		EClass EReferenceType { get;  }
		CList<EAttribute> EKeys { get;  }
		
	}
	
	public class EReferenceImpl : EStructuralFeatureImpl, EReference {
		// PROTECTED REGION ID(EReference.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EReferenceImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EReference.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private bool _IsContainment;
		public bool IsContainment {
			get { return _IsContainment; }
			set {
				bool oldValue = _IsContainment;
				_IsContainment = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EReference_containment)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EReference_containment, oldValue, value, -1));
				}	
			}
		}
		private bool _IsContainer;
		public bool IsContainer {
			get {
				// PROTECTED REGION ID(EReference.container) ENABLED START
				return default(bool);
				// PROTECTED REGION END
			}
		}
		private bool _IsResolveProxies;
		public bool IsResolveProxies {
			get { return _IsResolveProxies; }
			set {
				bool oldValue = _IsResolveProxies;
				_IsResolveProxies = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EReference_resolveProxies)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EReference_resolveProxies, oldValue, value, -1));
				}	
			}
		}
		private EReference _EOpposite;
		public EReference EOpposite {
			get { return _EOpposite; }
			set {
				EReference oldValue = _EOpposite;
				_EOpposite = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EReference_eOpposite)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EReference_eOpposite, oldValue, value, -1));
				}	
			}
		}
		private EClass _EReferenceType;
		public EClass EReferenceType {
			get {
				// PROTECTED REGION ID(EReference.eReferenceType) ENABLED START
				return default(EClass);
				// PROTECTED REGION END
			}
		}
		private CList<EAttribute> _EKeys;
		public CList<EAttribute> EKeys {
			get {
				if (_EKeys == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EReference_eKeys;
					_EKeys = new CList<EAttribute>(this, feature);
				}
				return _EKeys;
			}
		}
	}
} // UnityCMF.ecore
