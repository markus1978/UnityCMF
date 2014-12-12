using UnityEngine;
	using UnityCMF.CCore;
	
	namespace UnityCMF.Kmm {
		
		public class StatsView : MonoBehaviour {
			private Stats _model;
			public Stats Model { 
				get { return _model; }
				set {
					if (_model != null) {
						_model.CNotification -= OnNotification;
					}
					_model = value;
					_model.CNotification += OnNotification;
				}
			}
			
			private void OnNotification(CAction action)
			{
				if (action.Feature == KmmMeta.cINSTANCE.Package.StatsChanges_KathisLove) {
					OnKathisLoveChanged(action);
				}
				if (action.Feature == KmmMeta.cINSTANCE.Package.StatsChanges_MarkusLove) {
					OnMarkusLoveChanged(action);
				}
				if (action.Feature == KmmMeta.cINSTANCE.Package.StatsChanges_Money) {
					OnMoneyChanged(action);
				}
				if (action.Feature == KmmMeta.cINSTANCE.Package.StatsChanges_Experience) {
					OnExperienceChanged(action);
				}
				if (action.Feature == KmmMeta.cINSTANCE.Package.StatsChanges_Level) {
					OnLevelChanged(action);
				}
				if (action.Feature == KmmMeta.cINSTANCE.Package.Stats_Items) {
					OnItemsChanged(action);
				}
				if (action.Feature == KmmMeta.cINSTANCE.Package.Stats_Quests) {
					OnQuestsChanged(action);
				}
			}
			
			public virtual void OnKathisLoveChanged(CAction action) 
			{
				// PROTECTED REGION ID(StatsView.OnKathisLoveChanged) ENABLED START
			Debug.Log("TEST");
			// PROTECTED REGION END
			}
			public virtual void OnMarkusLoveChanged(CAction action) 
			{
				// PROTECTED REGION ID(StatsView.OnMarkusLoveChanged) ENABLED START
			
			// PROTECTED REGION END
			}
			public virtual void OnMoneyChanged(CAction action) 
			{
				// PROTECTED REGION ID(StatsView.OnMoneyChanged) ENABLED START
			
			// PROTECTED REGION END
			}
			public virtual void OnExperienceChanged(CAction action) 
			{
				// PROTECTED REGION ID(StatsView.OnExperienceChanged) ENABLED START
			
			// PROTECTED REGION END
			}
			public virtual void OnLevelChanged(CAction action) 
			{
				// PROTECTED REGION ID(StatsView.OnLevelChanged) ENABLED START
			
			// PROTECTED REGION END
			}
			public virtual void OnItemsChanged(CAction action) 
			{
				// PROTECTED REGION ID(StatsView.OnItemsChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnQuestsChanged(CAction action) 
			{
				// PROTECTED REGION ID(StatsView.OnQuestsChanged) ENABLED START
				
				// PROTECTED REGION END
			}
		}
	} // UnityCMF.kmm
