using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Tile : CObject {
		Entity Entity { get; set; }
		bool IsOnPath { get; set; }
	}
	
	public class TileImpl : CObjectImpl, Tile {
		public TileImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private Entity _Entity;
		public Entity Entity {
			get { return _Entity; }
			set {
				Entity oldValue = _Entity;
				_Entity = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_entity)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_entity, oldValue, value, -1));
				}	
			}
		}
		private bool _IsOnPath;
		public bool IsOnPath {
			get { return _IsOnPath; }
			set {
				bool oldValue = _IsOnPath;
				_IsOnPath = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_onPath)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_onPath, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.kmm
