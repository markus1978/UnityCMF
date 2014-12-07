using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Tile : CObject {
		Entity Entity { get; set; }
		bool IsOnCurrentPath { get; set; }
		bool IsOnOldPath { get; set; }
		
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
		private bool _IsOnCurrentPath;
		public bool IsOnCurrentPath {
			get { return _IsOnCurrentPath; }
			set {
				bool oldValue = _IsOnCurrentPath;
				_IsOnCurrentPath = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_onCurrentPath)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_onCurrentPath, oldValue, value, -1));
				}	
			}
		}
		private bool _IsOnOldPath;
		public bool IsOnOldPath {
			get { return _IsOnOldPath; }
			set {
				bool oldValue = _IsOnOldPath;
				_IsOnOldPath = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_onOldPath)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_onOldPath, oldValue, value, -1));
				}	
			}
		}
		
	}
} // UnityCMF.kmm
