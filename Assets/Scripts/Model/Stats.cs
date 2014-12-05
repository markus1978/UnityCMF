using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Stats : CObject {
		int KathisLove { get; set; }
		int MarkusLove { get; set; }
		int Money { get; set; }
		int Level { get; set; }
		int Experience { get; set; }
		
	}
	
	public class StatsImpl : CObjectImpl, Stats {
		public StatsImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private int _KathisLove;
		public int KathisLove {
			get { return _KathisLove; }
			set {
				int oldValue = _KathisLove;
				_KathisLove = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Stats_kathisLove)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Stats_kathisLove, oldValue, value, -1));
				}	
			}
		}
		private int _MarkusLove;
		public int MarkusLove {
			get { return _MarkusLove; }
			set {
				int oldValue = _MarkusLove;
				_MarkusLove = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Stats_markusLove)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Stats_markusLove, oldValue, value, -1));
				}	
			}
		}
		private int _Money;
		public int Money {
			get { return _Money; }
			set {
				int oldValue = _Money;
				_Money = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Stats_money)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Stats_money, oldValue, value, -1));
				}	
			}
		}
		private int _Level;
		public int Level {
			get { return _Level; }
			set {
				int oldValue = _Level;
				_Level = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Stats_level)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Stats_level, oldValue, value, -1));
				}	
			}
		}
		private int _Experience;
		public int Experience {
			get { return _Experience; }
			set {
				int oldValue = _Experience;
				_Experience = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Stats_experience)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Stats_experience, oldValue, value, -1));
				}	
			}
		}
		
	}
} // UnityCMF.kmm
