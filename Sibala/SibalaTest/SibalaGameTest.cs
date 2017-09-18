using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sibala;

namespace Sibala.Tests
{
    [TestClass()]
    public class SibalaGameTest
    {
        [TestMethod]
        public void SibalaGameTest_DifferentNumbers_NoPoint()
        {
            var target = new SibalaGame(new List<int> { 1, 2, 3, 4 });
            var result = target.GetResultString();

            Assert.AreEqual("沒點", result);
        }

        [TestMethod]
        public void SibalaGameTest_SameNumbers_OneColor()
        {
            var target = new SibalaGame(new List<int> { 3, 3 ,3,3 });
            var result = target.GetResultString();

            Assert.AreEqual("一色", result);
        }

        [TestMethod]
        public void SibalaGameTest_TwoSameNumbersAndTwoDifferentNumbers_NormalPoint()
        {
            var target = new SibalaGame(new List<int> { 6, 6, 1, 4 });
            var result = target.GetResultString();

            Assert.AreEqual("5點", result);
        }

        [TestMethod]
        public void SibalaGameTest_TwoPairsTwoSameNumbers_SixPoints()
        {
            var target = new SibalaGame(new List<int> { 3, 3, 1, 1 });
            var result = target.GetResultString();

            Assert.AreEqual("6點", result);
        }

        [TestMethod]
        public void SibalaGameTest_TwoSameNumbersAndTwoDifferentNumbersSumThree_BG()
        {
            var target = new SibalaGame(new List<int> { 6, 6, 1, 2 });
            var result = target.GetResultString();

            Assert.AreEqual("BG", result);
        }

        [TestMethod]
        public void SibalaGameTest_TwoSameNumbersAndTwoDifferentNumbersSumTwelve_十八啦()
        {
            var target = new SibalaGame(new List<int> { 5, 5, 6, 6 });
            var result = target.GetResultString();

            Assert.AreEqual("十八啦", result);
        }

    }
}
