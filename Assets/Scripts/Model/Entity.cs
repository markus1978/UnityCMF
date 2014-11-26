using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Entity : CObject {
	}
	
	public class EntityImpl : CObjectImpl, Entity {
		public EntityImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
	}
} // UnityCMF.kmm
