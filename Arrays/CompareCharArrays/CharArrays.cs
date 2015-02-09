using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 3. Compare char arrays
//
//Write a program that compares two char arrays lexicographically (letter by letter).


namespace CompareCharArrays
{
    class CharArrays
    {
        static void Main(string[] args)
        {
            //read first array
            Console.Write("Enter the first array:");
            char[] firstArray = Console.ReadLine().ToCharArray();
            //read second array          
            Console.Write("Enter the second array:");
            char[] secondArray = Console.ReadLine().ToCharArray();

            bool firstIsFirst = true;

            string lexicoglexicographicallyFirst = string.Join("", firstIsFirst);
            int length = Math.Min(firstArray.Length, secondArray.Length);
            for (int i = 0; i < length && firstIsFirst; i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    
                }
            }


        }
    }
}
