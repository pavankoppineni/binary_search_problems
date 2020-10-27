using BinarySearchProblems.CalculatePowerOfNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.CalculatePowerOfNumber
{
    [TestClass]
    public class CalculatePowerOfNumberUsingRecursionV1Tests
    {
        [TestMethod]
        public void Given_BaseAndExponent_When_CalculatePower_Then_ShouldReturnPower()
        {
            //Given
            var baseNumber = 4;
            var exponent = 4;
            var expectedResult = 256;
            var problem = new CalculatePowerOfNumberUsingRecursionV1();

            //When
            var actualResult = problem.CalculatePower(baseNumber, exponent);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
