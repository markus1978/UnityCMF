using UnityEngine;
using System.Collections.Generic;

namespace UnityCMF.CCore {

	public class CViewContext {

		public delegate void CHandleNotificationWithContext(CAction action, CViewContext context); 

		private static readonly Stack<CViewContext> _contextStack = new Stack<CViewContext>();

		public static void Open(CViewContext context) {
			_contextStack.Push (context);
		}

		public static void CloseCurrent() {
			_contextStack.Peek().Close();
			_contextStack.Pop();
		}

		public static CViewContext Current {
			get {
				if (_contextStack.Count == 0) {
					return null;
				} else {
					return _contextStack.Peek();
				}
			}
		}

		private List<CAction> _actions = new List<CAction>();
		private List<CHandleNotificationWithContext> _notificationHandlers = new List<CHandleNotificationWithContext>();

		public void AddAction(CAction action, CHandleNotificationWithContext notificationHandler) {
			_actions.Add (action);
			_notificationHandlers.Add (notificationHandler);
		}

		public virtual void Reset() {
			_actions.Clear();
			_notificationHandlers.Clear();
		}

		public virtual void Close() {
			int count = _actions.Count;
			for (int i = 0; i < count; i++) {
				CHandleNotificationWithContext handler = _notificationHandlers[i];
				if (handler != null) {
					handler(_actions[i], this);
				}
			}
			Reset();
		}
	}
}