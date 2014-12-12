using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Pool : CObject {
		CList<Poolable> Poolables { get; }
		
		Poolable Draw();
	}
	public class PoolImpl : CObjectImpl, Pool {
		// PROTECTED REGION ID(Pool.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public PoolImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Pool.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		public virtual Poolable Draw() {
			// PROTECTED REGION ID(Pool.draw_) ENABLED START
			throw new System.InvalidOperationException("Unsupported Operation Pool.draw()");
			// PROTECTED REGION END
		}
		
		private CList<Poolable> _poolables;
		public CList<Poolable> Poolables {
			get {
				if (_poolables == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Pool_Poolables;
					_poolables = new CList<Poolable>(this, feature);
				}
				return _poolables;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "poolables" : 
				return Poolables;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
