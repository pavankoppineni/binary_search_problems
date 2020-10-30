using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindKthSmallestElementInBinarySearchTree
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-k-th-smallest-element-in-bst-order-statistics-in-bst/
    /// </summary>
    public class FindKthSmallestElementInBinarySearchTreeV1
    {
        public Node CreateBinarySearchTree(int[] values)
        {
            var binarySearchTree = new BinarySearchTree();
            foreach(var value in values)
            {
                binarySearchTree.Insert(value);
            }

            return binarySearchTree.Root;
        }

        public int FindKthSmallestElementInBinarySearchTree(Node node, int k)
        {
            if (node.LeftCount + 1 == k)
            {
                return node.Value;
            }

            if (node.LeftCount + 1 > k)
            {
                return FindKthSmallestElementInBinarySearchTree(node.Left, k);
            }
            else
            {
                return FindKthSmallestElementInBinarySearchTree(node.Right, k - (node.LeftCount + 1));
            }
        }
    }
}
