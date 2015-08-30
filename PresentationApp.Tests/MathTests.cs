using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataManipulation.BasicFunctions;

namespace PresentationApp.Tests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void CanAddIntegers()
        {
            var firstNumber = 3;
            var secondNumber = 5;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8);
        }

        [TestMethod]
        public void CanAddFloats()
        {
            var firstNumber = 3.3f;
            var secondNumber = 5.5f;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8.8f);
        }

        [TestMethod]
        public void CanAddDoubles()
        {
            var firstNumber = 3.3;
            var secondNumber = 5.5;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8.8);
        }

        [TestMethod]
        public void CanAddDecimals()
        {
            var firstNumber = 3.3m;
            var secondNumber = 5.5m;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8.8m);
        }

        [TestMethod]
        public void CanAddIntAndFloat()
        {
            var firstNumber = 3;
            var secondNumber = 5.5f;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8.5f);
        }

        [TestMethod]
        public void CanAddIntAndDouble()
        {
            var firstNumber = 3;
            var secondNumber = 5.5;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8.5);
        }

        [TestMethod]
        public void CanAddFloatAndDouble()
        {
            var firstNumber = 3.3f;
            var secondNumber = 5.5;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8.8);
        }

        [TestMethod]
        public void CanAddIntAndDecimal()
        {
            var firstNumber = 3;
            var secondNumber = 5.5m;

            var result = BasicMath.Addition(firstNumber, secondNumber);

            Assert.AreEqual(result, 8.5m);
        }

        //[TestMethod]
        //public void CanAddFloatAndDecimal()
        //{
        //    var firstNumber = 3.3f;
        //    var secondNumber = 5.5m;

        //    var result = BasicMath.Addition(firstNumber, secondNumber);

        //    Assert.AreEqual(result, 8.8m);
        //}
    }
}
