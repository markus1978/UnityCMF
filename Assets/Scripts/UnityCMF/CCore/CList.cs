using System.Collections.Generic;
using UnityCMF.ECore;

namespace UnityCMF.CCore {

	public class CList<ElementType> : AbstractCValueSet<ElementType>, IEnumerable<ElementType>
	{
		private List<ElementType> _values = new List<ElementType>();

		public CList(CObject owner, UnityCMF.ECore.EStructuralFeature feature): this(false, owner, feature)
		{
		}

		public CList(bool createInstances, CObject owner, UnityCMF.ECore.EStructuralFeature feature): base(owner, feature)
		{
			if (createInstances) {
				CFactory factory = feature.EType.CPackage.FactoryInstance;
				EClass eClass = feature.EType as EClass;
				if (feature.UpperBound <= 0) {
					throw new System.ArgumentException();
				}
				for (int i = 0; i < feature.UpperBound; i++) {
					CObject elementAsCObject = factory.create(eClass);
					Add ((ElementType)elementAsCObject);
				}
			}
		}

		public ElementType this[int index]
		{
			get { return _values[index]; }
			set { 
				Set (index, value); 
			}
		}

		public bool Contains(ElementType value) {
			return _values.Contains (value);
		}

		public void Add(ElementType value) {
			Add (value, null);
		}

		public void Add(ElementType value, object data)
		{
			_values.Add(value);
			InverseAddSet(value, default(ElementType));
			CNotify(CActionType.ADD, default(ElementType), value, _values.Count - 1, data);
		}

		public void Insert(ElementType value, int index) {
			Insert (value, index, null);
		}

		public void Insert(ElementType value, int index, object data)
		{
			_values.Insert(index, value);
			InverseAddSet(value, default(ElementType));
			CNotify(CActionType.ADD, default(ElementType), value, index, data);
		}

		public bool Remove(ElementType value) {
			return Remove (value, null);
		}

		public bool Remove(ElementType value, object data)
		{
			int index = _values.IndexOf(value);
			if (index >= 0) { 
				RemoveAt(index, data);
				return true;
			} else {
				return false;
			}
		}

		public override void RemoveAt(int index, object data)
		{
			ElementType oldValue = _values[index];
			_values.RemoveAt(index);
			InverseRemove(oldValue);

			CNotify(CActionType.REMOVE, oldValue, default(ElementType), index, data);
		}

		public override int IndexOf (object element)
		{
			return _values.IndexOf ((ElementType)element);
		}

		public int Count { 
			get {
				return _values.Count;
			}
		}

		public ElementType Last {
			get {
				if (Count > 0) {
						return this [Count - 1];
				} else {
						return default(ElementType);
				}
			}
		}

		public void Clear() {
			for (int i = _values.Count - 1; i >= 0; i--) {
				RemoveAt(i);
			}
		}

		public override System.Collections.Generic.IEnumerator<ElementType> GetEnumerator() {
			for (int index = 0; index < _values.Count; index++)
			{
				yield return _values[index];
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}

		
		public override object Get(int index) {
			return this[index];
		}
		
		public override void Set(int index, object value, object data) {
			ElementType oldValue = _values[index];
			if (value == null) {
				_values.RemoveAt(index);
			} else {
				_values[index] = (ElementType)value; 
			}
			InverseAddSet((ElementType)value, (ElementType)oldValue);
			CNotify(CActionType.SET, (ElementType)oldValue, (ElementType)value, index, data); 
		}

		public override void Insert(object value, int index, object data)
		{
			Insert((ElementType)value, index, data);
		}


	}
	
} // UnityCMF.CCore
