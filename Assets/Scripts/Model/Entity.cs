using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Entity : Poolable {
		Pool ExtraPool { get; set; }
		
		void Apply();
	}
	public class EntityImpl : CObjectImpl, Entity {
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
		private bool _isUnique;
		public bool IsUnique {
			get { return _isUnique; }
			set {
				bool oldValue = _isUnique;
				_isUnique = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Poolable_IsUnique)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Poolable_IsUnique, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "extraPool" : 
				ExtraPool = (Pool)value;
				break;															
			case "isUnique" : 
				IsUnique = (bool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "extraPool" : 
				return ExtraPool;															
			case "isUnique" : 
				return IsUnique;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
