// 07. Sorting an array means to arrange its elements in increasing order. 
//     Write a program to sort an array. Use the "selection sort" algorithm: 
//     Find the smallest element, move it at the first position, find the smallest from the rest, 
//     move it at the second position, etc.


using System;

namespace Sorting
{
    class Sorting
    {
        static void Main()
        {
            Console.Write("How much elements do you want to have the array: ");
            int numberOfElements = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = new int[numberOfElements];

            //I get the numbers into an array

            for (int i = 0; i < numberOfElements; i++)
            {
                arrayOfNumbers[i] = int.Parse(Console.ReadLine());
            }
            //Variable for exchanging values
            int helpfulVariable = 0;


            // I get the first number and compare it with the other.
            // If there is a smaller number I exchange the values and the smallest number goes to the first place.
            // I repeat this with the rest of the elements

            for (int i = 0; i < numberOfElements; i++)
            {
                for (int j = i + 1; j < numberOfElements; j++)
                {
                    if (arrayOfNumbers[j] < arrayOfNumbers[i])
                    {
                        helpfulVariable = arrayOfNumbers[j];
                        arrayOfNumbers[j] = arrayOfNumbers[i];
                        arrayOfNumbers[i] = helpfulVariable;
                    }
                }
            }

            Console.WriteLine("The sorted array is: ");

            for (int i = 0; i < numberOfElements; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}