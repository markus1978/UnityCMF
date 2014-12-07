using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Door : Entity {
		
	}
	
	public class DoorImpl : EntityImpl, Door {
		public DoorImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Door.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		
	}
} // UnityCMF.kmm
