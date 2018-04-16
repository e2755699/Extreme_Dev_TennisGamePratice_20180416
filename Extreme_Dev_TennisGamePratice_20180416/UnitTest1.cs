using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Love_All()
        {
            TennisGame tennisGame = new TennisGame();
            var scroe = tennisGame.Scroe();
            Assert.AreEqual("Love All", scroe);
        }
    }
}