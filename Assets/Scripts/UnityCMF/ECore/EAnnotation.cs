using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EAnnotation : EModelElement {
		string Source { get; set; }
		CList<EStringToStringMapEntry> Details { get;  }
		EModelElement EModelElement { get; set; }
		CList<EObject> Contents { get;  }
		CList<EObject> References { get;  }
		
	}
	
	public class EAnnotationImpl : EModelElementImpl, EAnnotation {
		// PROTECTED REGION ID(EAnnotation.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EAnnotationImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EAnnotation.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private string _Source;
		public string Source {
			get { return _Source; }
			set {
				string oldValue = _Source;
				_Source = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAnnotation_source)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAnnotation_source, oldValue, value, -1));
				}	
			}
		}
		private CList<EStringToStringMapEntry> _Details;
		public CList<EStringToStringMapEntry> Details {
			get {
				if (_Details == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EAnnotation_details;
					_Details = new CList<EStringToStringMapEntry>(this, feature);
				}
				return _Details;
			}
		}
		private EModelElement _EModelElement;
		public EModelElement EModelElement {
			get { return _EModelElement; }
			set {
				EModelElement oldValue = _EModelElement;
				_EModelElement = value;
				
				if (CNotificationRequired(ECoreMeta.cINSTANCE.Package.EAnnotation_eModelElement)) {
					CNotify(new CAction(this, CActionType.SET, ECoreMeta.cINSTANCE.Package.EAnnotation_eModelElement, oldValue, value, -1));
				}	
			}
		}
		private CList<EObject> _Contents;
		public CList<EObject> Contents {
			get {
				if (_Contents == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EAnnotation_contents;
					_Contents = new CList<EObject>(this, feature);
				}
				return _Contents;
			}
		}
		private CList<EObject> _References;
		public CList<EObject> References {
			get {
				if (_References == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EAnnotation_references;
					_References = new CList<EObject>(this, feature);
				}
				return _References;
			}
		}
	}
} // UnityCMF.ecore
