using BinarySearchProblems.LevelOrderTraversalInSpiralForm;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.Tests.LevelOrderTraversalInSpiralForm
{
    [TestClass]
    public class LevelOrderTraversalInSpiralFormV1Tests
    {
        [TestMethod]
        public void Given_Tree_When_Traverse_Then_ShouldReturnListOfItemsInSpiralForm()
        {
            //Given
            var root = new Node(1);

            root.Left = new Node(2);
            root.Right = new Node(3);

            root.Left.Left = new Node(4);
            root.Left.Right = new Node(5);

            root.Right.Left = new Node(6);
            root.Right.Right = new Node(7);

            root.Left.Left.Left = new Node(8);
            root.Left.Left.Right = new Node(9);

            root.Left.Right.Left = new Node(10);
            root.Left.Right.Right = new Node(11);

            root.Right.Left.Left = new Node(12);
            root.Right.Left.Right = new Node(13);

            root.Right.Right.Left = new Node(14);
            root.Right.Right.Right = new Node(15);

            var problem = new LevelOrderTraversalInSpiralFormV1();

            //When
            var items = problem.Traverse(root);

            //Then
            Assert.Fail();
        }
    }
}
