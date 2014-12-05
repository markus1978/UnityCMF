using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface KmmFactory {
		Tile CreateTile();
		Board CreateBoard();
		Stats CreateStats();
		Game CreateGame();
		Entity CreateEntity();
		Item CreateItem();
		Door CreateDoor();
	}

	public class KmmFactoryImpl : KmmFactory {
		public Tile CreateTile() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Tile;
			return new TileImpl(eClass);
		}
		public Board CreateBoard() {
			UnityCMF.ECore.EClass eClass = KmmMeta.cINSTANCE.Package.Board;
			return new BoardImpl(eClass);
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
	}
} // UnityCMF.kmm
