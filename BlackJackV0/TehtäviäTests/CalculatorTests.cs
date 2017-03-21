using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoL08;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoL08.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calc = new Calculator();
            int n1 = 5;
            int n2 = 8;
            int expected = 13;
            int actual = calc.Add(n1, n2);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Assert.Fail();
        }
    }
}