using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindPivotIndexInRotatedSortedArray
{
    public class FindPivotIndexInRotatedSortedArrayV1
    {
        public int FindPivot(int[] values)
        {
            return FindPivot(values, 0, values.Length - 1);
        }

        private int FindPivot(int[] values, int start, int end)
        {
            if(start > end)
            {
                return -1;
            }

            var mid = (start + end) / 2;
            if (values[mid] > values[mid + 1])
            {
                return mid + 1;
            }

            if(values[start] > values[mid])
            {
                return FindPivot(values, start, mid - 1);
            }
            else
            {
                return FindPivot(values, mid + 1, end);
            }
        }
    }
}
