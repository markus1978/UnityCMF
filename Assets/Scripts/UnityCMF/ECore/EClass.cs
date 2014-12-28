using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EClass.Namespaces) ENABLED START
using System.Collections.Generic;
// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EClass : EModelElement,ENamedElement,EClassifier {
		bool Abstract { get; set; }
		void SetAbstract(bool value, object data);
		bool Interface { get; set; }
		void SetInterface(bool value, object data);
		CList<EClass> ESuperTypes { get; }
		CList<EOperation> EOperations { get; }
		CList<EAttribute> EAllAttributes { get; }
		CList<EReference> EAllReferences { get; }
		CList<EReference> EReferences { get; }
		CList<EAttribute> EAttributes { get; }
		CList<EReference> EAllContainments { get; }
		CList<EOperation> EAllOperations { get; }
		CList<EStructuralFeature> EAllStructuralFeatures { get; }
		CList<EClass> EAllSuperTypes { get; }
		EAttribute EIDAttribute { get;  }
		CList<EStructuralFeature> EStructuralFeatures { get; }
		CList<EGenericType> EGenericSuperTypes { get; }
		CList<EGenericType> EAllGenericSuperTypes { get; }
		
		
	}
	public class EClassImpl : EClassifierImpl, EClass {
	
		public EClassImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EClass.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EClass.ClientCode) ENABLED START
		private CList<EReference> _allReferences = null;
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		public  CList<EAttribute> EAllAttributes {
			get {
				// PROTECTED REGION ID(EClass.EAllAttributes) ENABLED START
				return default(CList<EAttribute>);
				// PROTECTED REGION END
			}
		}
		public  CList<EReference> EAllReferences {
			get {
				// PROTECTED REGION ID(EClass.EAllReferences) ENABLED START
				if (_allReferences == null) {
					_allReferences = new CList<EReference>(this, ECoreMeta.cINSTANCE.Package.EClass_EAllReferences);
				
					Stack<EClass> stack = new Stack<EClass>();
					stack.Push(this);
					while (stack.Count > 0)
					{
						EClass eClass = stack.Pop();
						foreach (EStructuralFeature feature in eClass.EStructuralFeatures) {
							if (feature is EReference) {
								_allReferences.Add(feature as EReference);
							}
						}
						foreach (EClass child in eClass.ESuperTypes)
						{
							stack.Push(child);
						}
					}
				}
				return _allReferences;
				// PROTECTED REGION END
			}
		}
		public  CList<EReference> EReferences {
			get {
				// PROTECTED REGION ID(EClass.EReferences) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		public  CList<EAttribute> EAttributes {
			get {
				// PROTECTED REGION ID(EClass.EAttributes) ENABLED START
				return default(CList<EAttribute>);
				// PROTECTED REGION END
			}
		}
		public  CList<EReference> EAllContainments {
			get {
				// PROTECTED REGION ID(EClass.EAllContainments) ENABLED START
				return default(CList<EReference>);
				// PROTECTED REGION END
			}
		}
		public  CList<EOperation> EAllOperations {
			get {
				// PROTECTED REGION ID(EClass.EAllOperations) ENABLED START
				return default(CList<EOperation>);
				// PROTECTED REGION END
			}
		}
		public  CList<EStructuralFeature> EAllStructuralFeatures {
			get {
				// PROTECTED REGION ID(EClass.EAllStructuralFeatures) ENABLED START
				return default(CList<EStructuralFeature>);
				// PROTECTED REGION END
			}
		}
		public  CList<EClass> EAllSuperTypes {
			get {
				// PROTECTED REGION ID(EClass.EAllSuperTypes) ENABLED START
				return default(CList<EClass>);
				// PROTECTED REGION END
			}
		}
		public  EAttribute EIDAttribute {
			get {
				// PROTECTED REGION ID(EClass.EIDAttribute) ENABLED START
				return default(EAttribute);
				// PROTECTED REGION END
			}
		}
		
		public  CList<EGenericType> EAllGenericSuperTypes {
			get {
				// PROTECTED REGION ID(EClass.EAllGenericSuperTypes) ENABLED START
				return default(CList<EGenericType>);
				// PROTECTED REGION END
			}
		}
		
		#endregion
		
		private bool _abstract;
		public  bool Abstract {
			get {
				return _abstract;
			}
			set {
				bool oldValue = _abstract;
				_abstract = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_Abstract)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_Abstract, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetAbstract(bool value, object data) {
			bool oldValue = _abstract;
			_abstract = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_Abstract)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_Abstract, oldValue, value, -1, data));
			}
		}
		
		private bool _interface;
		public  bool Interface {
			get {
				return _interface;
			}
			set {
				bool oldValue = _interface;
				_interface = value;
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_Interface)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_Interface, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetInterface(bool value, object data) {
			bool oldValue = _interface;
			_interface = value;
			if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EClass_Interface)) {
				CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EClass_Interface, oldValue, value, -1, data));
			}
		}
		
		private CList<EClass> _eSuperTypes;
		public  CList<EClass> ESuperTypes {
			get {
				if (_eSuperTypes == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_ESuperTypes;
					_eSuperTypes = new CList<EClass>(false, this, feature);
				}
				return _eSuperTypes;
			}
		}
		private CList<EOperation> _eOperations;
		public  CList<EOperation> EOperations {
			get {
				if (_eOperations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_EOperations;
					_eOperations = new CList<EOperation>(false, this, feature);
				}
				return _eOperations;
			}
		}
		private CList<EStructuralFeature> _eStructuralFeatures;
		public  CList<EStructuralFeature> EStructuralFeatures {
			get {
				if (_eStructuralFeatures == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_EStructuralFeatures;
					_eStructuralFeatures = new CList<EStructuralFeature>(false, this, feature);
				}
				return _eStructuralFeatures;
			}
		}
		private CList<EGenericType> _eGenericSuperTypes;
		public  CList<EGenericType> EGenericSuperTypes {
			get {
				if (_eGenericSuperTypes == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EClass_EGenericSuperTypes;
					_eGenericSuperTypes = new CList<EGenericType>(false, this, feature);
				}
				return _eGenericSuperTypes;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "abstract" : 
					Abstract = (bool)value;
					break;															
				case "interface" : 
					Interface = (bool)value;
					break;															
				default: 
					base.CSet(feature, value);
					break;
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "abstract" : 
					return Abstract;
				case "interface" : 
					return Interface;
				case "eSuperTypes" : 
					return ESuperTypes;
				case "eOperations" : 
					return EOperations;
				case "eAllAttributes" : 
					return EAllAttributes;
				case "eAllReferences" : 
					return EAllReferences;
				case "eReferences" : 
					return EReferences;
				case "eAttributes" : 
					return EAttributes;
				case "eAllContainments" : 
					return EAllContainments;
				case "eAllOperations" : 
					return EAllOperations;
				case "eAllStructuralFeatures" : 
					return EAllStructuralFeatures;
				case "eAllSuperTypes" : 
					return EAllSuperTypes;
				case "eIDAttribute" : 
					return EIDAttribute;
				case "eStructuralFeatures" : 
					return EStructuralFeatures;
				case "eGenericSuperTypes" : 
					return EGenericSuperTypes;
				case "eAllGenericSuperTypes" : 
					return EAllGenericSuperTypes;
				default: 
					return base.CGet(feature);
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eOperations" :
					_eOperations.RemoveAt(_eOperations.IndexOf(value)); 
					break;
				case "eStructuralFeatures" :
					_eStructuralFeatures.RemoveAt(_eStructuralFeatures.IndexOf(value)); 
					break;
				case "eGenericSuperTypes" :
					_eGenericSuperTypes.RemoveAt(_eGenericSuperTypes.IndexOf(value)); 
					break;
				default:
					base.CRemoveContent(value);
					break;
			}
		}
	}

} // UnityCMF.ecore
