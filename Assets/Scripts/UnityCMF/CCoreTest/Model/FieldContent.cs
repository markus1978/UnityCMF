using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Ccoretest {
	public interface FieldContent : C2DFieldElement {
		
	}
	public class FieldContentImpl : UnityCMF.CCore.C2DFieldElementImpl, FieldContent {
		// PROTECTED REGION ID(FieldContent.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public FieldContentImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(FieldContent.constructor) ENABLED START
	
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

} // UnityCMF.ccoretest
