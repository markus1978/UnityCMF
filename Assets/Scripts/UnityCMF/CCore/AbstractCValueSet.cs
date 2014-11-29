using System;
using UnityCMF.ECore;

namespace UnityCMF.CCore
{
	public abstract class AbstractCValueSet<ElementType>
	{			
		private readonly CObject _owner;
		private readonly EStructuralFeature _feature;

		protected void CNotify(CActionType actionType, ElementType oldValue, ElementType newValue, int index)
		{
			if (_owner.CNotificationRequired(_feature)) {
				_owner.CNotify(new CAction(_owner, CActionType.SET, _feature, oldValue, newValue, index)); 
			}
		}
		
		public AbstractCValueSet (CObject owner, EStructuralFeature feature)
		{
			_owner = owner;
			_feature = feature;
		}
	}
}

