// 14. Write methods to calculate minimum, maximum, average, sum and product of given 
//     set of integer numbers. Use variable number of arguments.

// 15. * Modify your last program and try to make it work for any number type, not just integer 
//     (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).



using System;

class Program
{
    static T GetMin<T>(T[] arr) where T : IComparable<T>
    {
        int best = 0;

        for (int i = 1; i < arr.Length; i++)
            if (arr[i].CompareTo(arr[best]) < 0) best = i;

        return arr[best];
    }

    static T GetMax<T>(T[] arr) where T : IComparable<T>
    {
        int best = 0;

        for (int i = 1; i < arr.Length; i++)
            if (arr[i].CompareTo(arr[best]) > 0) best = i;

        return arr[best];
    }

    static double GetAverage<T>(T[] arr)
    {
        return Convert.ToDouble(GetSum(arr)) / arr.Length;
    }

    static T GetSum<T>(T[] arr)
    {
        dynamic accum = 0;

        for (int i = 0; i < arr.Length; i++) accum += arr[i];

        return accum;
    }

    static T GetProduct<T>(T[] arr)
    {
        dynamic accum = 1;

        for (int i = 0; i < arr.Length; i++) accum *= arr[i];

        return accum;
    }

    static void Main()
    {
        int[] arr = { 5, 8, -1, 3 };

        Console.WriteLine(GetMin(arr));
        Console.WriteLine(GetMax(arr));
        Console.WriteLine(GetAverage(arr));
        Console.WriteLine(GetSum(arr));
        Console.WriteLine(GetProduct(arr));
    }
}