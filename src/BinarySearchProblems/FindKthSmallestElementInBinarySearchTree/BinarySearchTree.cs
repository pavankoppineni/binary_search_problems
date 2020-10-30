using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindKthSmallestElementInBinarySearchTree
{
    public class BinarySearchTree
    {
        public Node Root { get; set; }

        public void Insert(int value)
        {
            if (Root == null)
            {
                Root = new Node { Value = value };
                return;
            }

            Insert(Root, value);
        }

        private Node Insert(Node currentNode, int value)
        {
            if(currentNode == null)
            {
                return new Node { Value = value };
            }

            if (value > currentNode.Value)
            {
                currentNode.Right = Insert(currentNode.Right, value);
            }

            else if (value < currentNode.Value)
            {
                currentNode.Left = Insert(currentNode.Left, value);
                currentNode.LeftCount += 1;
            }

            return currentNode;
        }
    }
}
