using System;
using NUnit.Framework;

namespace UnityCMF.Kmm
{
	[TestFixture]
	public class GameTests
	{
		[Test]
		public void TestCreateGame() {
			Game game = KmmMeta.cINSTANCE.Factory.CreateGame();
		}
	}
}

