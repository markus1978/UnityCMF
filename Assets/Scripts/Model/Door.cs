using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Door : Entity {
		
	}
	public class DoorImpl : EntityImpl, Door {
		// PROTECTED REGION ID(Door.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public DoorImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Door.constructor) ENABLED START
	
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

} // UnityCMF.kmm
