using System;
using System.Collections.Generic;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public class C2DField<ElementType> : AbstractCValueSet<ElementType> where ElementType : C2DFieldElement 
	{
		private readonly ElementType[,] _values;

		public int DimensionX { get { return _values.GetLength (1); } }
		public int DimensionY { get { return _values.GetLength (2); } }

		public ElementType this[int index_x, int index_y] {
			get { return _values[index_x, index_y]; }
			set { 
				ElementType oldValue = _values[index_x, index_y];
				_values[index_x, index_y] = value; 

				CNotify(CActionType.SET, oldValue, value, index_y*DimensionX + index_x); 

				value.X = index_x;
				value.Y = index_y;
			}
		}

		public C2DField (int h, int w, CObject owner, EStructuralFeature feature): this(h, w, owner, feature, false) {}

		public C2DField (int h, int w, CObject owner, EStructuralFeature feature, bool initialize): base(owner, feature)
		{
			_values = new ElementType[h,w];
			if (initialize) {
				EFactory factory = feature.EType.EPackage.EFactoryInstance;
				EClass eClass = feature.EType as EClass;
				for (int y = 0; y < h; y++) {
					for (int x = 0; x < w; x++) {
						// TODO factory and package reflection is missing.
					}
				}
			}
		}

		public override object Get (int index)
		{
			return this[index / _values.GetLength (1), index % DimensionY];
		}

		public override void Set (int index, object value)
		{
			this[index / _values.GetLength (1), index % DimensionX] = (ElementType)value;
		}

		public override void RemoveAt (int index)
		{
			this[index / DimensionX, index % DimensionX] = default(ElementType);
		}

		public override void Insert (object element, int index)
		{
			throw new InvalidOperationException();
		}
	}
}

