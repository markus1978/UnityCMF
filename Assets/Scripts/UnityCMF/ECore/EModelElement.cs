using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EModelElement : CObject {
		CList<EAnnotation> EAnnotations { get; }
		
	}
	public class EModelElementImpl : CObjectImpl, EModelElement {
		// PROTECTED REGION ID(EModelElement.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EModelElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EModelElement.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private CList<EAnnotation> _eAnnotations;
		public CList<EAnnotation> EAnnotations {
			get {
				if (_eAnnotations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EModelElement_EAnnotations;
					_eAnnotations = new CList<EAnnotation>(this, feature);
				}
				return _eAnnotations;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "eAnnotations" : 
				return EAnnotations;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
