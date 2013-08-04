/* 13. Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
	 Create appropriate methods.
	 Provide a simple text-based menu for the user to choose which task to solve.
	   Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0              */


using System;

class Program
{
    static int ReverseDigits(int n, int r = 0)
    {
        if (n == 0) return r;

        return ReverseDigits(n / 10, r * 10 + (n % 10));
    }

    static double GetAverage(int[] arr)
    {
        int sum = 0;

        for (int i = 0; i < arr.Length; i++) sum += arr[i];

        return (double)sum / arr.Length;
    }

    static double CalculateEquation(int a, int b)
    {
        return (double)-b / a;
    }

    // INPUTS
    static void InputReverseDigits()
    {
        Console.WriteLine("Enter number:");

        int n = int.Parse(Console.ReadLine());

        if (n >= 0) Console.WriteLine("ReverseDigits: " + ReverseDigits(n));
        else Console.WriteLine("Number should be non-negative.");
    }

    static void InputAverage()
    {
        Console.WriteLine("Enter array size and numbers:");

        int[] arr = new int[int.Parse(Console.ReadLine())];

        for (int i = 0; i < arr.Length; i++) arr[i] = int.Parse(Console.ReadLine());

        if (arr.Length > 0) Console.WriteLine("GetAverage: " + GetAverage(arr));
        else Console.WriteLine("Array should have elements.");
    }

    static void InputEquation()
    {
        Console.WriteLine("Enter a and b:");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a != 0) Console.WriteLine("CalculateEquation: " + CalculateEquation(a, b));
        else Console.WriteLine("Coefficient 'a' should not be zero.");
    }

    static void Main()
    {
        Console.WriteLine("0: ReverseDigits; 1: GetAverage; 2: CalculateEquation");

        int n = int.Parse(Console.ReadLine());

        if (n == 0) InputReverseDigits();
        else if (n == 1) InputAverage();
        else if (n == 2) InputEquation();

        Console.WriteLine("Thank you for using our application!");
    }
}