using System;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{

	interface CValueSet {
		object Get(int index);
		void Set(int index, object value);
		void Insert(object element, int index);
		void RemoveAt(int index);
	}

	public abstract class AbstractCValueSet<ElementType> : CValueSet
	{			
		private readonly CObject _owner;
		private readonly EStructuralFeature _feature;

		protected void CNotify(CActionType actionType, ElementType oldValue, ElementType newValue, int index)
		{
			if (_owner.CNotificationRequired(_feature)) {
				_owner.CNotify(new CAction(_owner, CActionType.SET, _feature, oldValue, newValue, index)); 
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
					(newValue as CObjectImpl).CContainer = (CObject)_owner;
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
		public abstract void Set(int index, object value);
		public abstract void Insert(object element, int index);
		public abstract void RemoveAt(int index);
	}
}

