using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.CalculatePowerOfNumber
{
    /// <summary>
    /// https://www.geeksforgeeks.org/write-a-c-program-to-calculate-powxn/
    /// </summary>
    public class CalculatePowerOfNumberUsingDivideAndConquerV1
    {
        public int FindPower(int baseNumber, int exponent)
        {
            if (exponent <= 0)
            {
                return 1;
            }

            if(exponent == 1)
            {
                return baseNumber;
            }

            var oddNumber = exponent & 1;
            if(oddNumber == 1)
            {
                var result = FindPower(baseNumber, exponent >> 1);
                return baseNumber * result * result;
            }
            else
            {
                var result = FindPower(baseNumber, exponent >> 1);
                return result * result;
            }
        }
    }
}
