using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Item : Entity {
	}
	
	public class ItemImpl : CObjectImpl, Item {
		public ItemImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
	}
} // UnityCMF.kmm
