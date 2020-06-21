using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindNumberInCircularlySortedArray
{
    /// <summary>
    /// https://www.techiedelight.com/search-element-circular-sorted-array/
    /// </summary>
    public class FindNumberInCircularlySortedArrayV1
    {
        public int Find(int[] values, int value)
        {
            return Find(values, value, 0, values.Length - 1);
        }

        private int Find(int[] values, int value, int low, int high)
        {
            if (low == high)
            {
                if (values[low] == value)
                {
                    return low;
                }
                else
                {
                    return -1;
                }
            }

            var mid = (high + low) / 2;
            var next = (mid + 1) % values.Length;
            var previous = (mid - 1 + values.Length) % values.Length;

            if (values[mid] == value)
            {
                return mid;
            }
                
            if (values[mid] <= values[high])
            {
                if (value > values[mid] && value <= values[high])
                {
                    return Find(values, value, mid + 1, high);
                }
                else
                {
                    return Find(values, value, low, mid - 1);
                }
            }
            else
            {
                if (value < values[mid] && value >= values[low])
                {
                    return Find(values, value, low, mid - 1);
                }
                else
                {
                    return Find(values, value, mid + 1, high);
                }
            }
        }
    }
}
