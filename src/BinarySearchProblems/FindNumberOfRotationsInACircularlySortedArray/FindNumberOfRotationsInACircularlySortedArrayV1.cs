using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindNumberOfRotationsInACircularlySortedArray
{
    /// <summary>
    /// https://www.techiedelight.com/find-number-rotations-circularly-sorted-array/
    /// </summary>
    public class FindNumberOfRotationsInACircularlySortedArrayV1
    {
        public int Find(int[] values)
        {
            return Find(values, 0, values.Length - 1);
        }

        private int Find(int[] values, int start, int end)
        {
            if (values[start] <= values[end])
            {
                return start;
            }

            var mid = (start + end) / 2;

            var next = (mid + 1) % values.Length;
            var previous = (mid - 1 + values.Length) % values.Length;

            if (values[mid] <= values[previous] &&
                values[mid] >= values[next])
            {
                return mid;
            }

            if (values[mid] > values[end])
            {
                return Find(values, mid + 1, end);
            }
            else
            {
                return Find(values, start, mid - 1);
            }
        }
    }
}
