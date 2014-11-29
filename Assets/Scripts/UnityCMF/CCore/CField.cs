using System;
using System.Collections.Generic;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public class C2DField<ElementType> : AbstractCValueSet<ElementType>
	{
		private readonly ElementType[,] _values;

		public ElementType this[int index_x, int index_y] {
			get { return _values[index_x, index_y]; }
			set { 
				ElementType oldValue = _values[index_x, index_y];
				_values[index_x, index_y] = value; 
				CNotify(CActionType.SET, oldValue, value, index_y*_values.GetLength(1) + index_x); 
			}
		}

		public C2DField (int h, int w, CObject owner, EStructuralFeature feature): base(owner, feature)
		{
			_values = new ElementType[h,w];
		}
	}
}

