using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EAnnotation : EModelElement {
		string Source { get; set; }
		CList<EStringToStringMapEntry> Details { get; }
		EModelElement EModelElement { get; set; }
		CList<EObject> Contents { get; }
		CList<EObject> References { get; }
	}
	
	public class EAnnotationImpl : CObjectImpl, EAnnotation {
		public EAnnotationImpl(UnityCMF.ECore.EClass eClass) {
			EObjectImpl(eClass);
		}
		
		private CList<EAnnotation> _EAnnotations;
		public CList<EAnnotation> EAnnotations {
			get {
				if (_EAnnotations == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EModelElement_eAnnotations;
					_EAnnotations = new CList<EAnnotation>(this, feature);
				}
				return _EAnnotations;
			}
		}
		private string _Source;
		public string Source {
			get { return _Source; }
			set {
				string oldValue = _Source;
				_Source = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EAnnotation_source)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EAnnotation_source, oldValue, value, -1));
				}	
			}
		}
		private CList<EStringToStringMapEntry> _Details;
		public CList<EStringToStringMapEntry> Details {
			get {
				if (_Details == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EAnnotation_details;
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
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.EAnnotation_eModelElement)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.EAnnotation_eModelElement, oldValue, value, -1));
				}	
			}
		}
		private CList<EObject> _Contents;
		public CList<EObject> Contents {
			get {
				if (_Contents == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EAnnotation_contents;
					_Contents = new CList<EObject>(this, feature);
				}
				return _Contents;
			}
		}
		private CList<EObject> _References;
		public CList<EObject> References {
			get {
				if (_References == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.EAnnotation_references;
					_References = new CList<EObject>(this, feature);
				}
				return _References;
			}
		}
	}
} // UnityCMF.ecore
