using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Entity : Poolable {
		Pool ExtraPool { get; set; }
		
		void Apply();
	}
	public class EntityImpl : PoolableImpl, Entity {
		// PROTECTED REGION ID(Entity.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public EntityImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Entity.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		public virtual void Apply() {
			// PROTECTED REGION ID(Entity.apply_) ENABLED START

			// PROTECTED REGION END
		}
		
		private Pool _extraPool;
		public Pool ExtraPool {
			get { return _extraPool; }
			set {
				Pool oldValue = _extraPool;
				_extraPool = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Entity_ExtraPool)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Entity_ExtraPool, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "extraPool" : 
				ExtraPool = (Pool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "extraPool" : 
				return ExtraPool;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
