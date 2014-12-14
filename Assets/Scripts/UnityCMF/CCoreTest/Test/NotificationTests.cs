using System;
using NUnit.Framework;
using UnityCMF.CCore;

namespace UnityCMF.Ccoretest
{
	[TestFixture]
	public class NotificationTests
	{
		private void HandleSetAttributeNotification(CAction action) {

		}

		[Test]
		public void TestAttribute() {
			Container cObject = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			bool notified = false;
			cObject.CNotification += (CAction action) => {
				Assert.AreEqual(CActionType.SET, action.ActionType);
				Assert.AreEqual(-1, action.Index);
				Assert.IsNull(action.OldValue);
				Assert.AreEqual("Hello", action.NewValue);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container_Attribute, action.Feature);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container, action.Source.EClass);
				notified = true;
			};
			cObject.Attribute = "Hello";
			Assert.IsTrue(notified);
		}

		[Test]
		public void TestReference() {
			Container cObject = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			bool notified = false;
			cObject.CNotification += (CAction action) => {
				Assert.AreEqual(CActionType.SET, action.ActionType);
				Assert.AreEqual(-1, action.Index);
				Assert.IsNull(action.OldValue);
				Assert.AreEqual(content, action.NewValue);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container_Composition, action.Feature);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container, action.Source.EClass);
				notified = true;
			};
			cObject.Composition = content;
			Assert.IsTrue(notified);
		}

		[Test]
		public void TestReferenceSetAdd() {
			Container cObject = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			bool notified = false;
			cObject.CNotification += (CAction action) => {
				Assert.AreEqual(CActionType.ADD, action.ActionType);
				Assert.AreEqual(0, action.Index);
				Assert.IsNull(action.OldValue);
				Assert.AreEqual(content, action.NewValue);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container_CompositionSet, action.Feature);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container, action.Source.EClass);
				notified = true;
			};
			cObject.CompositionSet.Add(content);
			Assert.IsTrue(notified);
		}

		[Test]
		public void TestReferenceSetSet() {
			Container cObject = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			Content newContent = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			cObject.CompositionSet.Add(content);
			bool notified = false;
			cObject.CNotification += (CAction action) => {
				Assert.AreEqual(CActionType.SET, action.ActionType);
				Assert.AreEqual(0, action.Index);
				Assert.AreEqual(content, action.OldValue);
				Assert.AreEqual(newContent, action.NewValue);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container_CompositionSet, action.Feature);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container, action.Source.EClass);
				notified = true;
			};
			cObject.CompositionSet[0] = newContent;
			Assert.IsTrue(notified);
		}


		[Test]
		public void TestReferenceSetRemove() {
			Container cObject = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Content content = CcoretestMeta.cINSTANCE.Factory.CreateContent();
			cObject.CompositionSet.Add(content);
			bool notified = false;
			cObject.CNotification += (CAction action) => {
				Assert.AreEqual(CActionType.REMOVE, action.ActionType);
				Assert.AreEqual(0, action.Index);
				Assert.IsNull(action.NewValue);
				Assert.AreEqual(content, action.OldValue);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container_CompositionSet, action.Feature);
				Assert.AreEqual(CcoretestMeta.cINSTANCE.Package.Container, action.Source.EClass);
				notified = true;
			};
			cObject.CompositionSet.Remove(content);
			Assert.IsTrue(notified);
		}
	}
}

