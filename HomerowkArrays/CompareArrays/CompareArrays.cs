// 02. Write a program that reads two arrays from the console and compares them element by element.

using System;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            Console.Write("Count of elements for both arrays: ");

            int n = int.Parse(Console.ReadLine());      // Declaring the count of the elements for both arrays

            if (n <= 0)
            {                                           // Checking if the count is 0 or negative
                Console.WriteLine("\n We won't compare these arrays, dear Sir or Madam. \n");
            }
            else
            {
                int[] arrayOne = new int[n];        // Declaring arrays one
                int[] arrayTwo = new int[n];        // Declaring arrays two

                Console.WriteLine("\n Enter values for the first array \n");

                for (int i = 0; i < n; i++)         // Reading values for the first array
                {
                    Console.Write("Element {0} of the first array = ", i + 1);
                    arrayOne[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("\n Enter values for the second array \n");

                for (int i = 0; i < n; i++)         // Reading values for the second array
                {
                    Console.Write("Element {0} of the second array = ", i + 1);
                    arrayTwo[i] = int.Parse(Console.ReadLine());
                }

                bool areEqual = true;               // Creating bool for being equal

                for (int i = 0; i < n; i++)         // Iterating both arrays
                {
                    if (arrayOne[i] != arrayTwo[i]) // Checking if values aren't equal
                    {
                        areEqual = false;           // If not equal bool changes
                    }
                }

                if (areEqual == true)               // If the integers with the same indexes are equal this appears.
                {
                    Console.WriteLine("\n Your arrays have same values");
                }
                else                                // If not, this.
                {
                    Console.WriteLine("\n Your arrays have different values");
                }
                Console.ReadLine();
            }
        }
    }
}
