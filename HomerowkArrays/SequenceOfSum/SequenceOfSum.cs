// 10. Write a program that finds in given array of integers a sequence of given sum S (if present). 

using System;

namespace SequenceOfSum
{
    class SequenceOfSum
    {
        static void Main()
        {
            int i = 0, j = 0, k = 0, numOfSums = 0, sum = 0, start = 0, end = 0;
            Console.WriteLine("Enter the length of the array N:");
            string nstr = Console.ReadLine();
            int n = int.Parse(nstr);
            Console.WriteLine("Enter the sum S:");
            string sStr = Console.ReadLine();
            int s = int.Parse(sStr);
            int[] array = new int[n];
            while (i < n)
            {
                Console.WriteLine("Please enter the {0} number of the array", i + 1);
                string numStr = Console.ReadLine();
                array[i] = int.Parse(numStr);
                i++;
            }
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (i + j < n)                 // Not going out of the range of the array
                    {
                        sum = sum + array[i + j];   //summing the elements
                        {
                            start = i;              // starting position of range of S
                            end = i + j;            // sending position of range of S
                            numOfSums++;            // count of S
                            Console.Write("\nS sum elements are: ");
                            for (k = start; k <= end; k++)
                            {
                                Console.Write("{0}; ", array[k]);
                            }
                        }
                    }
                }
                sum = 0;
            }
            Console.Write("\nS sum number is: {0}\n", numOfSums);
        }
    }
}
