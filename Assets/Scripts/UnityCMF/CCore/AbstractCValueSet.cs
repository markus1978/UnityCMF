using System;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{

	interface CValueSet : System.Collections.IEnumerable {
		object Get(int index);
		void Set(int index, object value);
		void Set(int index, object value, object data);
		void Insert(object element, int index);
		void Insert(object element, int index, object data);
		void RemoveAt(int index);
		void RemoveAt(int index, object data);
		int IndexOf(object element);
	}

	public abstract class AbstractCValueSet<ElementType> : CValueSet, System.Collections.Generic.IEnumerable<ElementType>
	{			
		private readonly CObject _owner;
		private readonly EStructuralFeature _feature;

		protected void CNotify(CActionType actionType, ElementType oldValue, ElementType newValue, int index, object data)
		{
			if (_owner.CNotificationRequired(_feature)) {
				_owner.CNotify(new CAction(_owner, actionType, _feature, oldValue, newValue, index, data)); 
			}
		}
		
		public AbstractCValueSet (CObject owner, EStructuralFeature feature)
		{
			_owner = owner;
			_feature = feature;
		}

		protected void InverseAddSet(ElementType newValue, ElementType oldValue) {
			if (_feature is EReference && (_feature as EReference).Containment) {
				if (newValue != null) {
					CObject container = (newValue as CObject).CContainer;
					if (container != null) {
						container.CRemoveContent(newValue as CObject);
					}
					(newValue as CObjectImpl).CContainer = (CObject)_owner;
					(newValue as CObjectImpl).CContainingFeature = _feature as EReference;
				}
				if (oldValue != null) {
					(oldValue as CObjectImpl).CContainer = null;
				}
			}
		}

		protected void InverseRemove(ElementType oldValue) {
			if (_feature is EReference && (_feature as EReference).Containment) {
				(oldValue as CObjectImpl).CContainer = null;
			}
		}

		public abstract object Get(int index);
		public void Set(int index, object value) {
			Set(index, value, null);
		}
		public void Insert(object element, int index) {
			Insert(element, index, null);
		}
		public void RemoveAt(int index) {
			RemoveAt (index, null);
		}

		public abstract void Set(int index, object value, object data);
		public abstract void Insert(object element, int index, object data);
		public abstract void RemoveAt(int index, object data);

		public abstract int IndexOf(object element);

		public abstract System.Collections.Generic.IEnumerator<ElementType> GetEnumerator();	
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}
	}
}

