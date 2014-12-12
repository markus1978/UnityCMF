using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface QuestSlot : CObject {
		QuestGoal Goal { get; set; }
		bool IsAvailable { get; set; }
		bool IsCompleted { get; set; }
		
	}
	public class QuestSlotImpl : CObjectImpl, QuestSlot {
		// PROTECTED REGION ID(QuestSlot.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public QuestSlotImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(QuestSlot.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private QuestGoal _goal;
		public QuestGoal Goal {
			get { return _goal; }
			set {
				QuestGoal oldValue = _goal;
				_goal = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.QuestSlot_Goal)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.QuestSlot_Goal, oldValue, value, -1));
				}	
			}
		}
		private bool _isAvailable;
		public bool IsAvailable {
			get { return _isAvailable; }
			set {
				bool oldValue = _isAvailable;
				_isAvailable = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.QuestSlot_IsAvailable)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.QuestSlot_IsAvailable, oldValue, value, -1));
				}	
			}
		}
		private bool _isCompleted;
		public bool IsCompleted {
			get { return _isCompleted; }
			set {
				bool oldValue = _isCompleted;
				_isCompleted = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.QuestSlot_IsCompleted)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.QuestSlot_IsCompleted, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "goal" : 
				Goal = (QuestGoal)value;
				break;															
			case "isAvailable" : 
				IsAvailable = (bool)value;
				break;															
			case "isCompleted" : 
				IsCompleted = (bool)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "goal" : 
				return Goal;															
			case "isAvailable" : 
				return IsAvailable;															
			case "isCompleted" : 
				return IsCompleted;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
