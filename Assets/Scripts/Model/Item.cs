using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Item : Poolable,Entity {
		
		void ApplyPerTurn();
	}
	public class ItemImpl : EntityImpl, Item {
		// PROTECTED REGION ID(Item.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ItemImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Item.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		public virtual void ApplyPerTurn() {
			// PROTECTED REGION ID(Item.applyPerTurn_) ENABLED START
			throw new System.InvalidOperationException("Unsupported Operation Item.applyPerTurn()");
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
