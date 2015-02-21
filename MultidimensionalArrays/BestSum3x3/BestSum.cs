/*      Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestSum3x3
{
    class BestSum
    {
        static void Main(string[] args)
        {
            int[,] matrix = 
            {
                {-7, -1, -3, -3, -2, -1},
                {-1, -3, -9, -8, -2, -9},
                {-4, -6, -7, -18, -9, -9} ,
                {-1, -3, 3, -7, -3, -9},
                {-1, -3, -9, -8, -9, -9}
            };

            if (matrix.GetLength(0) < 2 || matrix.GetLength(1) < 2)
            {
                Console.WriteLine("Not a valid matrix");
                return;
            }

            int bestRow = 0;
            int bestCol = 0;


            int bestSum = matrix[0, 0] + matrix[0, 1] + matrix[0, 2] +
                matrix[1, 0] + matrix[1, 1] + matrix[1, 2] +
                matrix[2, 0] + matrix[2, 1] + matrix[2, 2];

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                if (row == matrix.GetLength(0) - 2)
                {
                    continue;
                }
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    if (row == matrix.GetLength(1) - 2)
                    {
                        continue;
                    }
                    int newSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (bestSum < newSum)
                    {
                        bestSum = newSum;
                        bestRow = row;
                        bestCol = col;
                    }

                }
            }
            Console.WriteLine("Best matrix: ");
            Console.WriteLine("{0} {1} {2}", matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
            Console.WriteLine("{0} {1} {2}", matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
            Console.WriteLine("Best sum is: {0}", bestSum);
        }

    }
}
