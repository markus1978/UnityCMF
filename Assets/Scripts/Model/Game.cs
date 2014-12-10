using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Game : CObject {
		Stats Stats { get; set; }
		CList<Entity> Entities { get;  }
		CList<Move> CurrentPath { get;  }
		C2DField<Tile> Tiles { get;  }
		Tile CurrentTile { get;  }
		CList<Move> OldPath { get;  }
		
		bool move(Tile tile);
	}
	
	public class GameImpl : CObjectImpl, Game {
		// PROTECTED REGION ID(Game.custom) ENABLED START
		private CContentHandler _globalNotificationHandler;
		private bool _isMoving = false;

		private void HandleGlobalNotifications(CAction action) {
			if (_isMoving) {
				CurrentPath[CurrentPath.Count - 1].Actions.Add (action);
			}
		}
		// PROTECTED REGION END
		
		public GameImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			_Tiles = new C2DField<Tile>(9,11, this, feature, true);			
			// PROTECTED REGION ID(Game.constructor) ENABLED START
			_globalNotificationHandler = new CContentHandler();
			_globalNotificationHandler.AddToSource(this);
			_globalNotificationHandler.CNotification += HandleGlobalNotifications;
			// PROTECTED REGION END
		}

		public virtual bool move(Tile tile) {
			// PROTECTED REGION ID(Game.move_Tile) ENABLED START
			if (tile.OnCurrentPath != Direction.none) {
				Direction pathDirection = CurrentTile.OnCurrentPath;
				while(CurrentPath != tile) {
					Tile currentTile = CurrentTile;
					foreach(CAction action in CurrentPath.Last.Actions) {
						action.Reverse();
					}
					currentTile.OnOldPath = pathDirection;
				}
				return true;
			} else if (tile.OnOldPath != Direction.none) {
				return false; // TODO
			} else {
				Direction neighbor = tile.Neighbor(CurrentTile);
				if (neighbor != Direction.none) {
					_isMoving = true;
					try {
						Move move = KmmMeta.cINSTANCE.Factory.CreateMove();
						move.Tile = tile;
						CurrentPath.Add(move);

						tile.OnCurrentPath = neighbor;
						Entity entity = tile.Entity;
						if (entity != null) {
							entity.apply();
						} 
					} finally {
						_isMoving = false;
					}
					return true;
				} else {
					return false;
				}
			}

			// PROTECTED REGION END
		}
		
		private Stats _Stats;
		public Stats Stats {
			get { return _Stats; }
			set {
				Stats oldValue = _Stats;
				_Stats = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_stats)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_stats, oldValue, value, -1));
				}	
			}
		}
		private CList<Entity> _Entities;
		public CList<Entity> Entities {
			get {
				if (_Entities == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_entities;
					_Entities = new CList<Entity>(this, feature);
				}
				return _Entities;
			}
		}
		private CList<Move> _CurrentPath;
		public CList<Move> CurrentPath {
			get {
				if (_CurrentPath == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_currentPath;
					_CurrentPath = new CList<Move>(this, feature);
				}
				return _CurrentPath;
			}
		}
		private C2DField<Tile> _Tiles;
		public C2DField<Tile> Tiles {
			get {
				if (_Tiles == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_tiles;
					_Tiles = new C2DField<Tile>(9,11, this, feature);
				}
				return _Tiles;
			}
		}
		private Tile _CurrentTile;
		public Tile CurrentTile {
			get {
				// PROTECTED REGION ID(Game.currentTile) ENABLED START
				Move lastMove = CurrentPath.Last;
				if (lastMove != null) {
					return lastMove.Tile;
				} else {
					return null;
				}
				// PROTECTED REGION END
			}
		}
		private CList<Move> _OldPath;
		public CList<Move> OldPath {
			get {
				if (_OldPath == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_oldPath;
					_OldPath = new CList<Move>(this, feature);
				}
				return _OldPath;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "stats" : 
				Stats = (Stats)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "stats" : 
				return Stats;															
			case "entities" : 
				return Entities;															
			case "currentPath" : 
				return CurrentPath;															
			case "tiles" : 
				return Tiles;															
			case "currentTile" : 
				return CurrentTile;															
			case "oldPath" : 
				return OldPath;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}
} // UnityCMF.kmm
