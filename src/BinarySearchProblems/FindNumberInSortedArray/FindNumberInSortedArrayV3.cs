using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindNumberInSortedArray
{
    public class FindNumberInSortedArrayV3
    {
        public int Find(int[] values, int value)
        {
            return Find(values, 0, values.Length - 1, value);
        }

        private int Find(int[] values, int start, int end, int value)
        {
            if (start == end)
            {
                if (values[start] == value)
                {
                    return start;
                }
                return -1;
            }

            var mid = (start + end) / 2;
            if (values[mid] == value)
            {
                return mid;
            }

            if (values[mid] > value)
            {
                return Find(values, start, mid - 1, value);
            }

            return Find(values, mid + 1, end, value);
        }
    }
}
