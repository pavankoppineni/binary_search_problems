using BinarySearchProblems.FindTheNonRepeatingElementInArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.FindTheNonRepeatingElementInArray
{
    [TestClass]
    public class FindTheNonRepeatingElementInArrayV1Tests
    {
        private static IList<object[]> GetDataSet()
        {
            var dataSet = new List<object[]>();

            var caseOne = new object[]
            {
                new int[] { 1, 1, 2, 2, 3, 4, 4 },
                3
            };

            var caseTwo = new object[]
            {
                new int[] { 1, 1, 2, 3, 3, 4, 4 },
                2
            };

            var caseThree = new object[]
            {
                new int[] { 1, 2, 2, 3, 3, 4, 4 },
                1
            };

            var caseFour = new object[]
            {
                new int[] { 1, 1, 2, 2, 3, 3, 4 },
                4
            };

            dataSet.Add(caseOne);
            dataSet.Add(caseTwo);
            dataSet.Add(caseThree);
            dataSet.Add(caseFour);
            return dataSet;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSet), DynamicDataSourceType.Method)]
        public void Given_SortedArray_When_Find_Then_ShouldReturnNonRepeatingElement(int[] values, int expectedValue)
        {
            //Given
            var problem = new FindTheNonRepeatingElementInArrayV1();

            //When
            var actualValue = problem.Find(values);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
