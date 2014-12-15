using UnityEngine;
	using UnityCMF.CCore;
	
	namespace UnityCMF.Ccoretest {
		
		public class ContainerView : MonoBehaviour {
			private Container _model;
			public Container Model { 
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
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_Attribute) {
					OnAttributeChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_DerivedAttribute) {
					OnDerivedAttributeChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_CrossReference) {
					OnCrossReferenceChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_CrossReferenceSet) {
					OnCrossReferenceSetChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_CrossReferenceField) {
					OnCrossReferenceFieldChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_Composition) {
					OnCompositionChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_CompositionSet) {
					OnCompositionSetChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_CompositionField) {
					OnCompositionFieldChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_Instance) {
					OnInstanceChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_InstanceSet) {
					OnInstanceSetChanged(action);
				}
				if (action.Feature == CcoretestMeta.cINSTANCE.Package.Container_InstanceField) {
					OnInstanceFieldChanged(action);
				}
			}
			
			public virtual void OnAttributeChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnAttributeChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnDerivedAttributeChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnDerivedAttributeChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnCrossReferenceChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnCrossReferenceChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnCrossReferenceSetChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnCrossReferenceSetChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnCrossReferenceFieldChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnCrossReferenceFieldChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnCompositionChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnCompositionChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnCompositionSetChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnCompositionSetChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnCompositionFieldChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnCompositionFieldChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnInstanceChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnInstanceChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnInstanceSetChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnInstanceSetChanged) ENABLED START
				
				// PROTECTED REGION END
			}
			public virtual void OnInstanceFieldChanged(CAction action) 
			{
				// PROTECTED REGION ID(ContainerView.OnInstanceFieldChanged) ENABLED START
				
				// PROTECTED REGION END
			}
		}
	} // UnityCMF.ccoretest
