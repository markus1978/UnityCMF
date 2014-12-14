using UnityCMF.CCore;
using UnityCMF.ECore;

namespace UnityCMF.Ccoretest {
	
	public sealed class CcoretestMeta {
		public static CcoretestMeta cINSTANCE = new CcoretestMeta();
		private CcoretestPackageImpl _package = new CcoretestPackageImpl();
		private CcoretestFactoryImpl _factory = new CcoretestFactoryImpl();
		public CcoretestPackage Package { 
			get {
				_package.init();
				return _package;
			}
		}
		public CcoretestFactory Factory { 
			get {
				return _factory;
			} 
		}
	}
	public interface CcoretestPackage : CPackage {
		EClass Container { get; }
		EAttribute Container_Attribute { get; }
		EAttribute Container_DerivedAttribute { get; }
		EReference Container_CrossReference { get; }
		EReference Container_Composition { get; }
		EReference Container_CrossReferenceSet { get; }
		EReference Container_CompositionSet { get; }
		EReference Container_CrossReferenceField { get; }
		EReference Container_CompositionField { get; }
		EClass Content { get; }
		EClass Interface { get; }
		EAttribute Interface_Attribute { get; }
		EClass FieldContent { get; }
	}
	public class CcoretestPackageImpl : CcoretestPackage {
		public CFactory FactoryInstance {
			get {
				return CcoretestMeta.cINSTANCE.Factory;
			}	
		}
		
		private bool _isInited = false;
		
		public void init() {
			if (_isInited) return;
			_isInited = true;				
			Container = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Container.Name = "Container";
			Container.CPackage = this;
			Content = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Content.Name = "Content";
			Content.CPackage = this;
			Interface = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			Interface.Name = "Interface";
			Interface.CPackage = this;
			FieldContent = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass();
			FieldContent.Name = "FieldContent";
			FieldContent.CPackage = this;
			Container_Attribute = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			Container_Attribute.Name = "attribute";
			Container_Attribute.LowerBound = 0;
			Container_Attribute.UpperBound = 1;
			Container_Attribute.Derived = false;
			Container_Attribute.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EString;
			Container.EStructuralFeatures.Add(Container_Attribute);
			Container_DerivedAttribute = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			Container_DerivedAttribute.Name = "derivedAttribute";
			Container_DerivedAttribute.LowerBound = 0;
			Container_DerivedAttribute.UpperBound = 1;
			Container_DerivedAttribute.Derived = false;
			Container_DerivedAttribute.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EString;
			Container.EStructuralFeatures.Add(Container_DerivedAttribute);
			Container_CrossReference = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Container_CrossReference.Name = "crossReference";
			Container_CrossReference.LowerBound = 0;
			Container_CrossReference.UpperBound = 1;
			Container_CrossReference.Derived = false;
			Container_CrossReference.EType = this.Container;
			Container_CrossReference.Containment = false;
			Container.EStructuralFeatures.Add(Container_CrossReference);
			Container_Composition = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Container_Composition.Name = "composition";
			Container_Composition.LowerBound = 0;
			Container_Composition.UpperBound = 1;
			Container_Composition.Derived = false;
			Container_Composition.EType = this.Content;
			Container_Composition.Containment = true;
			Container.EStructuralFeatures.Add(Container_Composition);
			Container_CrossReferenceSet = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Container_CrossReferenceSet.Name = "crossReferenceSet";
			Container_CrossReferenceSet.LowerBound = 0;
			Container_CrossReferenceSet.UpperBound = -1;
			Container_CrossReferenceSet.Derived = false;
			Container_CrossReferenceSet.EType = this.Container;
			Container_CrossReferenceSet.Containment = false;
			Container.EStructuralFeatures.Add(Container_CrossReferenceSet);
			Container_CompositionSet = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Container_CompositionSet.Name = "compositionSet";
			Container_CompositionSet.LowerBound = 0;
			Container_CompositionSet.UpperBound = -1;
			Container_CompositionSet.Derived = false;
			Container_CompositionSet.EType = this.Content;
			Container_CompositionSet.Containment = true;
			Container.EStructuralFeatures.Add(Container_CompositionSet);
			Container_CrossReferenceField = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Container_CrossReferenceField.Name = "crossReferenceField";
			Container_CrossReferenceField.LowerBound = 0;
			Container_CrossReferenceField.UpperBound = -1;
			Container_CrossReferenceField.Derived = false;
			Container_CrossReferenceField.EType = this.FieldContent;
			Container_CrossReferenceField.Containment = false;
			Container.EStructuralFeatures.Add(Container_CrossReferenceField);
			Container_CompositionField = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEReference();
			Container_CompositionField.Name = "compositionField";
			Container_CompositionField.LowerBound = 0;
			Container_CompositionField.UpperBound = -1;
			Container_CompositionField.Derived = false;
			Container_CompositionField.EType = this.FieldContent;
			Container_CompositionField.Containment = true;
			Container.EStructuralFeatures.Add(Container_CompositionField);
			Interface_Attribute = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEAttribute();
			Interface_Attribute.Name = "attribute";
			Interface_Attribute.LowerBound = 0;
			Interface_Attribute.UpperBound = 1;
			Interface_Attribute.Derived = false;
			Interface_Attribute.EType = UnityCMF.ECore.ECoreMeta.cINSTANCE.Package.EString;
			Interface.EStructuralFeatures.Add(Interface_Attribute);
		}
		
		public EClass Container { get; private set;}
		public EAttribute Container_Attribute  { get; private set;}
		public EAttribute Container_DerivedAttribute  { get; private set;}
		public EReference Container_CrossReference  { get; private set;}
		public EReference Container_Composition  { get; private set;}
		public EReference Container_CrossReferenceSet  { get; private set;}
		public EReference Container_CompositionSet  { get; private set;}
		public EReference Container_CrossReferenceField  { get; private set;}
		public EReference Container_CompositionField  { get; private set;}
		public EClass Content { get; private set;}
		public EClass Interface { get; private set;}
		public EAttribute Interface_Attribute  { get; private set;}
		public EClass FieldContent { get; private set;}
		
		public EClassifier getClassifier(string name) {
			switch(name) {
				case "Container": return CcoretestMeta.cINSTANCE.Package.Container;
				case "Content": return CcoretestMeta.cINSTANCE.Package.Content;
				case "Interface": return CcoretestMeta.cINSTANCE.Package.Interface;
				case "FieldContent": return CcoretestMeta.cINSTANCE.Package.FieldContent;
				default: return null;	
			}	
		}
	}
	public interface CcoretestFactory : CFactory {
		Container CreateContainer();
		Content CreateContent();
		FieldContent CreateFieldContent();
	}
	public class CcoretestFactoryImpl : CcoretestFactory {
		public CPackage PackageInstance {
			get {
				return CcoretestMeta.cINSTANCE.Package;
			}	
		}
		
		public Container CreateContainer() {
			UnityCMF.ECore.EClass eClass = CcoretestMeta.cINSTANCE.Package.Container;
			return new ContainerImpl(eClass);
		}
		public Content CreateContent() {
			UnityCMF.ECore.EClass eClass = CcoretestMeta.cINSTANCE.Package.Content;
			return new ContentImpl(eClass);
		}
		public FieldContent CreateFieldContent() {
			UnityCMF.ECore.EClass eClass = CcoretestMeta.cINSTANCE.Package.FieldContent;
			return new FieldContentImpl(eClass);
		}
		
		public CObject create(EClass eClass) {
			switch(eClass.Name) {
				case "Container": return new ContainerImpl(eClass);
				case "Content": return new ContentImpl(eClass);
				case "FieldContent": return new FieldContentImpl(eClass);
				default: return null;	
			}	
		}
	}
	
} // UnityCMF.Ccoretest
