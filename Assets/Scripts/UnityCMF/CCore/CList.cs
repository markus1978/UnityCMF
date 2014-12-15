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
				ElementType oldValue = _values[index];
				if (value == null) {
					_values.RemoveAt(index);
				} else {
					_values[index] = value; 
				}
				InverseAddSet(value, oldValue);
				CNotify(CActionType.SET, oldValue, value, index); 
			}
		}

		public void Add(ElementType value)
		{
			_values.Add(value);
			InverseAddSet(value, default(ElementType));
			CNotify(CActionType.ADD, default(ElementType), value, _values.Count - 1);
		}

		public void Insert(ElementType value, int index)
		{
			_values.Insert(index, value);
			InverseAddSet(value, default(ElementType));
			CNotify(CActionType.ADD, default(ElementType), value, index);
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

		public override void RemoveAt(int index)
		{
			ElementType oldValue = _values[index];
			_values.RemoveAt(index);
			InverseRemove(oldValue);

			CNotify(CActionType.REMOVE, oldValue, default(ElementType), index);
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

		public System.Collections.Generic.IEnumerator<ElementType> GetEnumerator() {
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
		
		public override void Set(int index, object value) {
			this[index] = (ElementType)value;
		}

		public override void Insert(object element, int index)
		{
			Insert((ElementType)element, index);
		}
	}
	
} // UnityCMF.CCore
