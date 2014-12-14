using System;
using NUnit.Framework;
using UnityCMF.ECore;
using UnityCMF.CCore;

namespace UnityCMF.Ccoretest
{
	[TestFixture]
	public class MetaTests
	{
		[Test]
		public void TestECoreFactoryBootstrap() {
			UnityCMF.ECore.EClass aClass = UnityCMF.ECore.ECoreMeta.cINSTANCE.Factory.CreateEClass ();
			Assert.IsNotNull (aClass);
		}
		
		[Test]
		public void TestCCorePackageBootstrap() {
			UnityCMF.CCore.CPackage package = UnityCMF.CCore.CCoreMeta.cINSTANCE.Package;
			Assert.IsNotNull (package);
		}

		[Test]
		public void TestCompositions() {
			Assert.IsTrue(CcoretestMeta.cINSTANCE.Package.Container_Composition.Containment);
			Assert.IsTrue(CcoretestMeta.cINSTANCE.Package.Container_CompositionSet.Containment);
			Assert.IsTrue(CcoretestMeta.cINSTANCE.Package.Container_CompositionField.Containment);

			Assert.IsFalse(CcoretestMeta.cINSTANCE.Package.Container_CrossReference.Containment);
			Assert.IsFalse(CcoretestMeta.cINSTANCE.Package.Container_CrossReferenceSet.Containment);
		}

		[Test]
		public void TestIsMany() {
			Assert.IsFalse(CcoretestMeta.cINSTANCE.Package.Container_Composition.Many);
			Assert.IsTrue(CcoretestMeta.cINSTANCE.Package.Container_CompositionSet.Many);
			Assert.IsTrue(CcoretestMeta.cINSTANCE.Package.Container_CompositionField.Many);

			Assert.IsFalse(CcoretestMeta.cINSTANCE.Package.Container_CrossReference.Many);
			Assert.IsTrue(CcoretestMeta.cINSTANCE.Package.Container_CrossReferenceSet.Many);
		}
	}
}

