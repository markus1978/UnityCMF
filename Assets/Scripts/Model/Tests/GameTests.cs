using System;
using NUnit.Framework;

namespace UnityCMF.Kmm
{
	[TestFixture]
	public class GameTests
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
		public void TestCreateGame() {		
			Game game = KmmMeta.cINSTANCE.Factory.CreateGame();

			for (int x = 0; x < game.Tiles.DimensionX; x++) {
				for (int y = 0; y < game.Tiles.DimensionY; y++) {
					Assert.IsNotNull (game.Tiles [x, y]);
					Assert.AreEqual(x, game.Tiles[x,y].X);
					Assert.AreEqual(y, game.Tiles[x,y].Y);
				}
			}
		}
	}
}

