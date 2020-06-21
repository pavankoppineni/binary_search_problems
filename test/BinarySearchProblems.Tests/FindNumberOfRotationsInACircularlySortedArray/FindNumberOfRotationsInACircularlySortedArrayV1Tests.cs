using BinarySearchProblems.FindNumberOfRotationsInACircularlySortedArray;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.FindNumberOfRotationsInACircularlySortedArray
{
    [TestClass]
    public class FindNumberOfRotationsInACircularlySortedArrayV1Tests
    {
        public static IEnumerable<object[]> GetDataset()
        {
            var dataset = new List<object[]>
            {
                new object[]
                {
                    new int[]{1, 2, 3, 4, 5, 6},
                    0
                },
                new object[]
                {
                    new int[]{8, 9, 10, 2, 3, 4},
                    3
                },
                new object[]
                {
                    new int[]{9, 1, 2, 3, 4, 5},
                    1
                }
            };
            return dataset;
        }

        [DataTestMethod]
        [DynamicData(nameof(GetDataset), DynamicDataSourceType.Method)]
        public void Given_NearlySortedArray_When_FindNumberOfRotations_Then_ShouldReturnNumberOfRotations(int[] values, int expectedValue)
        {
            //Given
            var find = new FindNumberOfRotationsInACircularlySortedArrayV1();

            //When
            var actualValue = find.Find(values);

            //Then
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
