using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EOperation : EModelElement,ENamedElement,ETypedElement {
		EClass EContainingClass { get; set; }
		CList<ETypeParameter> ETypeParameters { get;  }
		CList<EParameter> EParameters { get;  }
		CList<EClassifier> EExceptions { get;  }
		CList<EGenericType> EGenericExceptions { get;  }
		
	}
	
	public class EOperationImpl : ETypedElementImpl, EOperation {
		// PROTECTED REGION ID(EOperation.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EOperationImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EOperation.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private EClass _EContainingClass;
		public EClass EContainingClass {
			get { return _EContainingClass; }
			set {
				EClass oldValue = _EContainingClass;
				_EContainingClass = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EOperation_eContainingClass)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EOperation_eContainingClass, oldValue, value, -1));
				}	
			}
		}
		private CList<ETypeParameter> _ETypeParameters;
		public CList<ETypeParameter> ETypeParameters {
			get {
				if (_ETypeParameters == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_eTypeParameters;
					_ETypeParameters = new CList<ETypeParameter>(this, feature);
				}
				return _ETypeParameters;
			}
		}
		private CList<EParameter> _EParameters;
		public CList<EParameter> EParameters {
			get {
				if (_EParameters == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_eParameters;
					_EParameters = new CList<EParameter>(this, feature);
				}
				return _EParameters;
			}
		}
		private CList<EClassifier> _EExceptions;
		public CList<EClassifier> EExceptions {
			get {
				if (_EExceptions == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_eExceptions;
					_EExceptions = new CList<EClassifier>(this, feature);
				}
				return _EExceptions;
			}
		}
		private CList<EGenericType> _EGenericExceptions;
		public CList<EGenericType> EGenericExceptions {
			get {
				if (_EGenericExceptions == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_eGenericExceptions;
					_EGenericExceptions = new CList<EGenericType>(this, feature);
				}
				return _EGenericExceptions;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "eContainingClass" : 
				EContainingClass = (EClass)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "eContainingClass" : 
				return EContainingClass;															
			case "eTypeParameters" : 
				return ETypeParameters;															
			case "eParameters" : 
				return EParameters;															
			case "eExceptions" : 
				return EExceptions;															
			case "eGenericExceptions" : 
				return EGenericExceptions;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.ecore
