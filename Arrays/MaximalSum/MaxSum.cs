using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8. Maximal sum
//
//Write a program that finds the sequence of maximal sum in given array.


namespace MaximalSum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            int[] nums = { };

            int maxSum = 0, currentSum = 0;
            int maxLength = 0;
            int currentLength = 0;
            int currentStart = -1;
            int startIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                currentStart = i;
                currentLength = 0;
                currentSum = nums[i];
                for (int j = i + 1; currentSum >= 0 && j < nums.Length; j++)
                {
                    if (currentSum + nums[j] > 0)
                    {
                        currentSum += nums[j];
                        currentLength++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    currentSum = 0;
                    currentStart = i;
                    maxLength = currentLength;

                }

            }
            //print result
            for (int i = startIndex; i < maxLength; i++)
            {
                Console.Write("{0} + ", nums[i]);
            }
            Console.WriteLine("{0} + ", maxSum);





        }
    }
}
