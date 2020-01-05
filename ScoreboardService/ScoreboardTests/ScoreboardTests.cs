using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScoreboardService;
using System.Collections.Generic;

namespace ScoreboardTests
{
    [TestClass]
    public class ScoreboardTests
    {

        IScoreboard sb = new Scoreboard(new List<Player>()
        {
            new Player("one", 100),
            new Player("two", 120),
            new Player("three", 80),
            new Player("four", 100),
            new Player("five", 79)
        });

        [TestMethod]
        public void ScoreboardSortDescending()
        {
            sb.SortByScore();
            var expected = new List<Player>() {
            new Player("two", 120),
            new Player("one", 100),
            new Player("four", 100),
            new Player("three", 80),
            new Player("five", 79)
            };

            CollectionAssert.AreEqual(expected, sb.Players);
        }

        [TestMethod]
        public void ScoreboardSortAscending()
        {
            sb.SortByScore(false);
            var expected = new List<Player>()
            {
                new Player("five", 79),
                new Player("three", 80),
                new Player("one", 100),
                new Player("four", 100),
                new Player("two", 120)
            };

            CollectionAssert.AreEqual(expected, sb.Players);
        }

        [TestMethod]
        public void AddPlayerCorrectly()
        {
            sb.AddPlayer("six", 140);
            var expected = new List<Player>()
            {
            new Player("one", 100),
            new Player("two", 120),
            new Player("three", 80),
            new Player("four", 100),
            new Player("five", 79),
            new Player("six", 140)
            };

            CollectionAssert.AreEqual(expected, sb.Players);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PlayerConstructorThrowsExceptionOnEmptyName()
        {
            var invalidPlayer = new Player("", 9000);
        }
    }
}
