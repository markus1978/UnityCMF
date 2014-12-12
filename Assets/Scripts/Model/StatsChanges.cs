using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface StatsChanges : CObject {
		int KathisLove { get; set; }
		int MarkusLove { get; set; }
		int Money { get; set; }
		int Experience { get; set; }
		int Level { get; set; }
		
	}
	public class StatsChangesImpl : CObjectImpl, StatsChanges {
		// PROTECTED REGION ID(StatsChanges.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public StatsChangesImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(StatsChanges.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private int _kathisLove;
		public int KathisLove {
			get { return _kathisLove; }
			set {
				int oldValue = _kathisLove;
				_kathisLove = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.StatsChanges_KathisLove)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.StatsChanges_KathisLove, oldValue, value, -1));
				}	
			}
		}
		private int _markusLove;
		public int MarkusLove {
			get { return _markusLove; }
			set {
				int oldValue = _markusLove;
				_markusLove = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.StatsChanges_MarkusLove)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.StatsChanges_MarkusLove, oldValue, value, -1));
				}	
			}
		}
		private int _money;
		public int Money {
			get { return _money; }
			set {
				int oldValue = _money;
				_money = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.StatsChanges_Money)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.StatsChanges_Money, oldValue, value, -1));
				}	
			}
		}
		private int _experience;
		public int Experience {
			get { return _experience; }
			set {
				int oldValue = _experience;
				_experience = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.StatsChanges_Experience)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.StatsChanges_Experience, oldValue, value, -1));
				}	
			}
		}
		private int _level;
		public int Level {
			get { return _level; }
			set {
				int oldValue = _level;
				_level = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.StatsChanges_Level)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.StatsChanges_Level, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "kathisLove" : 
				KathisLove = (int)value;
				break;															
			case "markusLove" : 
				MarkusLove = (int)value;
				break;															
			case "money" : 
				Money = (int)value;
				break;															
			case "experience" : 
				Experience = (int)value;
				break;															
			case "level" : 
				Level = (int)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "kathisLove" : 
				return KathisLove;															
			case "markusLove" : 
				return MarkusLove;															
			case "money" : 
				return Money;															
			case "experience" : 
				return Experience;															
			case "level" : 
				return Level;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
