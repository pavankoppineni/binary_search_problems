using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.FindSmallestMissingElementInSortedArray
{
    [TestClass]
    public class FindSmallestMissingElementInSortedArrayV1Tests
    {
        [TestMethod]
        public void SortedArray_Search_ReturnsSmallestMissingElement()
        {
            //Arrange
            var values = new int[] { 1, 2, 3, 4, 5 };
            var expectedValue = 0;
            var problem = new FindSmallestMissingElementInSortedArrayV1();

            //Act
            var actualValue = problem.Search(values);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
