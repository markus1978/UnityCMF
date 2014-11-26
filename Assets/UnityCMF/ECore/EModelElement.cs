using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EModelElement : CObject {
		CList<EAnnotation> EAnnotations { get; }
	}
	
	public class EModelElementImpl : CObjectImpl, EModelElement {
		public EModelElementImpl(UnityCMF.ECore.EClass eClass) {
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
	}
} // UnityCMF.ecore
