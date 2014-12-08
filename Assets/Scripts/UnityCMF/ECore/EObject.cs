using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.ECore {
	 
	public interface EObject : CObject {
		
	}
	
	public class EObjectImpl : CObjectImpl, EObject {
		// PROTECTED REGION ID(EObject.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EObjectImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(EObject.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
	}
} // UnityCMF.ecore
