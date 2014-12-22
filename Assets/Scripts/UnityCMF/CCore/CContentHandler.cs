using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public class CContentHandler
	{
		public event CHandleNotification CNotification;

		public void AddToSource(CObject cObject) {
			cObject.CNotification += HandleNotification;

			foreach (EReference reference in cObject.EClass.EAllReferences) {
				if (reference.Containment && !reference.Derived) {
					object value = cObject.CGet(reference);
					if (value is CValueSet) {
						foreach (CObject content in (value as CValueSet)) {
							AddToSource(content);
						}
					} else if (value is CObject) {
						AddToSource(value as CObject);
					}
				}
			}
		}

		public void RemoveFromSource(CObject cObject) {
			cObject.CNotification -= HandleNotification;
			
			foreach (EReference reference in cObject.EClass.EAllReferences) {
				if (reference.Containment && !reference.Derived) {
					object value = cObject.CGet(reference);
					if (value is CValueSet) {
						foreach (CObject content in (value as CValueSet)) {
							RemoveFromSource(content);
						}
					} else if (value is CObject) {
						RemoveFromSource(value as CObject);
					}
				}
			}
		}

		protected virtual bool FilterContent(CObject content) {
			return true;
		}

		protected virtual void HandleNotification(CAction action) {
			if (action.Feature is EReference && (action.Feature as EReference).Containment) {
				if (action.OldValue != null && action.OldValue is CObject) {
					if (FilterContent(action.OldValue as CObject)) {
						RemoveFromSource(action.OldValue as CObject);
					}
				}
				if (action.NewValue != null && action.NewValue is CObject) {
					if (FilterContent(action.NewValue as CObject)) {
						AddToSource(action.NewValue as CObject);
					}
				}
			}
			if (CNotification != null) {
				CNotification(action);
			}
		}
	}
}

