using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	public interface EObject : CObject {
		
	}
	public class EObjectImpl : CObjectImpl, EObject {
		// PROTECTED REGION ID(EObject.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EObjectImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EObject.constructor) ENABLED START
	
			// PROTECTED REGION END
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
	}

} // UnityCMF.ecore
