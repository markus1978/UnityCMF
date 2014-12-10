using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Move : CObject {
		CList<UnityCMF.CCore.CAction> Actions { get;  }
		Tile Tile { get; set; }
		
	}
	
	public class MoveImpl : CObjectImpl, Move {
		// PROTECTED REGION ID(Move.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public MoveImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Move.constructor) ENABLED START
	
			// PROTECTED REGION END
		}

		
		private CList<UnityCMF.CCore.CAction> _Actions;
		public CList<UnityCMF.CCore.CAction> Actions {
			get {
				if (_Actions == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Move_actions;
					_Actions = new CList<UnityCMF.CCore.CAction>(this, feature);
				}
				return _Actions;
			}
		}
		private Tile _Tile;
		public Tile Tile {
			get { return _Tile; }
			set {
				Tile oldValue = _Tile;
				_Tile = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Move_tile)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Move_tile, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "tile" : 
				Tile = (Tile)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "actions" : 
				return Actions;															
			case "tile" : 
				return Tile;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.kmm
