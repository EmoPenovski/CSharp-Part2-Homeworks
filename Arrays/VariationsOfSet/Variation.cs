using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 20.* Variations of set
//
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].


namespace VariationsOfSet
{
    class Variation
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }
            Variations(arr, new int[k], 0);  // (arr,new int[k], 0,0)
        }

        private static void Variations(int[] nums, int[] arr, int index)     //int[] nums, int[] arr, int index ,int currentIndex
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join(",",arr)); 
                return ;
            }
            for (int i = 0; i < nums.Length; i++)
			{
			     arr[index]=nums[i];
                Variations(nums,arr,index+1);
			}
        }
    }
}
