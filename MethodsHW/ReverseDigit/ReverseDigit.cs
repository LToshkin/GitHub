// 07. Write a method that reverses the digits of given decimal number. Example: 256  652

using System;

class Program
{
    static int ReverseDigits(int n, int r = 0)
    {
        return n == 0 ? r : ReverseDigits(n / 10, r * 10 + n % 10);
    }

    static void Main()
    {
        Console.WriteLine(ReverseDigits(123456));
    }
}