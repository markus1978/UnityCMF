using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Board : CObject {
		C2DField<Tile> Tiles { get; }
	}
	
	public class BoardImpl : CObjectImpl, Board {
		public BoardImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private C2DField<Tile> _Tiles;
		public C2DField<Tile> Tiles {
			get {
				if (_Tiles == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Board_tiles;
					_Tiles = new C2DField<Tile>(9,11, this, feature);
				}
				return _Tiles;
			}
		}
	}
} // UnityCMF.kmm
