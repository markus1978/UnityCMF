using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EGenericType : CObject {
		EGenericType EUpperBound { get; set; }
		CList<EGenericType> ETypeArguments { get; }
		EGenericType ELowerBound { get; set; }
		ETypeParameter ETypeParameter { get; set; }
		EClassifier EClassifier { get; set; }
	}
	
	public class EGenericTypeImpl : CObjectImpl, EGenericType {
		public EGenericTypeImpl(UnityCMF.ECore.EClass eClass) {
			EObjectImpl(eClass);
		}
		
		private EGenericType _EUpperBound;
		public EGenericType EUpperBound {
			get { return _EUpperBound; }
			set {
				EGenericType oldValue = _EUpperBound;
				_EUpperBound = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eUpperBound)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eUpperBound, oldValue, value, -1));
				}	
			}
		}
		private CList<EGenericType> _ETypeArguments;
		public CList<EGenericType> ETypeArguments {
			get {
				if (_ETypeArguments == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eTypeArguments;
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
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eLowerBound)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eLowerBound, oldValue, value, -1));
				}	
			}
		}
		private ETypeParameter _ETypeParameter;
		public ETypeParameter ETypeParameter {
			get { return _ETypeParameter; }
			set {
				ETypeParameter oldValue = _ETypeParameter;
				_ETypeParameter = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eTypeParameter)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eTypeParameter, oldValue, value, -1));
				}	
			}
		}
		private EClassifier _EClassifier;
		public EClassifier EClassifier {
			get { return _EClassifier; }
			set {
				EClassifier oldValue = _EClassifier;
				_EClassifier = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eClassifier)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EGenericType_eClassifier, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
