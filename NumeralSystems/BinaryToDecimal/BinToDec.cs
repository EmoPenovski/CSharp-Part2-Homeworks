﻿/*      Problem 2. Binary to decimal

    Write a program to convert binary numbers to their decimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinToDec
    {
        static int BinaryToDecimalFunc(string number)
        {
            int result = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                result += (int)((number[i] - '0') * Math.Pow(2, number.Length - i - 1));
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine("Enter binary number: ");
            string number = Console.ReadLine();
            Console.WriteLine("Binary representation of {0}(2) is {1}(10).", number, BinaryToDecimalFunc(number));
        }
    }
}
