// 20. Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 

using System;

namespace VariationOfN
{
    class VariationOfN
    {
        static void Check(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + 1 + (i == arr.Length - 1 ? "\n" : " "));
        }

        static void Variation(int[] arr, int n, int i)
        {
            if (i == arr.Length)
            {
                Check(arr);
                return;
            }

            for (int j = 0; j < n; j++)
            {
                arr[i] = j;

                Variation(arr, n, i + 1);
            }
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[int.Parse(Console.ReadLine())];

            Variation(arr, n, 0);
        }
    }
}
