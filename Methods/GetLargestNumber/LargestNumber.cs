/*      Problem 2. Get largest number

    Write a method GetMax() with two parameters that returns the larger of two integers.
    Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLargestNumber
{
    class LargestNumber
    {

        static int GetMax(int a , int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }


        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("The greatest number is " +  GetMax(thirdNumber,GetMax(firstNumber,secondNumber)));
        }
    }
}
