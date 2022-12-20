using Calculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculationsUnitTest
{
    [TestClass]
    public class ArithmeticCalculationsUnitTest
    {
        ArithmeticCalculations calculations;

        public ArithmeticCalculationsUnitTest()
        {
            Console.WriteLine("Tests are about to Start!");
            calculations = new ArithmeticCalculations(new NumberValidator());
        }
        
        [TestMethod]
        public void AddTest()
        {
            int result = calculations.Add(1, 1);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void SubtractTest()
        {
        }
        
        [TestMethod]
        public void MultiplyTest()
        {
        }
        
        [TestMethod]
        public void DivideTest()
        {
        }
    }
}
