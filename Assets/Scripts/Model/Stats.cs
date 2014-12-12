using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface Stats : StatsChanges {
		CList<ItemSlot> Items { get; }
		CList<QuestSlot> Quests { get; }
		
	}
	public class StatsImpl : StatsChangesImpl, Stats {
		// PROTECTED REGION ID(Stats.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public StatsImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(Stats.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private CList<ItemSlot> _items;
		public CList<ItemSlot> Items {
			get {
				if (_items == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Stats_Items;
					_items = new CList<ItemSlot>(this, feature);
				}
				return _items;
			}
		}
		private CList<QuestSlot> _quests;
		public CList<QuestSlot> Quests {
			get {
				if (_quests == null) {
					EStructuralFeature feature = KmmMeta.cINSTANCE.Package.Stats_Quests;
					_quests = new CList<QuestSlot>(this, feature);
				}
				return _quests;
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
			case "items" : 
				return Items;															
			case "quests" : 
				return Quests;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
