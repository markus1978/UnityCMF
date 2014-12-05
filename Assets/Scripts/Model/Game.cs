using UnityEngine;
using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Kmm {
	 
	public interface Game : CObject {
		Board Board { get; set; }
		Stats Stats { get; set; }
		Entity Entities { get; set; }
		
	}
	
	public class GameImpl : CObjectImpl, Game {
		public GameImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
		}
		
		private Board _Board;
		public Board Board {
			get { return _Board; }
			set {
				Board oldValue = _Board;
				_Board = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_board)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_board, oldValue, value, -1));
				}	
			}
		}
		private Stats _Stats;
		public Stats Stats {
			get { return _Stats; }
			set {
				Stats oldValue = _Stats;
				_Stats = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_stats)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_stats, oldValue, value, -1));
				}	
			}
		}
		private Entity _Entities;
		public Entity Entities {
			get { return _Entities; }
			set {
				Entity oldValue = _Entities;
				_Entities = value;
				
				if (CNotificationRequired(KmmMeta.cINSTANCE.Package.Game_entities)) {
					CNotify(new CAction(this, CActionType.SET, KmmMeta.cINSTANCE.Package.Game_entities, oldValue, value, -1));
				}	
			}
		}
		
	}
} // UnityCMF.kmm
