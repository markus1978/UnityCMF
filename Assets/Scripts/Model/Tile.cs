using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Tile : C2DFieldElement {
		Entity Entity { get; set; }
		Direction OnCurrentPath { get; set; }
		Direction OnOldPath { get; set; }
		
	}
	
	public class TileImpl : C2DFieldElementImpl, Tile {
		// PROTECTED REGION ID(Tile.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public TileImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Tile.constructor) ENABLED START
	
			// PROTECTED REGION END
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
		private Direction _OnCurrentPath;
		public Direction OnCurrentPath {
			get { return _OnCurrentPath; }
			set {
				Direction oldValue = _OnCurrentPath;
				_OnCurrentPath = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_onCurrentPath)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_onCurrentPath, oldValue, value, -1));
				}	
			}
		}
		private Direction _OnOldPath;
		public Direction OnOldPath {
			get { return _OnOldPath; }
			set {
				Direction oldValue = _OnOldPath;
				_OnOldPath = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_onOldPath)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_onOldPath, oldValue, value, -1));
				}	
			}
		}
	}
} // UnityCMF.kmm
