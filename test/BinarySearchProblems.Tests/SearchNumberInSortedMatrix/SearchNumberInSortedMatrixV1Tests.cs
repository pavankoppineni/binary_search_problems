using BinarySearchProblems.SearchNumberInSortedMatrix;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.SearchNumberInSortedMatrix
{
    [TestClass]
    public class SearchNumberInSortedMatrixV1Tests
    {
        [TestMethod]
        public void Given_SortedMatrixAndNumberToSearch_When_SearchForGivenNumber_Then_ShouldReturnTrueIfNumberIsPresent()
        {
            //Given
            var matrix = new int[2][];
            matrix[0] = new int[] { 1, 3, 5, 7 };
            matrix[1] = new int[] { 11, 13, 15, 17 };
            var expectedResult = false;
            var problem = new SearchNumberInSortedMatrixV1();
            var numberToSearch = 10;

            //When
            var actualResult = problem.Search(matrix, numberToSearch);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
