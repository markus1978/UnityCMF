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
		public readonly object Data;

		public CAction(CObject source, CActionType type, EStructuralFeature feature, object oldValue, object newValue, int index, object data)
		{
			ActionType = type;
			Source = source;
			Feature = feature;
			OldValue = oldValue;
			NewValue = newValue;
			Index = index;
			Data = data;
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

		public void ReExecute() {
			if (ActionType == CActionType.SET) {
				if (Index == -1) {
					Source.CSet(Feature, NewValue);
				} else {
					(Source.CGet(Feature) as CValueSet).Set(Index, NewValue);
				}
			} else if (ActionType == CActionType.ADD) {
				(Source.CGet(Feature) as CValueSet).Insert(NewValue, Index);
			} else if (ActionType == CActionType.REMOVE) {
				(Source.CGet(Feature) as CValueSet).RemoveAt(Index);
			} else {
				Debug.LogError("Unreachable code reached.");
			}
		}

		public override string ToString ()
		{
			return Source.EClass.Name + "." + Feature.Name + "." + ActionType + "(" + OldValue + "->" + NewValue + ")";
		}
	}
	
} // UnityCMF.CCore
