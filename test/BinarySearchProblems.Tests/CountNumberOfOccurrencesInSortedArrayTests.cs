using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests
{
    [TestClass]
    public class CountNumberOfOccurrencesInSortedArrayTests
    {
        private static IEnumerable<object[]> GetDataSet()
        {
            var dataSet = new List<object[]>();

            var case_one = new object[]
            {
                new int[] { 1, 1, 2, 2, 2, 2, 3 },
                2,
                4
            };
            var case_two = new object[]
            {
                new int[] { 1, 1, 2, 2, 2, 2, 3 },
                3,
                1
            };
            var case_three = new object[]
            {
                new int[] { 1, 1, 2, 2, 2, 2, 3 },
                4,
                -1
            };

            dataSet.Add(case_one);
            dataSet.Add(case_two);
            dataSet.Add(case_three);

            return dataSet;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSet), DynamicDataSourceType.Method)]
        public void SortedArrayWithIntegersAndNumber_Count_ReturnsNumberOfOccurancesInAnArray(int[] values, int number, int expected)
        {
            //Arrange
            var solution = new CountNumberOfOccurrencesInSortedArray();

            //Act
            var actual = solution.Count(values, number);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
