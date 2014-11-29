using UnityEngine;
using System.Collections.Generic;
using UnityCMF.ECore;

namespace UnityCMF.CCore {

	public delegate void CHandleNotification(CAction action);

	public interface CObject {
		event CHandleNotification CNotification;
		EClass EClass { get; }
		bool CNotificationRequired(EStructuralFeature feature);
		void CNotify(CAction action);
	}

	public class CObjectImpl {

		public EClass EClass { get; private set; }

		public event CHandleNotification CNotification;

		public CObjectImpl(UnityCMF.ECore.EClass eClass) {
			EClass = eClass;
		}

		public virtual bool CNotificationRequired(EStructuralFeature feature) 
		{
			return feature.IsChangeable;
		}

		public void CNotify(CAction action) 
		{
			if (CNotification != null) {
				CNotification(action);
			}
		}
	}

} // UnityCMF.CCore
