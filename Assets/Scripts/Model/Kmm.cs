using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	
	public sealed class KmmMeta {
		public static KmmMeta cINSTANCE = new KmmMeta();
		private KmmPackageImpl _package = new KmmPackageImpl();
		private KmmFactoryImpl _factory = new KmmFactoryImpl();
		public KmmPackage Package { 
			get {
				_package.init();
				return _package;
			}
		}
		public KmmFactory Factory { 
			get {
				return _factory;
			} 
		}
	}
	public interface KmmPackage : CPackage {
		EClass Tile { get; }
		EStructuralFeature Tile_Entity { get; }
		EStructuralFeature Tile_OnCurrentPath { get; }
		EStructuralFeature Tile_OnOldPath { get; }
		EClass Stats { get; }
		EStructuralFeature Stats_KathisLove { get; }
		EStructuralFeature Stats_MarkusLove { get; }
		EStructuralFeature Stats_Money { get; }
		EStructuralFeature Stats_Level { get; }
		EStructuralFeature Stats_Experience { get; }
		EClass Game { get; }
		EStructuralFeature Game_Stats { get; }
		EStructuralFeature Game_Entities { get; }
		EStructuralFeature Game_CurrentPath { get; }
		EStructuralFeature Game_Tiles { get; }
		EStructuralFeature Game_CurrentTile { get; }
		EStructuralFeature Game_OldPath { get; }
		EClass Entity { get; }
		EClass Item { get; }
		EClass Door { get; }
		EClass Move { get; }
		EStructuralFeature Move_Actions { get; }
		EStructuralFeature Move_Tile { get; }
	}
	public class KmmPackageImpl : KmmPackage {
		public CFactory FactoryInstance {
			get {
				return KmmMeta.cINSTANCE.Factory;
			}	
		}
		
		private bool _isInited = false;
		
		public void init() {
			if (_isInited) return;
			_isInited = true;				
			Tile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Tile.Name = "Tile";
			Tile.CPackage = this;
			Stats = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Stats.Name = "Stats";
			Stats.CPackage = this;
			Game = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Game.Name = "Game";
			Game.CPackage = this;
			Entity = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Entity.Name = "Entity";
			Entity.CPackage = this;
			Item = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Item.Name = "Item";
			Item.CPackage = this;
			Door = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Door.Name = "Door";
			Door.CPackage = this;
			Move = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Move.Name = "Move";
			Move.CPackage = this;
			Tile_Entity = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Tile_Entity.Name = "entity";
			Tile_Entity.LowerBound = 0;
			Tile_Entity.UpperBound = 1;
			Tile_Entity.EType = this.Entity;
			Tile.EStructuralFeatures.Add(Tile_Entity);
			Tile_OnCurrentPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Tile_OnCurrentPath.Name = "onCurrentPath";
			Tile_OnCurrentPath.LowerBound = 0;
			Tile_OnCurrentPath.UpperBound = 1;
			Tile_OnCurrentPath.EType = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package.Direction;
			Tile.EStructuralFeatures.Add(Tile_OnCurrentPath);
			Tile_OnOldPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Tile_OnOldPath.Name = "onOldPath";
			Tile_OnOldPath.LowerBound = 0;
			Tile_OnOldPath.UpperBound = 1;
			Tile_OnOldPath.EType = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package.Direction;
			Tile.EStructuralFeatures.Add(Tile_OnOldPath);
			Stats_KathisLove = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_KathisLove.Name = "kathisLove";
			Stats_KathisLove.LowerBound = 0;
			Stats_KathisLove.UpperBound = 1;
			Stats_KathisLove.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_KathisLove);
			Stats_MarkusLove = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_MarkusLove.Name = "markusLove";
			Stats_MarkusLove.LowerBound = 0;
			Stats_MarkusLove.UpperBound = 1;
			Stats_MarkusLove.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_MarkusLove);
			Stats_Money = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_Money.Name = "money";
			Stats_Money.LowerBound = 0;
			Stats_Money.UpperBound = 1;
			Stats_Money.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_Money);
			Stats_Level = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_Level.Name = "level";
			Stats_Level.LowerBound = 0;
			Stats_Level.UpperBound = 1;
			Stats_Level.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_Level);
			Stats_Experience = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_Experience.Name = "experience";
			Stats_Experience.LowerBound = 0;
			Stats_Experience.UpperBound = 1;
			Stats_Experience.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_Experience);
			Game_Stats = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_Stats.Name = "stats";
			Game_Stats.LowerBound = 1;
			Game_Stats.UpperBound = 1;
			Game_Stats.EType = this.Stats;
			Game.EStructuralFeatures.Add(Game_Stats);
			Game_Entities = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_Entities.Name = "entities";
			Game_Entities.LowerBound = 0;
			Game_Entities.UpperBound = -1;
			Game_Entities.EType = this.Entity;
			Game.EStructuralFeatures.Add(Game_Entities);
			Game_CurrentPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_CurrentPath.Name = "currentPath";
			Game_CurrentPath.LowerBound = 0;
			Game_CurrentPath.UpperBound = -1;
			Game_CurrentPath.EType = this.Move;
			Game.EStructuralFeatures.Add(Game_CurrentPath);
			Game_Tiles = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_Tiles.Name = "tiles";
			Game_Tiles.LowerBound = 0;
			Game_Tiles.UpperBound = -1;
			Game_Tiles.EType = this.Tile;
			Game.EStructuralFeatures.Add(Game_Tiles);
			Game_CurrentTile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_CurrentTile.Name = "currentTile";
			Game_CurrentTile.LowerBound = 0;
			Game_CurrentTile.UpperBound = 1;
			Game_CurrentTile.EType = this.Tile;
			Game.EStructuralFeatures.Add(Game_CurrentTile);
			Game_OldPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_OldPath.Name = "oldPath";
			Game_OldPath.LowerBound = 0;
			Game_OldPath.UpperBound = -1;
			Game_OldPath.EType = this.Move;
			Game.EStructuralFeatures.Add(Game_OldPath);
			Move_Actions = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Move_Actions.Name = "actions";
			Move_Actions.LowerBound = 0;
			Move_Actions.UpperBound = -1;
			Move_Actions.EType = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package.CAction;
			Move.EStructuralFeatures.Add(Move_Actions);
			Move_Tile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Move_Tile.Name = "tile";
			Move_Tile.LowerBound = 0;
			Move_Tile.UpperBound = 1;
			Move_Tile.EType = this.Tile;
			Move.EStructuralFeatures.Add(Move_Tile);
		}
		
		public EClass Tile { get; private set;}
		public EStructuralFeature Tile_Entity  { get; private set;}
		public EStructuralFeature Tile_OnCurrentPath  { get; private set;}
		public EStructuralFeature Tile_OnOldPath  { get; private set;}
		public EClass Stats { get; private set;}
		public EStructuralFeature Stats_KathisLove  { get; private set;}
		public EStructuralFeature Stats_MarkusLove  { get; private set;}
		public EStructuralFeature Stats_Money  { get; private set;}
		public EStructuralFeature Stats_Level  { get; private set;}
		public EStructuralFeature Stats_Experience  { get; private set;}
		public EClass Game { get; private set;}
		public EStructuralFeature Game_Stats  { get; private set;}
		public EStructuralFeature Game_Entities  { get; private set;}
		public EStructuralFeature Game_CurrentPath  { get; private set;}
		public EStructuralFeature Game_Tiles  { get; private set;}
		public EStructuralFeature Game_CurrentTile  { get; private set;}
		public EStructuralFeature Game_OldPath  { get; private set;}
		public EClass Entity { get; private set;}
		public EClass Item { get; private set;}
		public EClass Door { get; private set;}
		public EClass Move { get; private set;}
		public EStructuralFeature Move_Actions  { get; private set;}
		public EStructuralFeature Move_Tile  { get; private set;}
		
		public EClassifier getClassifier(string name) {
			switch(name) {
				case "Tile": return KmmMeta.cINSTANCE.Package.Tile;
				case "Stats": return KmmMeta.cINSTANCE.Package.Stats;
				case "Game": return KmmMeta.cINSTANCE.Package.Game;
				case "Entity": return KmmMeta.cINSTANCE.Package.Entity;
				case "Item": return KmmMeta.cINSTANCE.Package.Item;
				case "Door": return KmmMeta.cINSTANCE.Package.Door;
				case "Move": return KmmMeta.cINSTANCE.Package.Move;
				default: return null;	
			}	
		}
	}
	public interface KmmFactory : CFactory {
		Tile CreateTile();
		Stats CreateStats();
		Game CreateGame();
		Entity CreateEntity();
		Item CreateItem();
		Door CreateDoor();
		Move CreateMove();
	}
	public class KmmFactoryImpl : KmmFactory {
		public CPackage PackageInstance {
			get {
				return KmmMeta.cINSTANCE.Package;
			}	
		}
		
		public Tile CreateTile() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Tile;
			return new TileImpl(eClass);
		}
		public Stats CreateStats() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Stats;
			return new StatsImpl(eClass);
		}
		public Game CreateGame() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Game;
			return new GameImpl(eClass);
		}
		public Entity CreateEntity() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Entity;
			return new EntityImpl(eClass);
		}
		public Item CreateItem() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Item;
			return new ItemImpl(eClass);
		}
		public Door CreateDoor() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Door;
			return new DoorImpl(eClass);
		}
		public Move CreateMove() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Move;
			return new MoveImpl(eClass);
		}
		
		public CObject create(EClass eClass) {
			switch(eClass.Name) {
				case "Tile": return new TileImpl(eClass);
				case "Stats": return new StatsImpl(eClass);
				case "Game": return new GameImpl(eClass);
				case "Entity": return new EntityImpl(eClass);
				case "Item": return new ItemImpl(eClass);
				case "Door": return new DoorImpl(eClass);
				case "Move": return new MoveImpl(eClass);
				default: return null;	
			}	
		}
	}
	
} // UnityCMF.Kmm
