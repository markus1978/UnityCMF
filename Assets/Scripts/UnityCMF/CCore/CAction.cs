using UnityEngine;
using System.Collections;
using UnityCMF.ECore;

namespace UnityCMF.CCore {

	public enum CActionType { SET, ADD, REMOVE };

	public class CAction {
		
		public readonly CActionType ActionType;
		public readonly CObject Source;
		public readonly EStructuralFeature Feature;
		public readonly object OldValue;
		public readonly object NewValue;
		public readonly int Index;

		public CAction(CObject source, CActionType type, EStructuralFeature feature, object oldValue, object newValue, int index) 
		{
			ActionType = type;
			Source = source;
			Feature = feature;
			OldValue = oldValue;
			NewValue = newValue;
			Index = index;
		}

		public void Reverse() {
			if (ActionType == CActionType.SET) {
				if (Index == -1) {
					Source.CSet(Feature, OldValue);
				} else {
					(Source.CGet(Feature) as CValueSet).Set(Index, OldValue);
				}
			} else if (ActionType == CActionType.ADD) {
				(Source.CGet(Feature) as CValueSet).RemoveAt(Index);
			} else if (ActionType == CActionType.REMOVE) {
				(Source.CGet(Feature) as CValueSet).Insert(OldValue, Index);
			} else {
				Debug.LogError("Unreachable code reached.");
			}
		}
	}
	
} // UnityCMF.CCore
