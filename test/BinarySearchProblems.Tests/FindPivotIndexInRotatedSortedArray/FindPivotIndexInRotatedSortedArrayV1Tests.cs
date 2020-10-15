using BinarySearchProblems.FindPivotIndexInRotatedSortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.FindPivotIndexInRotatedSortedArray
{
    [TestClass]
    public class FindPivotIndexInRotatedSortedArrayV1Tests
    {
        [TestMethod]
        public void Given_RotatedSortedArray_When_FindPivot_Then_ShouldReturnPivotIndexOfArray()
        {
            //Given
            var values = new int[] { 7, 8, 9, 10, 1, 2 };
            var problem = new FindPivotIndexInRotatedSortedArrayV1();
            var expectedResult = 4;

            //When
            var actualResult = problem.FindPivot(values);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
