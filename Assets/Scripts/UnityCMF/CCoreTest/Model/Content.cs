using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Ccoretest {
	public interface Content : Interface {
		
	}
	public class ContentImpl : InterfaceImpl, Content {
		// PROTECTED REGION ID(Content.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ContentImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Content.constructor) ENABLED START
	
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
