using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Poolable : CObject {
		bool IsUnique { get; set; }
		
	}
	public class PoolableImpl : CObjectImpl, Poolable {
		// PROTECTED REGION ID(Poolable.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public PoolableImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Poolable.constructor) ENABLED START
	
			// PROTECTED REGION END
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
			case "isUnique" : 
				IsUnique = (bool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "isUnique" : 
				return IsUnique;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
