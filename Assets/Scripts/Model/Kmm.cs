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
		EReference Tile_Entity { get; }
		EAttribute Tile_OnCurrentPath { get; }
		EAttribute Tile_OnOldPath { get; }
		EReference Tile_Extra { get; }
		EReference Tile_StatsChanges { get; }
		EClass Stats { get; }
		EReference Stats_Items { get; }
		EReference Stats_Quests { get; }
		EClass Game { get; }
		EReference Game_Stats { get; }
		EReference Game_Entities { get; }
		EReference Game_CurrentPath { get; }
		EReference Game_Tiles { get; }
		EReference Game_CurrentTile { get; }
		EReference Game_OldPath { get; }
		EReference Game_RegularPool { get; }
		EReference Game_DatePool { get; }
		EClass Entity { get; }
		EReference Entity_ExtraPool { get; }
		EClass Item { get; }
		EClass Door { get; }
		EClass Move { get; }
		EAttribute Move_Actions { get; }
		EReference Move_Tile { get; }
		EClass Pool { get; }
		EReference Pool_Poolables { get; }
		EClass QuestSlot { get; }
		EReference QuestSlot_Goal { get; }
		EAttribute QuestSlot_IsAvailable { get; }
		EAttribute QuestSlot_IsCompleted { get; }
		EClass ItemSlot { get; }
		EAttribute ItemSlot_TurnsLeft { get; }
		EReference ItemSlot_Item { get; }
		EClass QuestGoal { get; }
		EClass Poolable { get; }
		EAttribute Poolable_IsUnique { get; }
		EClass StatsChanges { get; }
		EAttribute StatsChanges_KathisLove { get; }
		EAttribute StatsChanges_MarkusLove { get; }
		EAttribute StatsChanges_Money { get; }
		EAttribute StatsChanges_Experience { get; }
		EAttribute StatsChanges_Level { get; }
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
			Pool = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Pool.Name = "Pool";
			Pool.CPackage = this;
			QuestSlot = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			QuestSlot.Name = "QuestSlot";
			QuestSlot.CPackage = this;
			ItemSlot = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			ItemSlot.Name = "ItemSlot";
			ItemSlot.CPackage = this;
			QuestGoal = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			QuestGoal.Name = "QuestGoal";
			QuestGoal.CPackage = this;
			Poolable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Poolable.Name = "Poolable";
			Poolable.CPackage = this;
			StatsChanges = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			StatsChanges.Name = "StatsChanges";
			StatsChanges.CPackage = this;
			Tile_Entity = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Tile_Entity.Name = "entity";
			Tile_Entity.LowerBound = 0;
			Tile_Entity.UpperBound = 1;
			Tile_Entity.EType = this.Entity;
			Tile_Entity.Containment = false;
			Tile.EStructuralFeatures.Add(Tile_Entity);
			Tile_OnCurrentPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			Tile_OnCurrentPath.Name = "onCurrentPath";
			Tile_OnCurrentPath.LowerBound = 0;
			Tile_OnCurrentPath.UpperBound = 1;
			Tile_OnCurrentPath.EType = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package.Direction;
			Tile.EStructuralFeatures.Add(Tile_OnCurrentPath);
			Tile_OnOldPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			Tile_OnOldPath.Name = "onOldPath";
			Tile_OnOldPath.LowerBound = 0;
			Tile_OnOldPath.UpperBound = 1;
			Tile_OnOldPath.EType = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package.Direction;
			Tile.EStructuralFeatures.Add(Tile_OnOldPath);
			Tile_Extra = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Tile_Extra.Name = "extra";
			Tile_Extra.LowerBound = 0;
			Tile_Extra.UpperBound = 1;
			Tile_Extra.EType = this.Entity;
			Tile_Extra.Containment = false;
			Tile.EStructuralFeatures.Add(Tile_Extra);
			Tile_StatsChanges = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Tile_StatsChanges.Name = "statsChanges";
			Tile_StatsChanges.LowerBound = 0;
			Tile_StatsChanges.UpperBound = 1;
			Tile_StatsChanges.EType = this.StatsChanges;
			Tile_StatsChanges.Containment = true;
			Tile.EStructuralFeatures.Add(Tile_StatsChanges);
			Stats_Items = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Stats_Items.Name = "items";
			Stats_Items.LowerBound = 0;
			Stats_Items.UpperBound = 3;
			Stats_Items.EType = this.ItemSlot;
			Stats_Items.Containment = true;
			Stats.EStructuralFeatures.Add(Stats_Items);
			Stats_Quests = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Stats_Quests.Name = "quests";
			Stats_Quests.LowerBound = 0;
			Stats_Quests.UpperBound = -1;
			Stats_Quests.EType = this.QuestSlot;
			Stats_Quests.Containment = true;
			Stats.EStructuralFeatures.Add(Stats_Quests);
			Game_Stats = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_Stats.Name = "stats";
			Game_Stats.LowerBound = 1;
			Game_Stats.UpperBound = 1;
			Game_Stats.EType = this.Stats;
			Game_Stats.Containment = true;
			Game.EStructuralFeatures.Add(Game_Stats);
			Game_Entities = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_Entities.Name = "entities";
			Game_Entities.LowerBound = 0;
			Game_Entities.UpperBound = -1;
			Game_Entities.EType = this.Entity;
			Game_Entities.Containment = true;
			Game.EStructuralFeatures.Add(Game_Entities);
			Game_CurrentPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_CurrentPath.Name = "currentPath";
			Game_CurrentPath.LowerBound = 0;
			Game_CurrentPath.UpperBound = -1;
			Game_CurrentPath.EType = this.Move;
			Game_CurrentPath.Containment = true;
			Game.EStructuralFeatures.Add(Game_CurrentPath);
			Game_Tiles = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_Tiles.Name = "tiles";
			Game_Tiles.LowerBound = 0;
			Game_Tiles.UpperBound = -1;
			Game_Tiles.EType = this.Tile;
			Game_Tiles.Containment = true;
			Game.EStructuralFeatures.Add(Game_Tiles);
			Game_CurrentTile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_CurrentTile.Name = "currentTile";
			Game_CurrentTile.LowerBound = 0;
			Game_CurrentTile.UpperBound = 1;
			Game_CurrentTile.EType = this.Tile;
			Game_CurrentTile.Containment = false;
			Game.EStructuralFeatures.Add(Game_CurrentTile);
			Game_OldPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_OldPath.Name = "oldPath";
			Game_OldPath.LowerBound = 0;
			Game_OldPath.UpperBound = -1;
			Game_OldPath.EType = this.Move;
			Game_OldPath.Containment = true;
			Game.EStructuralFeatures.Add(Game_OldPath);
			Game_RegularPool = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_RegularPool.Name = "regularPool";
			Game_RegularPool.LowerBound = 0;
			Game_RegularPool.UpperBound = 1;
			Game_RegularPool.EType = this.Pool;
			Game_RegularPool.Containment = true;
			Game.EStructuralFeatures.Add(Game_RegularPool);
			Game_DatePool = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Game_DatePool.Name = "datePool";
			Game_DatePool.LowerBound = 0;
			Game_DatePool.UpperBound = 1;
			Game_DatePool.EType = this.Pool;
			Game_DatePool.Containment = true;
			Game.EStructuralFeatures.Add(Game_DatePool);
			Entity_ExtraPool = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Entity_ExtraPool.Name = "extraPool";
			Entity_ExtraPool.LowerBound = 0;
			Entity_ExtraPool.UpperBound = 1;
			Entity_ExtraPool.EType = this.Pool;
			Entity_ExtraPool.Containment = false;
			Entity.EStructuralFeatures.Add(Entity_ExtraPool);
			Move_Actions = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			Move_Actions.Name = "actions";
			Move_Actions.LowerBound = 0;
			Move_Actions.UpperBound = -1;
			Move_Actions.EType = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package.CAction;
			Move.EStructuralFeatures.Add(Move_Actions);
			Move_Tile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Move_Tile.Name = "tile";
			Move_Tile.LowerBound = 0;
			Move_Tile.UpperBound = 1;
			Move_Tile.EType = this.Tile;
			Move_Tile.Containment = false;
			Move.EStructuralFeatures.Add(Move_Tile);
			Pool_Poolables = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Pool_Poolables.Name = "poolables";
			Pool_Poolables.LowerBound = 0;
			Pool_Poolables.UpperBound = -1;
			Pool_Poolables.EType = this.Poolable;
			Pool_Poolables.Containment = false;
			Pool.EStructuralFeatures.Add(Pool_Poolables);
			QuestSlot_Goal = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			QuestSlot_Goal.Name = "goal";
			QuestSlot_Goal.LowerBound = 0;
			QuestSlot_Goal.UpperBound = 1;
			QuestSlot_Goal.EType = this.QuestGoal;
			QuestSlot_Goal.Containment = false;
			QuestSlot.EStructuralFeatures.Add(QuestSlot_Goal);
			QuestSlot_IsAvailable = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			QuestSlot_IsAvailable.Name = "isAvailable";
			QuestSlot_IsAvailable.LowerBound = 0;
			QuestSlot_IsAvailable.UpperBound = 1;
			QuestSlot_IsAvailable.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EBoolean;
			QuestSlot.EStructuralFeatures.Add(QuestSlot_IsAvailable);
			QuestSlot_IsCompleted = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			QuestSlot_IsCompleted.Name = "isCompleted";
			QuestSlot_IsCompleted.LowerBound = 0;
			QuestSlot_IsCompleted.UpperBound = 1;
			QuestSlot_IsCompleted.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EBoolean;
			QuestSlot.EStructuralFeatures.Add(QuestSlot_IsCompleted);
			ItemSlot_TurnsLeft = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			ItemSlot_TurnsLeft.Name = "turnsLeft";
			ItemSlot_TurnsLeft.LowerBound = 0;
			ItemSlot_TurnsLeft.UpperBound = 1;
			ItemSlot_TurnsLeft.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			ItemSlot.EStructuralFeatures.Add(ItemSlot_TurnsLeft);
			ItemSlot_Item = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			ItemSlot_Item.Name = "item";
			ItemSlot_Item.LowerBound = 0;
			ItemSlot_Item.UpperBound = 1;
			ItemSlot_Item.EType = this.Item;
			ItemSlot_Item.Containment = false;
			ItemSlot.EStructuralFeatures.Add(ItemSlot_Item);
			Poolable_IsUnique = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			Poolable_IsUnique.Name = "isUnique";
			Poolable_IsUnique.LowerBound = 0;
			Poolable_IsUnique.UpperBound = 1;
			Poolable_IsUnique.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EBoolean;
			Poolable.EStructuralFeatures.Add(Poolable_IsUnique);
			StatsChanges_KathisLove = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			StatsChanges_KathisLove.Name = "kathisLove";
			StatsChanges_KathisLove.LowerBound = 0;
			StatsChanges_KathisLove.UpperBound = 1;
			StatsChanges_KathisLove.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			StatsChanges.EStructuralFeatures.Add(StatsChanges_KathisLove);
			StatsChanges_MarkusLove = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			StatsChanges_MarkusLove.Name = "markusLove";
			StatsChanges_MarkusLove.LowerBound = 0;
			StatsChanges_MarkusLove.UpperBound = 1;
			StatsChanges_MarkusLove.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			StatsChanges.EStructuralFeatures.Add(StatsChanges_MarkusLove);
			StatsChanges_Money = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			StatsChanges_Money.Name = "money";
			StatsChanges_Money.LowerBound = 0;
			StatsChanges_Money.UpperBound = 1;
			StatsChanges_Money.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			StatsChanges.EStructuralFeatures.Add(StatsChanges_Money);
			StatsChanges_Experience = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			StatsChanges_Experience.Name = "experience";
			StatsChanges_Experience.LowerBound = 0;
			StatsChanges_Experience.UpperBound = 1;
			StatsChanges_Experience.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			StatsChanges.EStructuralFeatures.Add(StatsChanges_Experience);
			StatsChanges_Level = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			StatsChanges_Level.Name = "level";
			StatsChanges_Level.LowerBound = 0;
			StatsChanges_Level.UpperBound = 1;
			StatsChanges_Level.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EInt;
			StatsChanges.EStructuralFeatures.Add(StatsChanges_Level);
		}
		
		public EClass Tile { get; private set;}
		public EReference Tile_Entity  { get; private set;}
		public EAttribute Tile_OnCurrentPath  { get; private set;}
		public EAttribute Tile_OnOldPath  { get; private set;}
		public EReference Tile_Extra  { get; private set;}
		public EReference Tile_StatsChanges  { get; private set;}
		public EClass Stats { get; private set;}
		public EReference Stats_Items  { get; private set;}
		public EReference Stats_Quests  { get; private set;}
		public EClass Game { get; private set;}
		public EReference Game_Stats  { get; private set;}
		public EReference Game_Entities  { get; private set;}
		public EReference Game_CurrentPath  { get; private set;}
		public EReference Game_Tiles  { get; private set;}
		public EReference Game_CurrentTile  { get; private set;}
		public EReference Game_OldPath  { get; private set;}
		public EReference Game_RegularPool  { get; private set;}
		public EReference Game_DatePool  { get; private set;}
		public EClass Entity { get; private set;}
		public EReference Entity_ExtraPool  { get; private set;}
		public EClass Item { get; private set;}
		public EClass Door { get; private set;}
		public EClass Move { get; private set;}
		public EAttribute Move_Actions  { get; private set;}
		public EReference Move_Tile  { get; private set;}
		public EClass Pool { get; private set;}
		public EReference Pool_Poolables  { get; private set;}
		public EClass QuestSlot { get; private set;}
		public EReference QuestSlot_Goal  { get; private set;}
		public EAttribute QuestSlot_IsAvailable  { get; private set;}
		public EAttribute QuestSlot_IsCompleted  { get; private set;}
		public EClass ItemSlot { get; private set;}
		public EAttribute ItemSlot_TurnsLeft  { get; private set;}
		public EReference ItemSlot_Item  { get; private set;}
		public EClass QuestGoal { get; private set;}
		public EClass Poolable { get; private set;}
		public EAttribute Poolable_IsUnique  { get; private set;}
		public EClass StatsChanges { get; private set;}
		public EAttribute StatsChanges_KathisLove  { get; private set;}
		public EAttribute StatsChanges_MarkusLove  { get; private set;}
		public EAttribute StatsChanges_Money  { get; private set;}
		public EAttribute StatsChanges_Experience  { get; private set;}
		public EAttribute StatsChanges_Level  { get; private set;}
		
		public EClassifier getClassifier(string name) {
			switch(name) {
				case "Tile": return KmmMeta.cINSTANCE.Package.Tile;
				case "Stats": return KmmMeta.cINSTANCE.Package.Stats;
				case "Game": return KmmMeta.cINSTANCE.Package.Game;
				case "Entity": return KmmMeta.cINSTANCE.Package.Entity;
				case "Item": return KmmMeta.cINSTANCE.Package.Item;
				case "Door": return KmmMeta.cINSTANCE.Package.Door;
				case "Move": return KmmMeta.cINSTANCE.Package.Move;
				case "Pool": return KmmMeta.cINSTANCE.Package.Pool;
				case "QuestSlot": return KmmMeta.cINSTANCE.Package.QuestSlot;
				case "ItemSlot": return KmmMeta.cINSTANCE.Package.ItemSlot;
				case "QuestGoal": return KmmMeta.cINSTANCE.Package.QuestGoal;
				case "Poolable": return KmmMeta.cINSTANCE.Package.Poolable;
				case "StatsChanges": return KmmMeta.cINSTANCE.Package.StatsChanges;
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
		Pool CreatePool();
		QuestSlot CreateQuestSlot();
		ItemSlot CreateItemSlot();
		QuestGoal CreateQuestGoal();
		Poolable CreatePoolable();
		StatsChanges CreateStatsChanges();
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
		public Pool CreatePool() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Pool;
			return new PoolImpl(eClass);
		}
		public QuestSlot CreateQuestSlot() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.QuestSlot;
			return new QuestSlotImpl(eClass);
		}
		public ItemSlot CreateItemSlot() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.ItemSlot;
			return new ItemSlotImpl(eClass);
		}
		public QuestGoal CreateQuestGoal() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.QuestGoal;
			return new QuestGoalImpl(eClass);
		}
		public Poolable CreatePoolable() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Poolable;
			return new PoolableImpl(eClass);
		}
		public StatsChanges CreateStatsChanges() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.StatsChanges;
			return new StatsChangesImpl(eClass);
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
				case "Pool": return new PoolImpl(eClass);
				case "QuestSlot": return new QuestSlotImpl(eClass);
				case "ItemSlot": return new ItemSlotImpl(eClass);
				case "QuestGoal": return new QuestGoalImpl(eClass);
				case "Poolable": return new PoolableImpl(eClass);
				case "StatsChanges": return new StatsChangesImpl(eClass);
				default: return null;	
			}	
		}
	}
	
} // UnityCMF.Kmm
