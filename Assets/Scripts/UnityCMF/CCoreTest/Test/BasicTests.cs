using System;
using NUnit.Framework;

namespace UnityCMF.Ccoretest
{
	[TestFixture]
	public class BasicTests
	{
		[Test]
		public void TestCreate() {		
			Container instance = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Assert.IsNotNull(instance);
			Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container, instance.EClass);
		}

		[Test]
		public void TestSingleContents() {		
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content1 = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			Content content2 = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			container.Composition = content1;

			Assert.AreEqual(content1, container.Composition);
			Assert.AreEqual(container, content1.CContainer);
			Assert.AreEqual(null, content2.CContainer);

			container.Composition = content2;

			Assert.AreEqual(content2, container.Composition);
			Assert.AreEqual(null, content1.CContainer);
			Assert.AreEqual(container, content2.CContainer);

			container.Composition = null;

			Assert.AreEqual(null, container.Composition);
			Assert.AreEqual(null, content1.CContainer);
			Assert.AreEqual(null, content2.CContainer);
		}

		[Test]
		public void TestSetContentsAdd() {		
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			container.CompositionSet.Add(content);

			Assert.AreEqual(1, container.CompositionSet.Count);
			Assert.AreEqual(content, container.CompositionSet[0]);
			Assert.AreEqual(container, content.CContainer);
		}

		[Test]
		public void TestSetContentsInsert() {		
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			container.CompositionSet.Insert(content, 0);
			
			Assert.AreEqual(1, container.CompositionSet.Count);
			Assert.AreEqual(content, container.CompositionSet[0]);
			Assert.AreEqual(container, content.CContainer);
		}

		[Test]
		public void TestSetContentsSet() {		
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content1 = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			Content content2 = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			container.CompositionSet.Add(content1);
			container.CompositionSet.Set (0, content2);
			
			Assert.AreEqual(content2, container.CompositionSet[0]);
			Assert.AreEqual(null, content1.CContainer);
			Assert.AreEqual(container, content2.CContainer);

			container.CompositionSet[0] = content1;
			container.CompositionSet[0] = content2;
			
			Assert.AreEqual(content2, container.CompositionSet[0]);
			Assert.AreEqual(null, content1.CContainer);
			Assert.AreEqual(container, content2.CContainer);
		}

		[Test]
		public void TestSetContentsRemove() {		
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			container.CompositionSet.Add(content);
			container.CompositionSet.Remove(content);
			
			Assert.AreEqual(0, container.CompositionSet.Count);
			Assert.AreEqual(null, content.CContainer);

			container.CompositionSet.Add(content);
			container.CompositionSet[0] = null;

			Assert.AreEqual(0, container.CompositionSet.Count);
			Assert.AreEqual(null, content.CContainer);

			container.CompositionSet.Add(content);
			container.CompositionSet.RemoveAt(0);
			
			Assert.AreEqual(0, container.CompositionSet.Count);
			Assert.AreEqual(null, content.CContainer);
		}

		[Test]
		public void TestFieldContents() {
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			FieldContent content = CcoretestMeta.cINSTANCE.Factory.CreateFieldContent();
			container.CompositionField[0,0] = content;
			
			Assert.AreEqual(5, container.CompositionField.DimensionX);
			Assert.AreEqual(7, container.CompositionField.DimensionY);
			Assert.AreEqual(content, container.CompositionField[0,0]);
			Assert.AreEqual(container, content.CContainer);
			
			container.CompositionField[0,0] = null;

			Assert.AreEqual(null, content.CContainer);
		}

		[Test]
		public void TestCrossReferences() {
			Container source = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Container target1 = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Container target2 = CcoretestMeta.cINSTANCE.Factory.CreateContainer();

			source.CrossReference = target1;

			Assert.AreEqual(target1, source.CrossReference);
			Assert.IsNull(target1.CContainer);

			source.CrossReference = null;
			Assert.AreEqual(null, source.CrossReference);

			source.CrossReferenceSet.Add (target1);
			Assert.IsNull(target1.CContainer);
		}

		[Test]
		public void TestFieldCrossReferences() {
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			FieldContent content = CcoretestMeta.cINSTANCE.Factory.CreateFieldContent();
			container.CrossReferenceField[0,0] = content;
			
			Assert.AreEqual(5, container.CrossReferenceField.DimensionX);
			Assert.AreEqual(7, container.CrossReferenceField.DimensionY);
			Assert.AreEqual(content, container.CrossReferenceField[0,0]);
			Assert.AreEqual(null, content.CContainer);
			
			container.CrossReferenceField[0,0] = null;
			
			Assert.AreEqual(null, content.CContainer);
		}

		[Test]
		public void TestAttribute() {
			Container cObject = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Assert.IsNull(cObject.Attribute);

			cObject.Attribute = "Hello";
			Assert.AreEqual("Hello", cObject.Attribute);
		}

		[Test]
		public void TestInterface() {
			Interface cObject = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			Assert.IsNull(cObject.Attribute);
			
			cObject.Attribute = "Hello";
			Assert.AreEqual("Hello", cObject.Attribute);
		}

		[Test]
		public void TestReflection() {
			Container cObject = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			cObject.CSet(CcoretestMeta.cINSTANCE.Package.Container_Attribute, "Hello");

			Assert.AreEqual("Hello", cObject.CGet(CcoretestMeta.cINSTANCE.Package.Container_Attribute));
		}
	}
}

