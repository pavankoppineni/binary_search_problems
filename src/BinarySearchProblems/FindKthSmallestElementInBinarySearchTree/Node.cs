using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindKthSmallestElementInBinarySearchTree
{
    public class Node
    {
        public Node Left { get; set; }
        public Node Right { get; set; }
        public int Value { get; set; }
        public int LeftCount { get; set; }
    }
}
