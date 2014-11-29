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
	}
	
} // UnityCMF.CCore
