using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.FindSmallestDivisorGivenThreshold
{
    /// <summary>
    /// https://leetcode.com/problems/find-the-smallest-divisor-given-a-threshold/
    /// </summary>
    public class FindSmallestDivisorGivenThresholdV1
    {
        public int SmallestDivisor(int[] nums, int threshold)
        {
            var min = 1;
            var max = nums[0];
            foreach (var item in nums)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return SmallestDivisor(nums, min, max, threshold);
        }

        private int SmallestDivisor(int[] nums, int min, int max, int threshold)
        {
            if (min == max)
            {
                return min;
            }

            var mid = (min + max) / 2;

            double currentThreshold = 0;
            foreach (var item in nums)
            {
                var result = Math.Ceiling((item / (double)mid));
                currentThreshold += result;
            }

            if (currentThreshold > threshold)
            {
                return SmallestDivisor(nums, mid + 1, max, threshold);
            }

            return SmallestDivisor(nums, min, mid, threshold);
        }
    }
}
