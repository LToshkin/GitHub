// 01. Write a program that allocates array of 20 integers and initializes each 
//     element by its index multiplied by 5. Print the obtained array on the console.

using System;

namespace IndexMultipliedFive
{
    class IndexMultipliedFive
    {
        static void Main()
        {
            int[] array = new int[20];           // Declaring the array
         
            Console.Write("Array {");
            for (int i = 0; i <= 19; i++)        // For loop to give values
            {
                array[i] = i * 5;
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("} \n");           // Checking its lenght
            Console.WriteLine("Array lenght is {0}", array.Length);
            Console.ReadLine();
        }
    }
}