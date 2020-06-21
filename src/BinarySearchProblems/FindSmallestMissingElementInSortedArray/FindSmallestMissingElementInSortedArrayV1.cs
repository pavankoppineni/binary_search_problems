using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems
{
    /// <summary>
    /// https://www.techiedelight.com/find-smallest-missing-element-sorted-array/
    /// </summary>
    public class FindSmallestMissingElementInSortedArrayV1
    {
        public int Search(int[] sortedArray)
        {
            return Search(sortedArray, 0, sortedArray.Length - 1);
        }

        private int Search(int[] sortedArray, int low, int high)
        {
            return -1;
        }
    }
}
