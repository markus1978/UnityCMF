using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EGenericType.Namespaces) ENABLED START

// PROTECTED REGION END

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
	
		public EGenericTypeImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EGenericType.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EGenericType.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		public EClassifier ERawType {
			get {
				// PROTECTED REGION ID(EGenericType.ERawType) ENABLED START
				return default(EClassifier);
				// PROTECTED REGION END
			}
		}
		
		#endregion
		
		private EGenericType _eUpperBound;
		public EGenericType EUpperBound {
			get {
				return _eUpperBound;
			}
			set {
				EGenericType oldValue = _eUpperBound;
				_eUpperBound = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
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
					_eTypeArguments = new CList<EGenericType>(false, this, feature);
				}
				return _eTypeArguments;
			}
		}
		private EGenericType _eLowerBound;
		public EGenericType ELowerBound {
			get {
				return _eLowerBound;
			}
			set {
				EGenericType oldValue = _eLowerBound;
				_eLowerBound = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_ELowerBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_ELowerBound, oldValue, value, -1));
				}	
			}
		}
		private ETypeParameter _eTypeParameter;
		public ETypeParameter ETypeParameter {
			get {
				return _eTypeParameter;
			}
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
			get {
				return _eClassifier;
			}
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
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eUpperBound" :
					EUpperBound = null;
					break;
				case "eTypeArguments" :
					_eTypeArguments.RemoveAt(_eTypeArguments.IndexOf(value)); 
					break;
				case "eLowerBound" :
					ELowerBound = null;
					break;
				default:
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
