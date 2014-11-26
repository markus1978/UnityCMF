using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Board : CObject {
		CList<Tile> Tiles { get; }
	}
	
	public class BoardImpl : CObjectImpl, Board {
		public BoardImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private CList<Tile> _Tiles;
		public CList<Tile> Tiles {
			get {
				if (_Tiles == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Board_tiles;
					_Tiles = new CList<Tile>(this, feature);
				}
				return _Tiles;
			}
		}
	}
} // UnityCMF.kmm
