using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 2. Compare arrays
//
//Write a program that reads two integer arrays from the console and compares them element by element.




namespace CompareArrays
{
    class CompareArr
    {
        static void Main(string[] args)
        {
            //read first array
            Console.Write("Enter the length of the first array:");
            int N = int.Parse(Console.ReadLine());
            int[] firstArray = new int[N];
            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write("Enter {0} element:", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            //read second array          
            Console.Write("Enter the length of the second array:");
            int M = int.Parse(Console.ReadLine());
            int[] secondArray = new int[M];
            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write("Enter {0} element:", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool areEqual = true;

            if (firstArray.Length != secondArray.Length)
            {
                areEqual = false;
            }
            else
            {
                for (int i = 0; i < firstArray.Length && areEqual; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        areEqual = false;
                    }                    
                }
            }
            Console.WriteLine(areEqual);
        }
    }
}
