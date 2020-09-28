using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace BinarySearchProblems.Shell
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = GetValue(3, 2);
        }

        private static bool GetValue(int level, int index)
        {
            if(level == 0)
            {
                return true;
            }

            var numberOfItems = Math.Pow(2, level);
            var mid = (int) numberOfItems / 2;
            if(index < mid)
            {
                return GetValue(level - 1, index);
            }
            else
            {
                return !GetValue(level - 1, index - mid);
            }
        }
    }
}
