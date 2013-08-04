// 14. Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;

namespace QuickSortAlg
{
    class QuickSortAlg
    {
        static void Main(string[] args)
        {
                                                                 // Create an unsorted array of string elements
            string[] unsorted = { "z", "e", "x", "c", "m", "q", "a" };


            for (int i = 0; i < unsorted.Length; i++)            // Print the unsorted array
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();


            Quicksort(unsorted, 0, unsorted.Length - 1);         // Sort the array


            for (int i = 0; i < unsorted.Length; i++)            // Print the sorted array
            {
                Console.Write(unsorted[i] + " ");
            }

            Console.WriteLine();
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            string middle = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(middle) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(middle) > 0)
                {
                    j--;
                }

                if (i <= j)
                {

                    string tmp = elements[i];       // Swap
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }


            if (left < j)           // Recursive calls
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }
}
