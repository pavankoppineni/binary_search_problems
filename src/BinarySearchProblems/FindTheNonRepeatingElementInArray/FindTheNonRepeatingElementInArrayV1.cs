using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindTheNonRepeatingElementInArray
{
    /// <summary>
    /// https://www.geeksforgeeks.org/find-the-element-that-appears-once-in-a-sorted-array/
    /// </summary>
    public class FindTheNonRepeatingElementInArrayV1
    {
        public int Find(int[] values)
        {
            return Find(values, 0, values.Length - 1);
        }

        private int Find(int[] values, int startInclusive, int endInclusive)
        {
            if(startInclusive == endInclusive)
            {
                return values[startInclusive];
            }

            if (startInclusive > endInclusive)
            {
                return -1;
            }

            var length = values.Length;
            var midInclusive = (startInclusive + endInclusive) / 2;
            var currentValue = values[midInclusive];

            // Case 1 : Mid is even number
            if (midInclusive % 2 == 0)
            {
                if (values[midInclusive] == values[midInclusive + 1])
                {
                    return Find(values, midInclusive + 2, endInclusive);
                }
                else if (values[midInclusive] == values[midInclusive - 1])
                {
                    return Find(values, startInclusive, midInclusive - 2);
                }
                else
                {
                    return values[midInclusive];
                }
            }
            else
            {
                if (values[midInclusive] == values[midInclusive - 1])
                {
                    return Find(values, midInclusive + 1, endInclusive);
                }
                else if (values[midInclusive] == values[midInclusive + 1])
                {
                    return Find(values, startInclusive, midInclusive - 1);
                }
                else
                {
                    return values[midInclusive];
                }
            }
        }
    }
}
