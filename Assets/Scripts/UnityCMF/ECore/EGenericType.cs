using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EGenericType : CObject {
		EGenericType EUpperBound { get; set; }
		CList<EGenericType> ETypeArguments { get;  }
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

		
		private EGenericType _EUpperBound;
		public EGenericType EUpperBound {
			get { return _EUpperBound; }
			set {
				EGenericType oldValue = _EUpperBound;
				_EUpperBound = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_eUpperBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_eUpperBound, oldValue, value, -1));
				}	
			}
		}
		private CList<EGenericType> _ETypeArguments;
		public CList<EGenericType> ETypeArguments {
			get {
				if (_ETypeArguments == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EGenericType_eTypeArguments;
					_ETypeArguments = new CList<EGenericType>(this, feature);
				}
				return _ETypeArguments;
			}
		}
		private EGenericType _ELowerBound;
		public EGenericType ELowerBound {
			get { return _ELowerBound; }
			set {
				EGenericType oldValue = _ELowerBound;
				_ELowerBound = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_eLowerBound)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_eLowerBound, oldValue, value, -1));
				}	
			}
		}
		private ETypeParameter _ETypeParameter;
		public ETypeParameter ETypeParameter {
			get { return _ETypeParameter; }
			set {
				ETypeParameter oldValue = _ETypeParameter;
				_ETypeParameter = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_eTypeParameter)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_eTypeParameter, oldValue, value, -1));
				}	
			}
		}
		private EClassifier _EClassifier;
		public EClassifier EClassifier {
			get { return _EClassifier; }
			set {
				EClassifier oldValue = _EClassifier;
				_EClassifier = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EGenericType_eClassifier)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EGenericType_eClassifier, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
