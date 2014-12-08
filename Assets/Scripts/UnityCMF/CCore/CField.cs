using System;
using System.Collections.Generic;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public class C2DField<ElementType> : AbstractCValueSet<ElementType> where ElementType : C2DFieldElement 
	{
		private readonly ElementType[,] _values;

		public ElementType this[int index_x, int index_y] {
			get { return _values[index_x, index_y]; }
			set { 
				ElementType oldValue = _values[index_x, index_y];
				_values[index_x, index_y] = value; 

				CNotify(CActionType.SET, oldValue, value, index_y*_values.GetLength(1) + index_x); 

				value.X = index_x;
				value.Y = index_y;
			}
		}

		public C2DField (int h, int w, CObject owner, EStructuralFeature feature): base(owner, feature)
		{
			_values = new ElementType[h,w];
		}

		public override object Get (int index)
		{
			return this[index / _values.GetLength (1), index % _values.GetLength (1)];
		}

		public override void Set (int index, object value)
		{
			this[index / _values.GetLength (1), index % _values.GetLength (1)] = (ElementType)value;
		}

		public override void RemoveAt (int index)
		{
			this[index / _values.GetLength (1), index % _values.GetLength (1)] = default(ElementType);
		}

		public override void Insert (object element, int index)
		{
			throw new InvalidOperationException();
		}
	}
}

