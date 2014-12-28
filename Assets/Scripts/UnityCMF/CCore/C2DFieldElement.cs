using UnityCMF.CCore;
using UnityCMF.ECore;
// PROTECTED REGION ID(C2DFieldElement.Namespaces) ENABLED START

// PROTECTED REGION END

namespace UnityCMF.CCore {
	public interface C2DFieldElement : CObject {
		int X { get; set; }
		void SetX(int value, object data);
		int Y { get; set; }
		void SetY(int value, object data);
		
		Direction Neighbor(C2DFieldElement other);
		
	}
	public class C2DFieldElementImpl : CObjectImpl, C2DFieldElement {
	
		public C2DFieldElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(C2DFieldElement.Constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		#region client code
		// PROTECTED REGION ID(C2DFieldElement.ClientCode) ENABLED START
	
		// PROTECTED REGION END
		#endregion				
	
		#region derived features and operations
		
		public  Direction Neighbor(C2DFieldElement other) {
			// PROTECTED REGION ID(C2DFieldElement.Neighbor_C2DFieldElement) ENABLED START
			if (other.X == X && other.Y == Y + 1) {
				return Direction.top;
			} else if (other.X == X && other.Y == Y - 1) {
				return Direction.bottom;
			} else if (other.X == X + 1 && other.Y == Y) {
				return Direction.right;
			} else if (other.X == X - 1 && other.Y == Y) {
				return Direction.left;
			} else {
				return Direction.none;
			}
			// PROTECTED REGION END
		}
		#endregion
		
		private int _x;
		public  int X {
			get {
				return _x;
			}
			set {
				int oldValue = _x;
				_x = value;
				if (CNotificationRequired(CCoreMeta.cINSTANCE.Package.C2DFieldElement_X)) {
					CNotify(new CAction(this, CActionType.SET, CCoreMeta.cINSTANCE.Package.C2DFieldElement_X, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetX(int value, object data) {
			int oldValue = _x;
			_x = value;
			if (CNotificationRequired(CCoreMeta.cINSTANCE.Package.C2DFieldElement_X)) {
				CNotify(new CAction(this, CActionType.SET, CCoreMeta.cINSTANCE.Package.C2DFieldElement_X, oldValue, value, -1, data));
			}
		}
		
		private int _y;
		public  int Y {
			get {
				return _y;
			}
			set {
				int oldValue = _y;
				_y = value;
				if (CNotificationRequired(CCoreMeta.cINSTANCE.Package.C2DFieldElement_Y)) {
					CNotify(new CAction(this, CActionType.SET, CCoreMeta.cINSTANCE.Package.C2DFieldElement_Y, oldValue, value, -1, null));
				}	
			}
		}
		public  void SetY(int value, object data) {
			int oldValue = _y;
			_y = value;
			if (CNotificationRequired(CCoreMeta.cINSTANCE.Package.C2DFieldElement_Y)) {
				CNotify(new CAction(this, CActionType.SET, CCoreMeta.cINSTANCE.Package.C2DFieldElement_Y, oldValue, value, -1, data));
			}
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				case "x" : 
					X = (int)value;
					break;															
				case "y" : 
					Y = (int)value;
					break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				case "x" : 
					return X;
				case "y" : 
					return Y;
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override void CRemoveContent(CObject value) {
			switch(value.CContainingFeature.Name) {
				default:
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ccore
