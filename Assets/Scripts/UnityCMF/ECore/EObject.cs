using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(EObject.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.ECore {
	public interface EObject : CObject {
		EAnnotation EAnnotation { get; }
		
		
	}
	public class EObjectImpl : CObjectImpl, EObject {
	
		public EObjectImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EObject.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(EObject.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		public EAnnotation EAnnotation { 
			get { 
				return CContainer as EAnnotation;
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
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				default:
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ecore
