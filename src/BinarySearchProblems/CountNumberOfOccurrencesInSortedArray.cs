using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems
{
    /// <summary>
    /// https://www.geeksforgeeks.org/count-number-of-occurrences-or-frequency-in-a-sorted-array/
    /// </summary>
    public class CountNumberOfOccurrencesInSortedArray
    {
        public int Count(int[] values, int number)
        {
            var count = 0;
            var low = 0;
            var high = values.Length - 1;
            var index = Find(values, number, low, high);
            if (index < 0)
            {
                return -1;
            }

            var rightIndex = index;
            while (rightIndex < values.Length)
            {
                if (values[rightIndex] == number)
                {
                    count++;
                    rightIndex++;
                }
                else
                {
                    break;
                }
            }

            var leftIndex = index - 1;
            while (leftIndex >= 0)
            {
                if(values[leftIndex] == number)
                {
                    count++;
                    leftIndex--;
                }
                else
                {
                    break;
                }
            }

            return count;
        }

        private int Find(int[] values, int number, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            var mid = (high + low) / 2;
            if (values[mid] == number)
            {
                return mid;
            }
            else if (values[mid] > number)
            {
                return Find(values, number, low, mid - 1);
            }
            else
            {
                return Find(values, number, mid + 1, high);
            }
        }
    }
}
