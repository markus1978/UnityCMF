using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Board : CObject {
		C2DField<Tile> Tiles { get;  }
		Tile CurrentTile { get; set; }
		
		bool move(Tile tile);
	}
	
	public class BoardImpl : CObjectImpl, Board {
		public BoardImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private C2DField<Tile> _Tiles;
		public C2DField<Tile> Tiles {
			get {
				if (_Tiles == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Board_tiles;
					_Tiles = new C2DField<Tile>(9,11, this, feature);
				}
				return _Tiles;
			}
		}
		private Tile _CurrentTile;
		public Tile CurrentTile {
			get { return _CurrentTile; }
			set {
				Tile oldValue = _CurrentTile;
				_CurrentTile = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Board_currentTile)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Board_currentTile, oldValue, value, -1));
				}	
			}
		}
		
		public virtual bool move(Tile tile) {
			// PROTECTED REGION ID(Board.move_Tile) ENABLED START
			Debug.LogError("Unsupported Operation Board.move(Tile)");
			return default(bool);
			// PROTECTED REGION END
		}
	}
} // UnityCMF.kmm
