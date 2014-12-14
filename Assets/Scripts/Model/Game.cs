using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Game : CObject {
		Stats Stats { get; set; }
		CList<Entity> Entities { get; }
		CList<Move> CurrentPath { get; }
		C2DField<Tile> Tiles { get; }
		Tile CurrentTile { get;  }
		CList<Move> OldPath { get; }
		Pool RegularPool { get; set; }
		Pool DatePool { get; set; }
		
		bool Move(Tile tile);
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
			_tiles = new C2DField<Tile>(9,11, this, KmmMeta.cINSTANCE.Package.Game_Tiles, true);			
			// PROTECTED REGION ID(Game.constructor) ENABLED START
			_globalNotificationHandler = new CContentHandler();
			_globalNotificationHandler.AddToSource(this);
			_globalNotificationHandler.CNotification += HandleGlobalNotifications;
			// PROTECTED REGION END
		}
		public virtual bool Move(Tile tile) {
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
							entity.Apply();
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
		
		private Stats _stats;
		public Stats Stats {
			get { return _stats; }
			set {
				Stats oldValue = _stats;
				_stats = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_Stats)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_Stats, oldValue, value, -1));
				}	
			}
		}
		private CList<Entity> _entities;
		public CList<Entity> Entities {
			get {
				if (_entities == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_Entities;
					_entities = new CList<Entity>(this, feature);
				}
				return _entities;
			}
		}
		private CList<Move> _currentPath;
		public CList<Move> CurrentPath {
			get {
				if (_currentPath == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_CurrentPath;
					_currentPath = new CList<Move>(this, feature);
				}
				return _currentPath;
			}
		}
		private C2DField<Tile> _tiles;
		public C2DField<Tile> Tiles {
			get {
				if (_tiles == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_Tiles;
					_tiles = new C2DField<Tile>(9,11, this, feature);
				}
				return _tiles;
			}
		}
		public Tile CurrentTile {
			get {
				// PROTECTED REGION ID(Game.CurrentTile) ENABLED START
				return default(Tile);
				// PROTECTED REGION END
			}
		}
		private CList<Move> _oldPath;
		public CList<Move> OldPath {
			get {
				if (_oldPath == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Game_OldPath;
					_oldPath = new CList<Move>(this, feature);
				}
				return _oldPath;
			}
		}
		private Pool _regularPool;
		public Pool RegularPool {
			get { return _regularPool; }
			set {
				Pool oldValue = _regularPool;
				_regularPool = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_RegularPool)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_RegularPool, oldValue, value, -1));
				}	
			}
		}
		private Pool _datePool;
		public Pool DatePool {
			get { return _datePool; }
			set {
				Pool oldValue = _datePool;
				_datePool = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_DatePool)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_DatePool, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "stats" : 
				Stats = (Stats)value;
				break;															
			case "regularPool" : 
				RegularPool = (Pool)value;
				break;															
			case "datePool" : 
				DatePool = (Pool)value;
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
			case "regularPool" : 
				return RegularPool;															
			case "datePool" : 
				return DatePool;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
