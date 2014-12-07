using UnityCMF.ECore;

namespace UnityCMF.Kmm {
public enum Direction { none, left, top, right, bottom }
	 
	public sealed class KmmMeta {
		public static KmmMeta cINSTANCE = new KmmMeta();
		public KmmPackage Package { get; private set; }
		public KmmFactory Factory { get; private set; }
		public KmmMeta() {
			Package = new KmmPackageImpl();
			Factory = new KmmFactoryImpl();
		}
	}
	
	public interface KmmPackage {
		EClass Tile { get; }
		EStructuralFeature Tile_entity { get; }
		EStructuralFeature Tile_onCurrentPath { get; }
		EStructuralFeature Tile_onOldPath { get; }
		EClass Stats { get; }
		EStructuralFeature Stats_kathisLove { get; }
		EStructuralFeature Stats_markusLove { get; }
		EStructuralFeature Stats_money { get; }
		EStructuralFeature Stats_level { get; }
		EStructuralFeature Stats_experience { get; }
		EClass Game { get; }
		EStructuralFeature Game_stats { get; }
		EStructuralFeature Game_entities { get; }
		EStructuralFeature Game_currentPath { get; }
		EStructuralFeature Game_tiles { get; }
		EStructuralFeature Game_currentTile { get; }
		EStructuralFeature Game_oldPath { get; }
		EClass Entity { get; }
		EClass Item { get; }
		EClass Door { get; }
		EDataType CAction { get; }
		EClass Move { get; }
		EStructuralFeature Move_actions { get; }
		EStructuralFeature Move_tile { get; }
		EDataType Direction { get; }
	}
	
	public class KmmPackageImpl : KmmPackage {
		public KmmPackageImpl() {
			Tile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Tile.Name = "Tile";
			Tile_entity = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Tile_entity.Name = "entity";
			Tile_entity.LowerBound = 0;
			Tile_entity.UpperBound = 1;
			Tile_entity.EType = KmmMeta.cINSTANCE.Package.Entity;
			Tile.EStructuralFeatures.Add(Tile_entity);
			Tile_onCurrentPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Tile_onCurrentPath.Name = "onCurrentPath";
			Tile_onCurrentPath.LowerBound = 0;
			Tile_onCurrentPath.UpperBound = 1;
			Tile_onCurrentPath.EType = KmmMeta.cINSTANCE.Package.Direction;
			Tile.EStructuralFeatures.Add(Tile_onCurrentPath);
			Tile_onOldPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Tile_onOldPath.Name = "onOldPath";
			Tile_onOldPath.LowerBound = 0;
			Tile_onOldPath.UpperBound = 1;
			Tile_onOldPath.EType = KmmMeta.cINSTANCE.Package.Direction;
			Tile.EStructuralFeatures.Add(Tile_onOldPath);
					
			Stats = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Stats.Name = "Stats";
			Stats_kathisLove = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_kathisLove.Name = "kathisLove";
			Stats_kathisLove.LowerBound = 0;
			Stats_kathisLove.UpperBound = 1;
			Stats_kathisLove.EType = ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_kathisLove);
			Stats_markusLove = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_markusLove.Name = "markusLove";
			Stats_markusLove.LowerBound = 0;
			Stats_markusLove.UpperBound = 1;
			Stats_markusLove.EType = ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_markusLove);
			Stats_money = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_money.Name = "money";
			Stats_money.LowerBound = 0;
			Stats_money.UpperBound = 1;
			Stats_money.EType = ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_money);
			Stats_level = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_level.Name = "level";
			Stats_level.LowerBound = 0;
			Stats_level.UpperBound = 1;
			Stats_level.EType = ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_level);
			Stats_experience = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Stats_experience.Name = "experience";
			Stats_experience.LowerBound = 0;
			Stats_experience.UpperBound = 1;
			Stats_experience.EType = ECoreMeta.cINSTANCE.Package.EInt;
			Stats.EStructuralFeatures.Add(Stats_experience);
					
			Game = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Game.Name = "Game";
			Game_stats = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_stats.Name = "stats";
			Game_stats.LowerBound = 1;
			Game_stats.UpperBound = 1;
			Game_stats.EType = KmmMeta.cINSTANCE.Package.Stats;
			Game.EStructuralFeatures.Add(Game_stats);
			Game_entities = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_entities.Name = "entities";
			Game_entities.LowerBound = 0;
			Game_entities.UpperBound = -1;
			Game_entities.EType = KmmMeta.cINSTANCE.Package.Entity;
			Game.EStructuralFeatures.Add(Game_entities);
			Game_currentPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_currentPath.Name = "currentPath";
			Game_currentPath.LowerBound = 0;
			Game_currentPath.UpperBound = -1;
			Game_currentPath.EType = KmmMeta.cINSTANCE.Package.Move;
			Game.EStructuralFeatures.Add(Game_currentPath);
			Game_tiles = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_tiles.Name = "tiles";
			Game_tiles.LowerBound = 0;
			Game_tiles.UpperBound = -1;
			Game_tiles.EType = KmmMeta.cINSTANCE.Package.Tile;
			Game.EStructuralFeatures.Add(Game_tiles);
			Game_currentTile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_currentTile.Name = "currentTile";
			Game_currentTile.LowerBound = 0;
			Game_currentTile.UpperBound = 1;
			Game_currentTile.EType = KmmMeta.cINSTANCE.Package.Tile;
			Game.EStructuralFeatures.Add(Game_currentTile);
			Game_oldPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_oldPath.Name = "oldPath";
			Game_oldPath.LowerBound = 0;
			Game_oldPath.UpperBound = -1;
			Game_oldPath.EType = KmmMeta.cINSTANCE.Package.Move;
			Game.EStructuralFeatures.Add(Game_oldPath);
					
			Entity = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Entity.Name = "Entity";
					
			Item = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Item.Name = "Item";
					
			Door = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Door.Name = "Door";
					
			CAction = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			CAction.Name = "CAction";
			Move = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Move.Name = "Move";
			Move_actions = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Move_actions.Name = "actions";
			Move_actions.LowerBound = 0;
			Move_actions.UpperBound = -1;
			Move_actions.EType = KmmMeta.cINSTANCE.Package.CAction;
			Move.EStructuralFeatures.Add(Move_actions);
			Move_tile = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Move_tile.Name = "tile";
			Move_tile.LowerBound = 0;
			Move_tile.UpperBound = 1;
			Move_tile.EType = KmmMeta.cINSTANCE.Package.Tile;
			Move.EStructuralFeatures.Add(Move_tile);
					
			Direction = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEDataType();
			Direction.Name = "Direction";
		}
		
		public EClass Tile { get; private set;}
		public EStructuralFeature Tile_entity  { get; private set;}
		public EStructuralFeature Tile_onCurrentPath  { get; private set;}
		public EStructuralFeature Tile_onOldPath  { get; private set;}
		public EClass Stats { get; private set;}
		public EStructuralFeature Stats_kathisLove  { get; private set;}
		public EStructuralFeature Stats_markusLove  { get; private set;}
		public EStructuralFeature Stats_money  { get; private set;}
		public EStructuralFeature Stats_level  { get; private set;}
		public EStructuralFeature Stats_experience  { get; private set;}
		public EClass Game { get; private set;}
		public EStructuralFeature Game_stats  { get; private set;}
		public EStructuralFeature Game_entities  { get; private set;}
		public EStructuralFeature Game_currentPath  { get; private set;}
		public EStructuralFeature Game_tiles  { get; private set;}
		public EStructuralFeature Game_currentTile  { get; private set;}
		public EStructuralFeature Game_oldPath  { get; private set;}
		public EClass Entity { get; private set;}
		public EClass Item { get; private set;}
		public EClass Door { get; private set;}
		public EDataType CAction { get; private set;}		
		public EClass Move { get; private set;}
		public EStructuralFeature Move_actions  { get; private set;}
		public EStructuralFeature Move_tile  { get; private set;}
		public EDataType Direction { get; private set;}		
	}
} // UnityCMF.kmm
