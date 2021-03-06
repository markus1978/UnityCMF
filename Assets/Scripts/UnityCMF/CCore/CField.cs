using System;
using System.Collections.Generic;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public class C2DField<ElementType> : AbstractCValueSet<ElementType> where ElementType : C2DFieldElement 
	{
		private readonly ElementType[,] _values;

		public int DimensionX { get { return _values.GetLength (0); } }
		public int DimensionY { get { return _values.GetLength (1); } }

		public ElementType this[int index_x, int index_y] {
			get { return _values[index_x, index_y]; }
			set { 
				BasicSet(index_x, index_y, value, null);
			}
		}

		private void BasicSet (int index_x, int index_y, ElementType value, object data) {
			ElementType oldValue = _values[index_x, index_y];
			_values[index_x, index_y] = value; 
			InverseAddSet(value, oldValue);
			
			if (value != null) {
				value.X = index_x;
				value.Y = index_y;
			}
			
			CNotify(CActionType.SET, oldValue, value, index_y*DimensionX + index_x, data); 
		}

		public C2DField (int dimensionX, int dimensionY, CObject owner, EStructuralFeature feature): this(dimensionX, dimensionY, false, owner, feature) {}

		public C2DField (int dimensionX, int dimensionY, bool initialize, CObject owner, EStructuralFeature feature): base(owner, feature)
		{
			_values = new ElementType[dimensionX,dimensionY];
			if (initialize) {
				CFactory factory = feature.EType.CPackage.FactoryInstance;
				EClass eClass = feature.EType as EClass;
				for (int x = 0; x < dimensionX; x++) {
					for (int y = 0; y < dimensionY; y++) {
						CObject elementAsCObject = factory.create(eClass);
						this[x,y] = (ElementType)elementAsCObject;
					}
				}
			}
		}

		public override object Get (int index)
		{
			return this[index / _values.GetLength (1), index % DimensionY];
		}

		public override void Set (int index, object value, object data)
		{
			int index_x = index / DimensionX;
			int index_y = index % DimensionX;

			BasicSet(index_x, index_y, (ElementType) value, data);
		}

		public override void RemoveAt (int index, object data)
		{
			int index_x = index / DimensionX;
			int index_y = index % DimensionX;
			
			BasicSet(index_x, index_y, default(ElementType), data);
		}

		public override void Insert (object element, int index, object data)
		{
			throw new InvalidOperationException();
		}

		public override int IndexOf (object element)
		{
			int i = 0;
			for (int x = 0; x < DimensionX; x++) {
				for (int y = 0; y < DimensionY; y++) {
					if (EqualityComparer<ElementType>.Equals(_values[x, y], element)) {
						return i;
					} else {
						i++;
					}
				}
			}
			throw new System.InvalidOperationException ();
		}

		public override System.Collections.Generic.IEnumerator<ElementType> GetEnumerator() {
			for (int x = 0; x < DimensionX; x++) {
				for (int y = 0; y < DimensionY; y++) {
					yield return this[x,y];
				}
			}
		}
	}
}

