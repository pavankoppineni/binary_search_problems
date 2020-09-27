using BinarySearchProblems.FindNumberInSortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.FindNumberInSortedArray
{ 
    [TestClass]
    public class FindNumberInSortedArrayV3Tests
    {
        [TestMethod]
        public void Given_SortedArray_When_FindValue_Then_ShouldReturnIndexOfValue()
        {
            //Given
            var values = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var value = 7;
            var findNumberInSortedArray = new FindNumberInSortedArrayV3();
            var expectedIndex = 7;

            //When
            var actualIndex = findNumberInSortedArray.Find(values, value);

            //Then
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
