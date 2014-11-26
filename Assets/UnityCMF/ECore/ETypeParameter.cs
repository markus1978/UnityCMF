using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface ETypeParameter : EModelElement,ENamedElement {
		CList<EGenericType> EBounds { get; }
	}
	
	public class ETypeParameterImpl : CObjectImpl, ETypeParameter {
		public ETypeParameterImpl(UnityCMF.ECore.EClass eClass) {
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
		private string _Name;
		public string Name {
			get { return _Name; }
			set {
				string oldValue = _Name;
				_Name = value;
				
				if (CNotificationRequired(UnityCMF.ecore.EcorePackage.cINSTANCE.ENamedElement_name)) {
					CNotify(new Action(this, CAction.SET, UnityCMF.ecore.EcorePackage.cINSTANCE.ENamedElement_name, oldValue, value, -1));
				}	
			}
		}
		private CList<EGenericType> _EBounds;
		public CList<EGenericType> EBounds {
			get {
				if (_EBounds == null) {
					CStructuralFeature feature = UnityCMF.ecore.EcorePackage.cINSTANCE.ETypeParameter_eBounds;
					_EBounds = new CList<EGenericType>(this, feature);
				}
				return _EBounds;
			}
		}
	}
} // UnityCMF.ecore
