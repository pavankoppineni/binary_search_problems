using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.LevelOrderTraversalInSpiralForm
{
    /// <summary>
    /// https://www.geeksforgeeks.org/level-order-traversal-in-spiral-form/
    /// </summary>
    public class LevelOrderTraversalInSpiralFormV1
    {
        public IList<int> Traverse(Node root)
        {
            var items = new List<int>();
            var ltr = true;
            var leftToRightStack = new Stack<Node>();
            var rightToLeftStack = new Stack<Node>();
            leftToRightStack.Push(root);
            while(rightToLeftStack.Count > 0 || leftToRightStack.Count > 0)
            {
                if (ltr)
                {
                    while (leftToRightStack.Count > 0)
                    {
                        var currentNode = leftToRightStack.Pop();
                        items.Add(currentNode.Value);
                        if (currentNode.Left!=null)
                        {
                            rightToLeftStack.Push(currentNode.Left);
                        }
                        if(currentNode.Right != null)
                        {
                            rightToLeftStack.Push(currentNode.Right);
                        }
                    }
                    ltr = false;
                }
                else
                {
                    while (rightToLeftStack.Count > 0)
                    {
                        var currentNode = rightToLeftStack.Pop();
                        items.Add(currentNode.Value);
                        if (currentNode.Right != null)
                        {
                            leftToRightStack.Push(currentNode.Right);
                        }
                        if (currentNode.Left != null)
                        {
                            leftToRightStack.Push(currentNode.Left);
                        }
                    }
                    ltr = true;
                }
            }

            return items;
        }
    }
}
