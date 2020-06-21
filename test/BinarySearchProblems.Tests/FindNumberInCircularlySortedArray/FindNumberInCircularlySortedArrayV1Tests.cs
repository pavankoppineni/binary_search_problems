using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using BinarySearchProblems.FindNumberInCircularlySortedArray;

namespace BinarySearchProblems.Tests.FindNumberInCircularlySortedArray
{
    [TestClass]
    public class FindNumberInCircularlySortedArrayV1Tests
    {
        [TestMethod]
        public void Given_CircularySortedArray_When_ValueToFind_Then_ShouldReturnIndexOfValue()
        {
            //Given
            var values = new int[] { 8, 1, 2, 3, 4, 5};
            var find = new FindNumberInCircularlySortedArrayV1();
            var expectedIndex = 1;
            var valueToFind = 1;

            //When
            var actualIndex = find.Find(values, valueToFind);

            //Then
            Assert.AreEqual(expectedIndex, actualIndex);
        }
    }
}
