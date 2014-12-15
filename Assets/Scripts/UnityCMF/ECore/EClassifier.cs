using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EClassifier : EModelElement,ENamedElement {
		string InstanceClassName { get; set; }
		string InstanceTypeName { get; set; }
		EPackage EPackage { get; set; }
		CList<ETypeParameter> ETypeParameters { get; }
		UnityCMF.CCore.CPackage CPackage { get; set; }
		
	}
	public class EClassifierImpl : ENamedElementImpl, EClassifier {
		// PROTECTED REGION ID(EClassifier.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EClassifierImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EClassifier.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private string _instanceClassName;
		public string InstanceClassName {
			get { return _instanceClassName; }
			set {
				string oldValue = _instanceClassName;
				_instanceClassName = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_InstanceClassName)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_InstanceClassName, oldValue, value, -1));
				}	
			}
		}
		private string _instanceTypeName;
		public string InstanceTypeName {
			get { return _instanceTypeName; }
			set {
				string oldValue = _instanceTypeName;
				_instanceTypeName = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_InstanceTypeName)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_InstanceTypeName, oldValue, value, -1));
				}	
			}
		}
		private EPackage _ePackage;
		public EPackage EPackage {
			get { return _ePackage; }
			set {
				EPackage oldValue = _ePackage;
				_ePackage = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_EPackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_EPackage, oldValue, value, -1));
				}	
			}
		}
		private CList<ETypeParameter> _eTypeParameters;
		public CList<ETypeParameter> ETypeParameters {
			get {
				if (_eTypeParameters == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClassifier_ETypeParameters;
					_eTypeParameters = new CList<ETypeParameter>(this, feature);
				}
				return _eTypeParameters;
			}
		}
		private UnityCMF.CCore.CPackage _cPackage;
		public UnityCMF.CCore.CPackage CPackage {
			get { return _cPackage; }
			set {
				UnityCMF.CCore.CPackage oldValue = _cPackage;
				_cPackage = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClassifier_CPackage)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClassifier_CPackage, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "instanceClassName" : 
				InstanceClassName = (string)value;
				break;															
			case "instanceTypeName" : 
				InstanceTypeName = (string)value;
				break;															
			case "ePackage" : 
				EPackage = (EPackage)value;
				break;															
			case "cPackage" : 
				CPackage = (UnityCMF.CCore.CPackage)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "instanceClassName" : 
				return InstanceClassName;															
			case "instanceTypeName" : 
				return InstanceTypeName;															
			case "ePackage" : 
				return EPackage;															
			case "eTypeParameters" : 
				return ETypeParameters;															
			case "cPackage" : 
				return CPackage;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
