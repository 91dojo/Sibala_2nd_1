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
            var source = new SibalaGame(new List<int>() {1, 1, 1, 1});
            var target = new SibalaGame(new List<int>() {1, 1, 1, 2});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_OneColorCompareNoPoint_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() {1, 1, 1, 1});
            var target = new SibalaGame(new List<int>() {1, 2, 3, 4});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_NormalPointCompareOneColor_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() {1, 1, 1, 2});
            var target = new SibalaGame(new List<int>() {1, 1, 1, 1});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void CompareTest_NormalPointCompareNoPoint_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() {1, 1, 1, 2});
            var target = new SibalaGame(new List<int>() {1, 2, 3, 4});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_NoPointCompareOneColor_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() {1, 2, 3, 4});
            var target = new SibalaGame(new List<int>() {1, 1, 1, 1});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void CompareTest_NoPointCompareNormalPoint_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() {1, 2, 3, 4});
            var target = new SibalaGame(new List<int>() {1, 1, 1, 2});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }


        [TestMethod]
        public void CompareTest_OneColorFourCompareOneColorOne_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() {4, 4, 4, 4});
            var target = new SibalaGame(new List<int>() {1, 1, 1, 1});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }


        [TestMethod]
        public void CompareTest_OneColorFourCompareOneColorOhters_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() {4, 4, 4, 4});
            var target = new SibalaGame(new List<int>() {2, 2, 2, 2});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_OneColorFiveCompareOneColorOhters_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() {4, 4, 4, 4});
            var target = new SibalaGame(new List<int>() {6, 6, 6, 6});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_OneColorTwoCompareOneColorSix_ShouldLessZero()
        {
            var source = new SibalaGame(new List<int>() {2, 2, 2, 2});
            var target = new SibalaGame(new List<int>() {6, 6, 6, 6});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result < 0);
        }

        [TestMethod]
        public void CompareTest_NormalPointNineCompareNormalPointSix_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() {6, 6, 4, 5});
            var target = new SibalaGame(new List<int>() {6, 6, 2, 4});

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_NormalPointSixFiveCompareNormalPointSixFour_ShouldGreaterZero()
        {
            var source = new SibalaGame(new List<int>() { 6, 6, 5, 1 });
            var target = new SibalaGame(new List<int>() { 6, 6, 2, 4 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void CompareTest_OneColorCompareOneColor_ShouldEqualZero()
        {
            var source = new SibalaGame(new List<int>() { 6, 6, 6, 6 });
            var target = new SibalaGame(new List<int>() { 6, 6, 6, 6 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void CompareTest_NormalPointCompareNormalPoint_ShouldEqualZero()
        {
            var source = new SibalaGame(new List<int>() { 3, 3, 1, 4 });
            var target = new SibalaGame(new List<int>() { 3, 3, 1, 4 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void CompareTest_NoPointCompareNoPoint_ShouldEqualZero()
        {
            var source = new SibalaGame(new List<int>() { 1, 2, 3, 4 });
            var target = new SibalaGame(new List<int>() { 1, 2, 3, 4 });

            var result = Sibala.Compare(source, target);
            Assert.IsTrue(result == 0);
        }

    }
}

