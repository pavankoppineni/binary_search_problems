using BinarySearchProblems.FindSmallestDivisorGivenThreshold;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.FindSmallestDivisorGivenThreshold
{
    [TestClass]
    public class FindSmallestDivisorGivenThresholdV1Tests
    {
        [TestMethod]
        public void Given_ArrayOfPositiveIntegers_When_FindSmallestDivisor_Then_ShouldReturnSmallestDivisor()
        {
            //Given
            var nums = new int[] { 1, 2, 5, 9 };
            var threshold = 6;
            var problem = new FindSmallestDivisorGivenThresholdV1();
            var expectedResult = 5;

            //When
            var actualResult = problem.SmallestDivisor(nums, threshold);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
