using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EGenericType : CObject {
		EGenericType EUpperBound { get; set; }
		CList<EGenericType> ETypeArguments { get; }
		EClassifier ERawType { get;  }
		EGenericType ELowerBound { get; set; }
		ETypeParameter ETypeParameter { get; set; }
		EClassifier EClassifier { get; set; }
		
	}
	public class EGenericTypeImpl : CObjectImpl, EGenericType {
		// PROTECTED REGION ID(EGenericType.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EGenericTypeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EGenericType.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private EGenericType _eUpperBound;
		public EGenericType EUpperBound {
			get { return _eUpperBound; }
			set {
				EGenericType oldValue = _eUpperBound;
				_eUpperBound = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_EUpperBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_EUpperBound, oldValue, value, -1));
				}	
			}
		}
		private CList<EGenericType> _eTypeArguments;
		public CList<EGenericType> ETypeArguments {
			get {
				if (_eTypeArguments == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EGenericType_ETypeArguments;
					_eTypeArguments = new CList<EGenericType>(this, feature);
				}
				return _eTypeArguments;
			}
		}
		private EClassifier _eRawType;
		public EClassifier ERawType {
			get {
				// PROTECTED REGION ID(EGenericType.ERawType) ENABLED START
				return default(EClassifier);
				// PROTECTED REGION END
			}
		}
		private EGenericType _eLowerBound;
		public EGenericType ELowerBound {
			get { return _eLowerBound; }
			set {
				EGenericType oldValue = _eLowerBound;
				_eLowerBound = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_ELowerBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_ELowerBound, oldValue, value, -1));
				}	
			}
		}
		private ETypeParameter _eTypeParameter;
		public ETypeParameter ETypeParameter {
			get { return _eTypeParameter; }
			set {
				ETypeParameter oldValue = _eTypeParameter;
				_eTypeParameter = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_ETypeParameter)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_ETypeParameter, oldValue, value, -1));
				}	
			}
		}
		private EClassifier _eClassifier;
		public EClassifier EClassifier {
			get { return _eClassifier; }
			set {
				EClassifier oldValue = _eClassifier;
				_eClassifier = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_EClassifier)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_EClassifier, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "eUpperBound" : 
				EUpperBound = (EGenericType)value;
				break;															
			case "eLowerBound" : 
				ELowerBound = (EGenericType)value;
				break;															
			case "eTypeParameter" : 
				ETypeParameter = (ETypeParameter)value;
				break;															
			case "eClassifier" : 
				EClassifier = (EClassifier)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "eUpperBound" : 
				return EUpperBound;															
			case "eTypeArguments" : 
				return ETypeArguments;															
			case "eRawType" : 
				return ERawType;															
			case "eLowerBound" : 
				return ELowerBound;															
			case "eTypeParameter" : 
				return ETypeParameter;															
			case "eClassifier" : 
				return EClassifier;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
