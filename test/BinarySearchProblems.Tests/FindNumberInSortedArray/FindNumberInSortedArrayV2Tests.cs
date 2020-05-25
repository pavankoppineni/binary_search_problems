using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests
{
    [TestClass]
    public class FindNumberInSortedArrayV2Tests
    {
        private static IEnumerable<object[]> GetDataSet()
        {
            var dataSet = new List<object[]>();

            //Case one
            var sortedArray_1 = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var number_1 = 7;
            var expectedIndex_1 = 6;
            dataSet.Add(new object[] { sortedArray_1, number_1, expectedIndex_1 });

            //Case two
            var sortedArray_2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var number_2 = 1;
            var expectedIndex_2 = 0;
            dataSet.Add(new object[] { sortedArray_2, number_2, expectedIndex_2 });

            return dataSet;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataSet), DynamicDataSourceType.Method)]
        public void SortedArray_Search_ReturnsIndexOfNumber(int[] sortedArray, int number, int expectedIndex)
        {
            //Arrange
            var binarySearch = new FindNumberInSortedArrayV2();

            //Act
            var actualIndex = binarySearch.Search(sortedArray, number);

            //Assert
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
