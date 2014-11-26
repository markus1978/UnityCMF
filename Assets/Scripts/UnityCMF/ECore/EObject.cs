using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EObject : CObject {
	}
	
	public class EObjectImpl : CObjectImpl, EObject {
		public EObjectImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
	}
} // UnityCMF.ecore
