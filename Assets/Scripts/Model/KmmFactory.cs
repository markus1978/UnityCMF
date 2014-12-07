using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface KmmFactory {
		Tile CreateTile();
		Stats CreateStats();
		Game CreateGame();
		Entity CreateEntity();
		Item CreateItem();
		Door CreateDoor();
		Move CreateMove();
	}

	public class KmmFactoryImpl : KmmFactory {
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
	}
} // UnityCMF.kmm
