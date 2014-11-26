using UnityEngine;
using System.Collections;
using UnityCMF.ECore;

namespace UnityCMF.CCore {

	public interface CObject {
		EClass EClass { get; }
		bool CNotificationRequired(EStructuralFeature feature);
		void CNotify(CAction action);
	}

	public class CObjectImpl {

		public EClass EClass { get; private set; }

		public CObjectImpl(UnityCMF.ECore.EClass eClass) {
			EClass = eClass;
		}

		public virtual bool CNotificationRequired(EStructuralFeature feature) 
		{
			return feature.IsChangeable;
		}

		public void CNotify(CAction action) 
		{
		}
	}

} // UnityCMF.CCore
