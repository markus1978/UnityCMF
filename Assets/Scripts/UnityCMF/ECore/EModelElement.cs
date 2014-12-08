using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EModelElement : CObject {
		CList<EAnnotation> EAnnotations { get;  }
		
	}
	
	public class EModelElementImpl : CObjectImpl, EModelElement {
		// PROTECTED REGION ID(EModelElement.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EModelElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EModelElement.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private CList<EAnnotation> _EAnnotations;
		public CList<EAnnotation> EAnnotations {
			get {
				if (_EAnnotations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EModelElement_eAnnotations;
					_EAnnotations = new CList<EAnnotation>(this, feature);
				}
				return _EAnnotations;
			}
		}
	}
} // UnityCMF.ecore
