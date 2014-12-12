using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	public interface ItemSlot : CObject {
		int TurnsLeft { get; set; }
		Item Item { get; set; }
		
	}
	public class ItemSlotImpl : CObjectImpl, ItemSlot {
		// PROTECTED REGION ID(ItemSlot.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ItemSlotImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			// PROTECTED REGION ID(ItemSlot.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		
		private int _turnsLeft;
		public int TurnsLeft {
			get { return _turnsLeft; }
			set {
				int oldValue = _turnsLeft;
				_turnsLeft = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.ItemSlot_TurnsLeft)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.ItemSlot_TurnsLeft, oldValue, value, -1));
				}	
			}
		}
		private Item _item;
		public Item Item {
			get { return _item; }
			set {
				Item oldValue = _item;
				_item = value;
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.ItemSlot_Item)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.ItemSlot_Item, oldValue, value, -1));
				}	
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "turnsLeft" : 
				TurnsLeft = (int)value;
				break;															
			case "item" : 
				Item = (Item)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "turnsLeft" : 
				return TurnsLeft;															
			case "item" : 
				return Item;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.kmm
