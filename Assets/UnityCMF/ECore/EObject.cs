using UnityCMF.CCore;

namespace UnityCMF.ECore {
	 
	public interface EObject : CObject {
	}
	
	public class EObjectImpl : CObjectImpl, EObject {
		public EObjectImpl(UnityCMF.ECore.EClass eClass) {
			EObjectImpl(eClass);
		}
		
	}
} // UnityCMF.ecore
