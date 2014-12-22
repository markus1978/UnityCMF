using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EReference.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EReference : EModelElement,ENamedElement,ETypedElement,EStructuralFeature {
		bool Containment { get; set; }
		bool Container { get;  }
		bool ResolveProxies { get; set; }
		EReference EOpposite { get; set; }
		EClass EReferenceType { get;  }
		CList<EAttribute> EKeys { get; }
		
		
	}
	public class EReferenceImpl : EStructuralFeatureImpl, EReference {
	
		public EReferenceImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EReference.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EReference.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		public bool Container {
			get {
				// PROTECTED REGION ID(EReference.Container) ENABLED START
				return default(bool);
				// PROTECTED REGION END
			}
		}
		public EClass EReferenceType {
			get {
				// PROTECTED REGION ID(EReference.EReferenceType) ENABLED START
				return default(EClass);
				// PROTECTED REGION END
			}
		}
		
		#endregion
		
		private bool _containment;
		public bool Containment {
			get {
				return _containment;
			}
			set {
				bool oldValue = _containment;
				_containment = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EReference_Containment)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EReference_Containment, oldValue, value, -1));
				}	
			}
		}
		private bool _resolveProxies;
		public bool ResolveProxies {
			get {
				return _resolveProxies;
			}
			set {
				bool oldValue = _resolveProxies;
				_resolveProxies = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EReference_ResolveProxies)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EReference_ResolveProxies, oldValue, value, -1));
				}	
			}
		}
		private EReference _eOpposite;
		public EReference EOpposite {
			get {
				return _eOpposite;
			}
			set {
				EReference oldValue = _eOpposite;
				_eOpposite = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EReference_EOpposite)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EReference_EOpposite, oldValue, value, -1));
				}	
			}
		}
		private CList<EAttribute> _eKeys;
		public CList<EAttribute> EKeys {
			get {
				if (_eKeys == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EReference_EKeys;
					_eKeys = new CList<EAttribute>(false, this, feature);
				}
				return _eKeys;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "containment" : 
					Containment = (bool)value;
					break;															
				case "resolveProxies" : 
					ResolveProxies = (bool)value;
					break;															
				case "eOpposite" : 
					EOpposite = (EReference)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "containment" : 
					return Containment;
				case "container" : 
					return Container;
				case "resolveProxies" : 
					return ResolveProxies;
				case "eOpposite" : 
					return EOpposite;
				case "eReferenceType" : 
					return EReferenceType;
				case "eKeys" : 
					return EKeys;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
