using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems
{
    public class FindNumberInSortedArrayV2
    {
        public int Search(int[] sortedArray, int number)
        {
            return Search(sortedArray, 0, sortedArray.Length, number);
        }

        private int Search(int[] sortedArray, int low, int high, int number)
        {
            if (low > high)
            {
                return -1;
            }

            var mid = (low + high) / 2;
            if (number == sortedArray[mid])
            {
                return mid;
            }
            else if (number > sortedArray[mid])
            {
                return Search(sortedArray, mid + 1, high, number);
            }
            else
            {
                return Search(sortedArray, low, mid, number);
            }
        }
    }
}
