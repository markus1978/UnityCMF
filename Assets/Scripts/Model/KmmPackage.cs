using UnityCMF.ECore;

namespace UnityCMF.Kmm {			 
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
		EStructuralFeature Tile_onPath { get; }
		EClass Board { get; }
		EStructuralFeature Board_tiles { get; }
		EClass Stats { get; }
		EStructuralFeature Stats_kathisLove { get; }
		EStructuralFeature Stats_markusLove { get; }
		EStructuralFeature Stats_money { get; }
		EStructuralFeature Stats_level { get; }
		EStructuralFeature Stats_experience { get; }
		EClass Game { get; }
		EStructuralFeature Game_board { get; }
		EStructuralFeature Game_stats { get; }
		EStructuralFeature Game_entities { get; }
		EClass Entity { get; }
		EClass Item { get; }
		EClass Door { get; }
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
			Tile_onPath = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Tile_onPath.Name = "onPath";
			Tile_onPath.LowerBound = 0;
			Tile_onPath.UpperBound = 1;
			Tile_onPath.EType = ECoreMeta.cINSTANCE.Package.EBoolean;
			Tile.EStructuralFeatures.Add(Tile_onPath);
					
			Board = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Board.Name = "Board";
			Board_tiles = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Board_tiles.Name = "tiles";
			Board_tiles.LowerBound = 0;
			Board_tiles.UpperBound = -1;
			Board_tiles.EType = KmmMeta.cINSTANCE.Package.Tile;
			Board.EStructuralFeatures.Add(Board_tiles);
					
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
			Game_board = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_board.Name = "board";
			Game_board.LowerBound = 1;
			Game_board.UpperBound = 1;
			Game_board.EType = KmmMeta.cINSTANCE.Package.Board;
			Game.EStructuralFeatures.Add(Game_board);
			Game_stats = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_stats.Name = "stats";
			Game_stats.LowerBound = 1;
			Game_stats.UpperBound = 1;
			Game_stats.EType = KmmMeta.cINSTANCE.Package.Stats;
			Game.EStructuralFeatures.Add(Game_stats);
			Game_entities = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEStructuralFeature();
			Game_entities.Name = "entities";
			Game_entities.LowerBound = 0;
			Game_entities.UpperBound = 1;
			Game_entities.EType = KmmMeta.cINSTANCE.Package.Entity;
			Game.EStructuralFeatures.Add(Game_entities);
					
			Entity = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Entity.Name = "Entity";
					
			Item = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Item.Name = "Item";
					
			Door = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Door.Name = "Door";
					
		}
		
		public EClass Tile { get; private set;}
		public EStructuralFeature Tile_entity  { get; private set;}
		public EStructuralFeature Tile_onPath  { get; private set;}
		public EClass Board { get; private set;}
		public EStructuralFeature Board_tiles  { get; private set;}
		public EClass Stats { get; private set;}
		public EStructuralFeature Stats_kathisLove  { get; private set;}
		public EStructuralFeature Stats_markusLove  { get; private set;}
		public EStructuralFeature Stats_money  { get; private set;}
		public EStructuralFeature Stats_level  { get; private set;}
		public EStructuralFeature Stats_experience  { get; private set;}
		public EClass Game { get; private set;}
		public EStructuralFeature Game_board  { get; private set;}
		public EStructuralFeature Game_stats  { get; private set;}
		public EStructuralFeature Game_entities  { get; private set;}
		public EClass Entity { get; private set;}
		public EClass Item { get; private set;}
		public EClass Door { get; private set;}
	}
} // UnityCMF.kmm
