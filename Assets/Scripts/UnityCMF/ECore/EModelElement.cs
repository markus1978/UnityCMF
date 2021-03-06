using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EModelElement.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EModelElement : CObject {
		CList<EAnnotation> EAnnotations { get; }
		
		
	}
	public class EModelElementImpl : CObjectImpl, EModelElement {
	
		public EModelElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EModelElement.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EModelElement.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		private CList<EAnnotation> _eAnnotations;
		public  CList<EAnnotation> EAnnotations {
			get {
				if (_eAnnotations == null) {
					EStructuralFeature feature = ECoreMeta.cINSTANCE.Package.EModelElement_EAnnotations;
					_eAnnotations = new CList<EAnnotation>(false, this, feature);
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
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				case "eAnnotations" :
					_eAnnotations.RemoveAt(_eAnnotations.IndexOf(value)); 
					break;
				default:
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
