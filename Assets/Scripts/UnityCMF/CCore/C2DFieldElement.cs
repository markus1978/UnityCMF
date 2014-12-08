using UnityEngine;
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
			Debug.LogError("Unsupported Operation C2DFieldElement.Neighbor(C2DFieldElement)");
			return default(Direction);
			// PROTECTED REGION END
		}
		
		private int _X;
		public int X {
			get { return _X; }
			set {
				int oldValue = _X;
				_X = value;
				
				if (CNotificationRequired(CcoreMeta.cINSTANCE.Package.C2DFieldElement_x)) {
					CNotify(new CAction(this, CActionType.SET, CcoreMeta.cINSTANCE.Package.C2DFieldElement_x, oldValue, value, -1));
				}	
			}
		}
		private int _Y;
		public int Y {
			get { return _Y; }
			set {
				int oldValue = _Y;
				_Y = value;
				
				if (CNotificationRequired(CcoreMeta.cINSTANCE.Package.C2DFieldElement_y)) {
					CNotify(new CAction(this, CActionType.SET, CcoreMeta.cINSTANCE.Package.C2DFieldElement_y, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.ccore
