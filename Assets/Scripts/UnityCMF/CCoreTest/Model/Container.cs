using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Ccoretest {
	public interface Container : CObject {
		string Attribute { get; set; }
		string DerivedAttribute { get; set; }
		Container CrossReference { get; set; }
		Content Composition { get; set; }
		CList<Container> CrossReferenceSet { get; }
		CList<Content> CompositionSet { get; }
		C2DField<FieldContent> CrossReferenceField { get; }
		C2DField<FieldContent> CompositionField { get; }
		
		void Operation();
	}
	public class ContainerImpl : CObjectImpl, Container {
		// PROTECTED REGION ID(Container.custom) ENABLED START
	
		// PROTECTED REGION END
		
		public ContainerImpl(UnityCMF.ECore.EClass eClass) : base(eClass) {
			_crossReferenceField = new C2DField<FieldContent>(5,5, this, CcoretestMeta.cINSTANCE.Package.Container_CrossReferenceField, true);			
			_compositionField = new C2DField<FieldContent>(5,5, this, CcoretestMeta.cINSTANCE.Package.Container_CompositionField, true);			
			// PROTECTED REGION ID(Container.constructor) ENABLED START
	
			// PROTECTED REGION END
		}
		public virtual void Operation() {
			// PROTECTED REGION ID(Container.operation_) ENABLED START
			throw new System.InvalidOperationException("Unsupported Operation Container.operation()");
			// PROTECTED REGION END
		}
		
		private string _attribute;
		public string Attribute {
			get { return _attribute; }
			set {
				string oldValue = _attribute;
				_attribute = value;
				if (CNotificationRequired(CcoretestMeta.cINSTANCE.Package.Container_Attribute)) {
					CNotify(new CAction(this, CActionType.SET, CcoretestMeta.cINSTANCE.Package.Container_Attribute, oldValue, value, -1));
				}	
			}
		}
		private string _derivedAttribute;
		public string DerivedAttribute {
			get { return _derivedAttribute; }
			set {
				string oldValue = _derivedAttribute;
				_derivedAttribute = value;
				if (CNotificationRequired(CcoretestMeta.cINSTANCE.Package.Container_DerivedAttribute)) {
					CNotify(new CAction(this, CActionType.SET, CcoretestMeta.cINSTANCE.Package.Container_DerivedAttribute, oldValue, value, -1));
				}	
			}
		}
		private Container _crossReference;
		public Container CrossReference {
			get { return _crossReference; }
			set {
				Container oldValue = _crossReference;
				_crossReference = value;
				if (CNotificationRequired(CcoretestMeta.cINSTANCE.Package.Container_CrossReference)) {
					CNotify(new CAction(this, CActionType.SET, CcoretestMeta.cINSTANCE.Package.Container_CrossReference, oldValue, value, -1));
				}	
			}
		}
		private Content _composition;
		public Content Composition {
			get { return _composition; }
			set {
				Content oldValue = _composition;
				_composition = value;
				if (oldValue != null) (oldValue as CObjectImpl).CContainer = null;
				if (value != null) (value as CObjectImpl).CContainer = this;
				if (CNotificationRequired(CcoretestMeta.cINSTANCE.Package.Container_Composition)) {
					CNotify(new CAction(this, CActionType.SET, CcoretestMeta.cINSTANCE.Package.Container_Composition, oldValue, value, -1));
				}	
			}
		}
		private CList<Container> _crossReferenceSet;
		public CList<Container> CrossReferenceSet {
			get {
				if (_crossReferenceSet == null) {
					EStructuralFeature feature = CcoretestMeta.cINSTANCE.Package.Container_CrossReferenceSet;
					_crossReferenceSet = new CList<Container>(this, feature);
				}
				return _crossReferenceSet;
			}
		}
		private CList<Content> _compositionSet;
		public CList<Content> CompositionSet {
			get {
				if (_compositionSet == null) {
					EStructuralFeature feature = CcoretestMeta.cINSTANCE.Package.Container_CompositionSet;
					_compositionSet = new CList<Content>(this, feature);
				}
				return _compositionSet;
			}
		}
		private C2DField<FieldContent> _crossReferenceField;
		public C2DField<FieldContent> CrossReferenceField {
			get {
				if (_crossReferenceField == null) {
					EStructuralFeature feature = CcoretestMeta.cINSTANCE.Package.Container_CrossReferenceField;
					_crossReferenceField = new C2DField<FieldContent>(5,5, this, feature);
				}
				return _crossReferenceField;
			}
		}
		private C2DField<FieldContent> _compositionField;
		public C2DField<FieldContent> CompositionField {
			get {
				if (_compositionField == null) {
					EStructuralFeature feature = CcoretestMeta.cINSTANCE.Package.Container_CompositionField;
					_compositionField = new C2DField<FieldContent>(5,5, this, feature);
				}
				return _compositionField;
			}
		}
		
		public override void CSet(EStructuralFeature feature, object value) {
			switch(feature.Name) {
			case "attribute" : 
				Attribute = (string)value;
				break;															
			case "derivedAttribute" : 
				DerivedAttribute = (string)value;
				break;															
			case "crossReference" : 
				CrossReference = (Container)value;
				break;															
			case "composition" : 
				Composition = (Content)value;
				break;															
				default: 
					throw new System.ArgumentException();
			}
		}
		
		public override object CGet(EStructuralFeature feature) {
			switch(feature.Name) {
			case "attribute" : 
				return Attribute;															
			case "derivedAttribute" : 
				return DerivedAttribute;															
			case "crossReference" : 
				return CrossReference;															
			case "composition" : 
				return Composition;															
			case "crossReferenceSet" : 
				return CrossReferenceSet;															
			case "compositionSet" : 
				return CompositionSet;															
			case "crossReferenceField" : 
				return CrossReferenceField;															
			case "compositionField" : 
				return CompositionField;															
				default: 
					throw new System.ArgumentException();
			}
		}
	}

} // UnityCMF.ccoretest
