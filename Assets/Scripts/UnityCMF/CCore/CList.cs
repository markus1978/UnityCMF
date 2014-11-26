using System.Collections.Generic;

namespace UnityCMF.CCore {

	public class CList<ElementType> 
	{
		private CObject _owner;
		private UnityCMF.ECore.EStructuralFeature _feature;
		private List<ElementType> _values = new List<ElementType>();

		public CList(CObject owner, UnityCMF.ECore.EStructuralFeature feature) {
			_owner = owner;
			_feature = feature;
		}

		public ElementType this[int index]
		{
			get { return _values[index]; }
			set { 
				ElementType oldValue = _values[index];
				_values[index] = value; 
				if (_owner.CNotificationRequired(_feature)) {
					_owner.CNotify(new CAction(_owner, CActionType.SET, _feature, oldValue, value, index)); 
				}
			}
		}

		public void Add(ElementType value)
		{
			_values.Add(value);

			if (_owner.CNotificationRequired(_feature)) {
				_owner.CNotify(new CAction(_owner, CActionType.ADD, _feature, null, value, _values.Count - 1));
			}
		}

		public bool Remove(ElementType value)
		{
			int index = _values.IndexOf(value);
			if (index >= 0) { 
				RemoveAt(index);
				return true;
			} else {
				return false;
			}
		}

		public void RemoveAt(int index)
		{
			ElementType oldValue = _values[index];
			_values.RemoveAt(index);

			if (_owner.CNotificationRequired(_feature)) {
				_owner.CNotify(new CAction(_owner, CActionType.REMOVE, _feature, oldValue, null, index));
			}
		}
	}
	
} // UnityCMF.CCore
