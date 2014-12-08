using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Entity : CObject {
		
		void apply();
	}
	
	public class EntityImpl : CObjectImpl, Entity {
		// PROTECTED REGION ID(Entity.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EntityImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Entity.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		public virtual void apply() {
			// PROTECTED REGION ID(Entity.apply_) ENABLED START
			Debug.LogError("Unsupported Operation Entity.apply()");
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
