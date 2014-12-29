using UnityEngine;
using System.Collections.Generic;
using UnityCMF.ECore;

namespace UnityCMF.CCore {

	public delegate void CHandleNotification(CAction action);

	public interface CObject {
		event CHandleNotification CNotification;

		EClass EClass { get; }
		CObject CContainer { get; }
		EReference CContainingFeature { get; }
		IEnumerable<CObject> CContent { get; }

		bool CNotificationRequired(EStructuralFeature feature);
		void CNotify(CAction action);

		void CSet(EStructuralFeature feature, object value);
		object CGet(EStructuralFeature feature);
		void CRemoveContent (CObject content);
	}

	public class CObjectImpl {

		public EClass EClass { get; private set; }
		public CObject CContainer { get; set; }
		public EReference CContainingFeature { get; set; }

		public event CHandleNotification CNotification;

		public CObjectImpl(UnityCMF.ECore.EClass eClass) {
			if (this is EClassImpl) {
				eClass = this as EClassImpl; // class bootstrap
			} else {
				EClass = eClass;
			}
		}

		public virtual bool CNotificationRequired(EStructuralFeature feature) 
		{
			return CNotification != null && !feature.Derived;
		}

		public void CNotify(CAction action) 
		{
			CNotification(action);
		}

		public virtual void CSet(EStructuralFeature feature, object value) {
			throw new System.InvalidOperationException();
		}

		public virtual object CGet(EStructuralFeature feature) {
			throw new System.InvalidOperationException();
		}

		public virtual void CRemoveContent(CObject content) {
			throw new System.InvalidOperationException();
		}

		public virtual IEnumerable<CObject> CContent {
			get {
				foreach (EReference reference in EClass.EAllReferences) {
					if (reference.Containment && !reference.Derived) {
						object value = CGet(reference);
						if (value is CValueSet) {
							foreach (CObject content in (value as CValueSet)) {
								yield return content;
							}
						} else if (value is CObject) {
							yield return value as CObject;
						}
					}
				}
			}
		}
	}

} // UnityCMF.CCore
