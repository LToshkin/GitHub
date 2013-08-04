// 18. Write a program that reads an array of integers and removes from it a minimal number of elements 
//     in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. 

using System;
using System.Linq;

namespace SortedIncOrder
{
    class LongestIncreasingSubArray
    {
        static int[] longestIncreasingSubsequence(int[] array)
        {
            int[] increasingLengths = new int[array.Length];
            increasingLengths[0] = 1;
            for (int i = 1; i < increasingLengths.Length; i++)
            {
                int maxLength = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] <= array[i] && increasingLengths[j] > maxLength)
                    {
                        maxLength = increasingLengths[j];
                    }
                }
                increasingLengths[i] = maxLength + 1;
            }

            int[] returnedSubArray = new int[increasingLengths.Max()];
            int serialNumber = increasingLengths.Max();

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (serialNumber == increasingLengths[i])
                {
                    returnedSubArray[serialNumber - 1] = array[i];
                    serialNumber--;
                }
            }

            return returnedSubArray;
        }

        static void Main(string[] args)
        {
            int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
            int[] longestIncreasingSub = longestIncreasingSubsequence(array);
            Array.ForEach(longestIncreasingSub, Console.WriteLine);
        }
    }
}
