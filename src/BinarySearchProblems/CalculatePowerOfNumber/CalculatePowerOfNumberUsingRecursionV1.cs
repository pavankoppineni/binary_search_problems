using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.CalculatePowerOfNumber
{
    /// <summary>
    /// https://www.geeksforgeeks.org/write-a-c-program-to-calculate-powxn/
    /// </summary>
    public class CalculatePowerOfNumberUsingRecursionV1
    {
        public double CalculatePower(int baseNumber, int exponent)
        {
            if (exponent == 1)
            {
                return baseNumber;
            }

            return baseNumber * CalculatePower(baseNumber, exponent - 1);
        }
    }
}
