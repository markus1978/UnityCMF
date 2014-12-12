using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface QuestGoal : CObject {
		
	}
	public class QuestGoalImpl : CObjectImpl, QuestGoal {
		// PROTECTED REGION ID(QuestGoal.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public QuestGoalImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(QuestGoal.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
