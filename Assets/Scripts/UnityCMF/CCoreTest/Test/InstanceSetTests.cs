using System;
using NUnit.Framework;

namespace UnityCMF.Ccoretest
{
	[TestFixture]
	public class InstanceSetTests
	{
		[Test]
		public void TestInstance() {
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Assert.IsNotNull(container.Instance);
		}

		[Test]
		public void TestInstanceSet() {
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Assert.AreEqual(5, container.InstanceSet.Count);
			for (int i = 0; i < 5; i++) {
				Assert.IsNotNull(container.InstanceSet[i]);
				if (i > 0) {
					Assert.AreNotSame(container.InstanceSet[i], container.InstanceSet[i-1]);
				}
			}
		}

		[Test]
		public void TestInstanceField() {
			Container container = CcoretestMeta.cINSTANCE.Factory.CreateContainer();
			Assert.AreEqual(5, container.InstanceField.DimensionX);
			Assert.AreEqual(7, container.InstanceField.DimensionY);
			for (int x = 0; x < 5; x++) {
				for (int y = 0; y < 7; y++) {
					Assert.IsNotNull(container.InstanceField[x,y]);
				}
			}
		}
	}
}

