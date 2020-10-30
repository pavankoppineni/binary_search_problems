using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchProblems.SearchNumberInSortedMatrix
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix/
    /// </summary>
    public class SearchNumberInSortedMatrixV1
    {
        private int[][] matrix;
        private int number;
        private int rows;
        private int columns;
        public bool Search(int[][] matrix, int number)
        {
            this.rows = matrix.Length;
            if(this.rows == 0)
            {
                return false;
            }
            this.columns = matrix[0].Length;
            if(this.columns == 0)
            {
                return false;
            }
            this.matrix = matrix;
            this.number = number;
            return SearchRows(0, rows - 1);
        }

        private bool SearchRows(int startRow, int endRow)
        {
            if(startRow == endRow)
            {
                return SearchRow(0, columns - 1, startRow);
            }

            if (startRow > endRow)
            {
                return false;
            }

            var mid = (endRow + startRow) >> 1;

            //Case 1 : Number is equal
            //Action : Return true
            if (matrix[mid][columns - 1] == number)
            {
                return true;
            }

            //Case 2 :Number is greater than [mid, lastColumnIndex]
            if (number > matrix[mid][columns - 1])
            {
                return SearchRows(mid + 1, endRow);
            }

            if (number < matrix[mid][columns - 1])
            {
                return SearchRows(startRow, mid);
            }

            return false;
        }

        private bool SearchRow(int startColumn, int endColumn, int rowIndex)
        {
            if(startColumn > endColumn)
            {
                return false;
            }

            var midColumn = (startColumn + endColumn) >> 1;
            
            //Case 1 : Number is equal to current position
            //Action : Return true
            if(matrix[rowIndex][midColumn] == number)
            {
                return true;
            }
            //Case 2 : Number is greater than current position
            //Action : Search right half of row
            else if (number > matrix[rowIndex][midColumn])
            {
                return SearchRow(midColumn + 1, endColumn, rowIndex);
            }
            //Case 3 : Number is less than current position
            //Action : Search left half of row
            else
            {
                return SearchRow(startColumn, midColumn - 1, rowIndex);
            }
        }
    }
}
