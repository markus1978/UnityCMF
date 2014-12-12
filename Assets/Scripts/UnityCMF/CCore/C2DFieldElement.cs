using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.CCore {
	public interface C2DFieldElement : CObject {
		int X { get; set; }
		int Y { get; set; }
		
		Direction Neighbor(C2DFieldElement other);
	}
	public class C2DFieldElementImpl : CObjectImpl, C2DFieldElement {
		// PROTECTED REGION ID(C2DFieldElement.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public C2DFieldElementImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(C2DFieldElement.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		public virtual Direction Neighbor(C2DFieldElement other) {
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
		
		private int _x;
		public int X {
			get { return _x; }
			set {
				int oldValue = _x;
				_x = value;
				
				if (CNotificationRequired(CCoreMeta.cINSTANCE.Package.C2DFieldElement_X)) {
					CNotify(new CAction(this, CActionType.SET, CCoreMeta.cINSTANCE.Package.C2DFieldElement_X, oldValue, value, -1));
				}	
			}
		}
		private int _y;
		public int Y {
			get { return _y; }
			set {
				int oldValue = _y;
				_y = value;
				
				if (CNotificationRequired(CCoreMeta.cINSTANCE.Package.C2DFieldElement_Y)) {
					CNotify(new CAction(this, CActionType.SET, CCoreMeta.cINSTANCE.Package.C2DFieldElement_Y, oldValue, value, -1));
				}	
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
	}

} // UnityCMF.ccore
