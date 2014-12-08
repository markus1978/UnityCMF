using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EStructuralFeature : EModelElement,ENamedElement,ETypedElement {
		bool IsChangeable { get; set; }
		bool IsVolatile { get; set; }
		bool IsTransient { get; set; }
		string DefaultValueLiteral { get; set; }
		bool IsUnsettable { get; set; }
		bool IsDerived { get; set; }
		EClass EContainingClass { get; set; }
		
	}
	
	public class EStructuralFeatureImpl : ETypedElementImpl, EStructuralFeature {
		// PROTECTED REGION ID(EStructuralFeature.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EStructuralFeatureImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EStructuralFeature.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private bool _IsChangeable;
		public bool IsChangeable {
			get { return _IsChangeable; }
			set {
				bool oldValue = _IsChangeable;
				_IsChangeable = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_changeable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_changeable, oldValue, value, -1));
				}	
			}
		}
		private bool _IsVolatile;
		public bool IsVolatile {
			get { return _IsVolatile; }
			set {
				bool oldValue = _IsVolatile;
				_IsVolatile = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_volatile)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_volatile, oldValue, value, -1));
				}	
			}
		}
		private bool _IsTransient;
		public bool IsTransient {
			get { return _IsTransient; }
			set {
				bool oldValue = _IsTransient;
				_IsTransient = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_transient)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_transient, oldValue, value, -1));
				}	
			}
		}
		private string _DefaultValueLiteral;
		public string DefaultValueLiteral {
			get { return _DefaultValueLiteral; }
			set {
				string oldValue = _DefaultValueLiteral;
				_DefaultValueLiteral = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_defaultValueLiteral)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_defaultValueLiteral, oldValue, value, -1));
				}	
			}
		}
		private bool _IsUnsettable;
		public bool IsUnsettable {
			get { return _IsUnsettable; }
			set {
				bool oldValue = _IsUnsettable;
				_IsUnsettable = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_unsettable)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_unsettable, oldValue, value, -1));
				}	
			}
		}
		private bool _IsDerived;
		public bool IsDerived {
			get { return _IsDerived; }
			set {
				bool oldValue = _IsDerived;
				_IsDerived = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_derived)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_derived, oldValue, value, -1));
				}	
			}
		}
		private EClass _EContainingClass;
		public EClass EContainingClass {
			get { return _EContainingClass; }
			set {
				EClass oldValue = _EContainingClass;
				_EContainingClass = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EStructuralFeature_eContainingClass)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EStructuralFeature_eContainingClass, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ecore
