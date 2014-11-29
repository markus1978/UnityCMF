using System.Collections.Generic;

namespace UnityCMF.CCore {

	public class CList<ElementType> : AbstractCValueSet<ElementType>
	{
		private List<ElementType> _values = new List<ElementType>();

		public CList(CObject owner, UnityCMF.ECore.EStructuralFeature feature): base(owner, feature)
		{
		}

		public ElementType this[int index]
		{
			get { return _values[index]; }
			set { 
				ElementType oldValue = _values[index];
				_values[index] = value; 
				CNotify(CActionType.SET, oldValue, value, index); 
			}
		}

		public void Add(ElementType value)
		{
			_values.Add(value);
			CNotify(CActionType.ADD, default(ElementType), value, _values.Count - 1);
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

			CNotify(CActionType.REMOVE, oldValue, default(ElementType), index);
		}
	}
	
} // UnityCMF.CCore
