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
            calculations = new ArithmeticCalculations(new NumberValidator(1));
        }
        
        [TestMethod]
        public void AddSingleDigitsTest()
        {
            int? result = calculations.Add(1, 1);
            int expectedResult = 2;
            Assert.AreEqual(expectedResult, result);

        }

        [TestMethod]
        public void AddDoubleDigitsWithPrecision1Test()
        {
            //int? result = calculations.Add(11, 11);
            Assert.ThrowsException<Exception>(() => calculations.Add(11, 11));
            //int? expectedResult = null;
            //Assert.AreEqual(expectedResult, result);

        }

        //delegate int MyAdd(int i, int j);
        //Action myAction;
        //Func<int, int, int> myFunction; // Step 1 - INSIDE Assert.ThrowsException

        [TestMethod]
        public void AddTripleDigitsTest()
        {
            //MyAdd myAdd = calculations.Add;
            //myAdd(111, 111); // calculations.Add(111, 111);
            //myFunction = calculations.Add; // Step 2 - INSIDE Assert.ThrowsException
            //myFunction(111, 111); // calculations.Add(111, 111); // Step 3 - INSIDE Assert.ThrowsException
            Assert.ThrowsException<Exception>(() => calculations.Add(111,111)); // calculations.Add(111,111) ΔΕΝ ΚΑΛΕΙΤΑΙ
        }

        [TestMethod]
        public void AddNegativeNumbersTest()
        {
            Assert.AreEqual(-2, calculations.Add(-1, -1));
        }

        [TestMethod]
        public void AddNegativeNumbersEdgeCaseTest()
        {
            Assert.ThrowsException<Exception>(() => calculations.Add(-int.MaxValue, -int.MaxValue));
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
        public void DivideWithTheeDigitsTest()
        {
            Assert.ThrowsException<Exception>(
                () => calculations.Divide(111,-999));
        }

        [TestMethod]
        public void DivideByZeroTest()
        {
            Assert.ThrowsException<Exception>(
                () => calculations.Divide(2, 0));
        }
    }
}
