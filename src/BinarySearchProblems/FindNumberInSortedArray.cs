using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems
{
    /// <summary>
    /// Problem : Find a number in sorted array
    /// </summary>
    public class FindNumberInSortedArray
    {
        public int Find(int[] values, int number)
        {
            var low = 0;
            var high = values.Length - 1;
            return Find(values, number, low, high);
        }

        private int Find(int[] values, int number, int low, int high)
        {
            if (low > high)
            {
                return -1;
            }

            var mid = (low + high) / 2;
            if (values[mid] == number)
            {
                return mid;
            }
            else if (number > values[mid])
            {
                return Find(values, number, mid + 1, high);
            }
            else
            {
                return Find(values, number, low, mid - 1);
            }
        }
    }
}
