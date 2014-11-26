using UnityEngine;
using System.Collections;

namespace UnityCMF.CCore {

	public interface CObject {
		UnityCMF.ECore.EClass EClass { public get; }
	}

	public class CObjectImpl {

		public UnityCMF.ECore.EClass EClass { public get; private set; }

		public CObjectImpl(UnityCMF.ECore.EClass eClass) {
			EClass = eClass;
		}

		protected virtual bool CNotificationRequired(UnityCMF.ECore.EStructuralFeature feature) 
		{
			return feature.IsChangable;
		}

		protected void CNotify(CAction action) 
		{
		}
	}

} // UnityCMF.CCore
