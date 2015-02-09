using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 1. Allocate array
//
//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.


namespace AllocateArray
{
    class Array20numbers
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * 5; 
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(i != numbers.Length - 1 ? numbers[i] + ", " : numbers[i] + "\n");
            }
        }
    }
}
