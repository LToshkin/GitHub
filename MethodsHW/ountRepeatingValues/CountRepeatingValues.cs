// 04. Write a method that counts how many times given number appears in given array. 
//     Write a test program to check if the method is working correctly.

using System;

class Program
{
    static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : " "));
    }

    static int LowerBound(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;

        while (l < r)
        {
            int m = l + (r - l) / 2;

            if (arr[m] >= x) r = m;
            else l = m + 1;
        }

        if (arr[l] < x) l++;

        return l;
    }

    static int UpperBound(int[] arr, int x)
    {
        int l = 0, r = arr.Length - 1;

        while (l < r)
        {
            int m = l + (r - l + 1) / 2;

            if (arr[m] > x) r = m - 1;
            else l = m;
        }

        if (arr[l] > x) l--;

        return l;
    }

    static int CountRepeatingValues(int[] arr, int x)
    {
        return UpperBound(arr, x) - LowerBound(arr, x) + 1;
    }

    static void Main()
    {
        int[] arr = { 1, 5, 2, 3, 3, 3, 4, 3, 4, 6, 5 };

        Array.Sort(arr);
        PrintArray(arr);

        for (int i = 0; i < 10; i++) Console.WriteLine(i + ": " + CountRepeatingValues(arr, i));
    }
}