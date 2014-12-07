using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Game : CObject {
		Stats Stats { get; set; }
		CList<Entity> Entities { get;  }
		CList<Move> CurrentPath { get;  }
		C2DField<Tile> Tiles { get;  }
		Tile CurrentTile { get; set; }
		CList<Move> OldPath { get;  }
		
		bool move(Tile tile);
	}
	
	public class GameImpl : CObjectImpl, Game {
		// PROTECTED REGION ID(Game.custom) ENABLED START
		private CContentHandler _globalNotificationHandler;

		private void HandleGlobalNotifications(CAction action) {
			CurrentPath[CurrentPath.Count - 1].Actions.Add(action);
		}
		// PROTECTED REGION END
		
		public GameImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Game.constructor) ENABLED START
			_globalNotificationHandler = new CContentHandler();
			_globalNotificationHandler.AddToSource(this);
			_globalNotificationHandler.CNotification += HandleGlobalNotifications;
			// PROTECTED REGION END
		}

		public virtual bool move(Tile tile) {
			// PROTECTED REGION ID(Game.move_Tile) ENABLED START
			Debug.LogError("Unsupported Operation Game.move(Tile)");
			return default(bool);
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
			get { return _CurrentTile; }
			set {
				Tile oldValue = _CurrentTile;
				_CurrentTile = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_currentTile)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_currentTile, oldValue, value, -1));
				}	
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
	}
} // UnityCMF.kmm
