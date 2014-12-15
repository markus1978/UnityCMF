using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(FieldContent.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.Ccoretest {
	public interface FieldContent : C2DFieldElement {
		
	}
	public class FieldContentImpl : UnityCMF.CCore.C2DFieldElementImpl, FieldContent {
	
		public FieldContentImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(FieldContent.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(FieldContent.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		#endregion
		
		
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
