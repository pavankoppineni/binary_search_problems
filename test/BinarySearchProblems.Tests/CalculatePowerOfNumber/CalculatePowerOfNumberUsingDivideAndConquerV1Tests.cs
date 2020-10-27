using BinarySearchProblems.CalculatePowerOfNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.CalculatePowerOfNumber
{
    [TestClass]
    public class CalculatePowerOfNumberUsingDivideAndConquerV1Tests
    {
        [TestMethod]
        public void Given_BaseNumberAndExponent_When_CalclatePower_Then_ShouldReturnPowerOfBaseNumber()
        {
            //Given
            var baseNumber = 4;
            var exponent = 2;
            var problem = new CalculatePowerOfNumberUsingDivideAndConquerV1();
            var expectedResult = 16;

            //When
            var actualResult = problem.FindPower(baseNumber, exponent);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
