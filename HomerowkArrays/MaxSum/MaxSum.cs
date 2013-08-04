// 08. Write a program that finds the sequence of maximal sum in given array. 

using System;

namespace MaxSum
{
    class MaxSum
    {
        static void Main()
        {
            // I am using Kadane's algorithm
            // http://en.wikipedia.org/wiki/Maximum_subarray_problem

            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int maxSoFar = array[0],
                maxEndHere = array[0],
                begin = 0,
                beginTemp = 0,
                end = 0;
            for (int i = 1; i < array.Length; i++)
            {
                maxEndHere += array[i];
                if (array[i] > maxEndHere)
                {
                    maxEndHere = array[i];
                    beginTemp = i;
                }
                if (maxEndHere > maxSoFar)
                {
                    maxSoFar = maxEndHere;
                    begin = beginTemp;
                    end = i;
                }
            }
            Print(array, array.Length, 0);
            Console.Write(" -> ");
            Print(array, end - begin + 1, begin);

        }
        static void Print(int[] array, int maxSeq, int maxSeqIndex)
        {
            Console.Write("{");
            for (int i = maxSeqIndex; i < maxSeqIndex + maxSeq; i++)
            {
                Console.Write(array[i]);

                if (i == maxSeq + maxSeqIndex - 1)
                {
                    Console.Write("}");
                    break;
                }
                Console.Write(", ");
            }
        }
    }
}
