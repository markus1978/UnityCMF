using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public class CContentHandler
	{
		public event CHandleNotification CNotification;

		public void AddToSource(CObject cObject) {
			cObject.CNotification += HandleNotification;

			foreach (CObject content in cObject.CContent) {
				AddToSource(content);
			}
		}

		public void RemoveFromSource(CObject cObject) {
			cObject.CNotification -= HandleNotification;
			
			foreach (CObject content in cObject.CContent) {
				RemoveFromSource(content);
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

