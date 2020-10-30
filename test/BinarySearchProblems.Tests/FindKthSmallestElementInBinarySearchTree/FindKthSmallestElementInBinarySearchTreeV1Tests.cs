using BinarySearchProblems.FindKthSmallestElementInBinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.FindKthSmallestElementInBinarySearchTree
{
    [TestClass]
    public class FindKthSmallestElementInBinarySearchTreeV1Tests
    {
        [TestMethod]
        public void Given_BinarySearchTreeAndK_When_FindKthSmallestElement_Then_ShouldReturnKthSmallestElementFromBST()
        {
            //Given
            var values = new int[] { 20, 8, 22, 4, 12, 10, 14 };
            var problem = new FindKthSmallestElementInBinarySearchTreeV1();
            var k = 3;
            var expectedKthSmallestNumber = 10;
            var bst = problem.CreateBinarySearchTree(values);

            //When
            var actualKthSmallestNumber = problem.FindKthSmallestElementInBinarySearchTree(bst, k);

            //Then
            Assert.AreEqual(expectedKthSmallestNumber, actualKthSmallestNumber);
        }
    }
}
