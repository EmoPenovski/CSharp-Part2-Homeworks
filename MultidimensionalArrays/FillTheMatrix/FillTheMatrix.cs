/*      Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {    
        //printing the matrix
        static void PrintingTheMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "\t");
                }
                Console.WriteLine();
            }
        }
        //filling the matrix A
        static void FillTheMatrixA(int[,] matrix)
        {
            for (int col = 0, index = 1; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++, index++)
                {
                    matrix[row, col] = index;
                }
            }
        }
        //filling the matrix B
        static void FillTheMatrixB(int[,] matrix)
        {
            bool isDirDown = true;
            for (int col = 0, row = 0, index = 1; col < matrix.GetLength(1); col++)
            {
                while (row >= 0 && row < matrix.GetLength(0))
                {
                    matrix[row, col] = index++;
                    row += isDirDown ? +1 : -1;
                }
                isDirDown = !isDirDown;
                row += isDirDown ? +1 : -1;
            }
        }
        //filling the matrix C
        static void FillTheMatrixC(int[,] matrix)
        {
            for (int row = matrix.GetLength(0) - 1, index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); row--)
            {
                for (int currCol = (row>=0?0:-row),currRow = (row>=0?row:0); currCol < (matrix.GetLength(1)-(row>=0?row:0));)
                {
                    matrix[currRow++, currCol++] = index++;
                }
            }
        }
        //filling the matrixD
        private static void FillTheMatrixD(int[,] matrix)
        {
            string direction = "down";
            int row = -1, col = 0;

            for (int index = 1; index <= matrix.GetLength(0) * matrix.GetLength(1); index++)
            {
                if (direction == "down")
                {
                    if (matrix[++row, col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row + 1, col)) direction = "right";
                }
                else if (direction == "right")
                {
                    if (matrix[row, ++col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row, col + 1)) direction = "up";
                }
                else if (direction == "up")
                {
                    if (matrix[--row, col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row - 1, col)) direction = "left";
                }
                else if (direction == "left")
                {
                    if (matrix[row, --col] == 0) matrix[row, col] = index;
                    if (!IsTraversable(matrix, row, col - 1)) direction = "down";
                }
            }
        }
        static bool IsTraversable(int[,] matrix, int row, int col)
        {
            return row >= 0 && row < matrix.GetLongLength(0) &&
                   col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
        }



        static void Main(string[] args)
        {
            Console.Write("Enter the size of the matrix: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("In which example you want to fill the matrix(a, b, c or d): ");
            char choice = char.Parse(Console.ReadLine());

            int[,] matrix = new int[size, size];
            switch (choice)
            {
                case 'a': FillTheMatrixA(matrix); break;
                case 'b': FillTheMatrixB(matrix); break;
                case 'c': FillTheMatrixC(matrix); break;
                case 'd': FillTheMatrixD(matrix); break;
                default:
                    break;
            }
            PrintingTheMatrix(matrix);
        }
        
    }
}
