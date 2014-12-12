using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Tile : C2DFieldElement {
		Entity Entity { get; set; }
		UnityCMF.CCore.Direction OnCurrentPath { get; set; }
		UnityCMF.CCore.Direction OnOldPath { get; set; }
		
	}
	public class TileImpl : UnityCMF.CCore.C2DFieldElementImpl, Tile {
		// PROTECTED REGION ID(Tile.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public TileImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Tile.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private Entity _entity;
		public Entity Entity {
			get { return _entity; }
			set {
				Entity oldValue = _entity;
				_entity = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_Entity)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_Entity, oldValue, value, -1));
				}	
			}
		}
		private UnityCMF.CCore.Direction _onCurrentPath;
		public UnityCMF.CCore.Direction OnCurrentPath {
			get { return _onCurrentPath; }
			set {
				UnityCMF.CCore.Direction oldValue = _onCurrentPath;
				_onCurrentPath = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_OnCurrentPath)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_OnCurrentPath, oldValue, value, -1));
				}	
			}
		}
		private UnityCMF.CCore.Direction _onOldPath;
		public UnityCMF.CCore.Direction OnOldPath {
			get { return _onOldPath; }
			set {
				UnityCMF.CCore.Direction oldValue = _onOldPath;
				_onOldPath = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Tile_OnOldPath)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Tile_OnOldPath, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "entity" : 
				Entity = (Entity)value;
				break;															
			case "onCurrentPath" : 
				OnCurrentPath = (UnityCMF.CCore.Direction)value;
				break;															
			case "onOldPath" : 
				OnOldPath = (UnityCMF.CCore.Direction)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "entity" : 
				return Entity;															
			case "onCurrentPath" : 
				return OnCurrentPath;															
			case "onOldPath" : 
				return OnOldPath;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
