using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public class CContentHandler
	{
		public event CHandleNotification CNotification;

		public void AddToSource(CObject cObject) {
			cObject.CNotification += HandleNotification;
		}

		protected virtual void HandleNotification(CAction action) {
			if (action.Feature is EReference && (action.Feature as EReference).IsContainment) {
				if (action.OldValue != null && action.OldValue is CObject) {
					(action.OldValue as CObject).CNotification -= HandleNotification;
				}
				if (action.NewValue != null && action.NewValue is CObject) {
					(action.NewValue as CObject).CNotification += HandleNotification;
				}
			}
			if (CNotification != null) {
				CNotification(action);
			}
		}
	}
}

