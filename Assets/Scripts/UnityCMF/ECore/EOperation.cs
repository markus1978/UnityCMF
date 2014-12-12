using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EOperation : EModelElement,ENamedElement,ETypedElement {
		EClass EContainingClass { get; set; }
		CList<ETypeParameter> ETypeParameters { get; }
		CList<EParameter> EParameters { get; }
		CList<EClassifier> EExceptions { get; }
		CList<EGenericType> EGenericExceptions { get; }
		
	}
	public class EOperationImpl : ETypedElementImpl, EOperation {
		// PROTECTED REGION ID(EOperation.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EOperationImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EOperation.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private EClass _eContainingClass;
		public EClass EContainingClass {
			get { return _eContainingClass; }
			set {
				EClass oldValue = _eContainingClass;
				_eContainingClass = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EOperation_EContainingClass)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EOperation_EContainingClass, oldValue, value, -1));
				}	
			}
		}
		private CList<ETypeParameter> _eTypeParameters;
		public CList<ETypeParameter> ETypeParameters {
			get {
				if (_eTypeParameters == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_ETypeParameters;
					_eTypeParameters = new CList<ETypeParameter>(this, feature);
				}
				return _eTypeParameters;
			}
		}
		private CList<EParameter> _eParameters;
		public CList<EParameter> EParameters {
			get {
				if (_eParameters == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_EParameters;
					_eParameters = new CList<EParameter>(this, feature);
				}
				return _eParameters;
			}
		}
		private CList<EClassifier> _eExceptions;
		public CList<EClassifier> EExceptions {
			get {
				if (_eExceptions == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_EExceptions;
					_eExceptions = new CList<EClassifier>(this, feature);
				}
				return _eExceptions;
			}
		}
		private CList<EGenericType> _eGenericExceptions;
		public CList<EGenericType> EGenericExceptions {
			get {
				if (_eGenericExceptions == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EOperation_EGenericExceptions;
					_eGenericExceptions = new CList<EGenericType>(this, feature);
				}
				return _eGenericExceptions;
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
