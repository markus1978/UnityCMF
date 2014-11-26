using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Door : Entity {
	}
	
	public class DoorImpl : CObjectImpl, Door {
		public DoorImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
	}
} // UnityCMF.kmm
