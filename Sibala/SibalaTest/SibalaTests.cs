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
        [TestMethod()]
        public void CompareTest()
        {
            var source = new SibalaGame(new List<int>() {1,1,1,1});
            var target = new SibalaGame(new List<int>() {1,1,1,2});


            Assert.Fail();
        }
    }
}

