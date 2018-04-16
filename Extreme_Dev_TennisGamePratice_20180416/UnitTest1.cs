using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Extreme_Dev_TennisGamePratice_20180416
{
    [TestClass]
    public class UnitTest1
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            tennisGame.FirstPlayerScore();
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Thirty Love");
        }

        private void ScoreShouldBe(string expected)
        {
            Assert.AreEqual(expected, tennisGame.Scroe());
        }
    }
}