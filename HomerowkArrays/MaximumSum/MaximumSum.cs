// 05. Write a program that reads two integer numbers N and K and an array
//     of N elements from the console. Find in the array those K elements that have maximal sum.

using System;

namespace MaximumSum
{
    class MaximumSum
    {

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int pos = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n - k; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    sum += a[j];
                }
                if (sum > max)
                {
                    max = sum;
                    pos = i;
                }
                sum = 0;
            }
            for (int i = pos; i < pos + k; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}