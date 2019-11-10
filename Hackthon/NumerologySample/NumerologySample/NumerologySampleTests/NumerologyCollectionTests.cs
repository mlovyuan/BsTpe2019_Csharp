using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerologySample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerologySample.Tests
{
    [TestClass()]
    public class NumerologyCollectionTests
    {
        [TestMethod()]
        public void GetNumerologyIndex_1980_08_16_expexted_6_Test()
        {
            DateTime d = new DateTime(1980, 8, 16);
            int actual = NumerologyCollection.GetNumerologyIndex(d);
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetNumerologyIndex_1980_08_17_expexted_7_Test()
        {
            DateTime d = new DateTime(1980, 8, 17);
            int actual = NumerologyCollection.GetNumerologyIndex(d);
            int expected = 7;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetNumerologyIndex_2000_01_11_expexted_5_Test()
        {
            DateTime d = new DateTime(2000, 1, 11);
            int actual = NumerologyCollection.GetNumerologyIndex(d);
            int expected = 5;
            Assert.AreEqual(expected, actual);
        }
    }
}