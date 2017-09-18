using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sibala;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Sibala.Tests
{
    [TestClass()]
    public class SibalaTests
    {
        [TestMethod]
        public void CompareTest_OneColorCompareNormalPoint_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() {1,1,1,1});
            var target = new SibalaGame(new List<int>() {1,1,1,2});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_OneColorCompareNoPoint_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() { 1, 1, 1, 1 });
            var target = new SibalaGame(new List<int>() { 1, 2, 3, 4 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_NormalPointCompareOneColor_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() { 1, 1, 1, 2 });
            var target = new SibalaGame(new List<int>() { 1, 1, 1, 1 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void CompareTest_NormalPointCompareNoPoint_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() { 1, 1, 1, 2 });
            var target = new SibalaGame(new List<int>() { 1, 2, 3, 4 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_NoPointCompareOneColor_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() { 1, 2, 3, 4 });
            var target = new SibalaGame(new List<int>() { 1, 1, 1, 1 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void CompareTest_NoPointCompareNormalPoint_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() { 1, 2, 3, 4 });
            var target = new SibalaGame(new List<int>() { 1, 1, 1, 2 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }


    }
}

