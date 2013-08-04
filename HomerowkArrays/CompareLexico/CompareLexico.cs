// 03. Write a program that compares two char arrays lexicographically (letter by letter).

using System;

namespace CompareLexico
{
    class CompareLexico
    {
        static void Main()
        {
            bool differenceFound = false;

            Console.Write("Input string for the first array of chars: ");
            string charArray1 = Console.ReadLine();

            Console.Write("\nInput string for the second array of chars: ");
            string charArray2 = Console.ReadLine();
            Console.WriteLine();
            int counter = 0;

            //compare  arrays

            while (counter < charArray1.Length && counter < charArray2.Length)
            {
                char tempChar1, tempChar2;  //used to convert small letters to caps temporarily                       
                tempChar1 = ifSmallLetterConvertToCapital(charArray1[counter]);
                tempChar2 = ifSmallLetterConvertToCapital(charArray2[counter]);
                if (tempChar1 > tempChar2)
                {
                    Console.WriteLine("\"{0}\" is After \"{1}\" lexicographically.", charArray1, charArray2);
                    differenceFound = true;
                    break;
                }
                else if (tempChar1 < tempChar2)
                {
                    Console.WriteLine("\"{0}\" is Before \"{1}\" lexicographically.", charArray1, charArray2);
                    differenceFound = true;
                    break;
                }
                else counter++;
            }
            if (!differenceFound) // no differences found, cheking up to smaller array, so the size of arrays matters
            {
                if (charArray1.Length == charArray2.Length)
                {
                    Console.WriteLine("Arrays are identical!");
                }
                else if (charArray1.Length < charArray2.Length)
                {
                    Console.WriteLine("\"{0}\" is Before \"{1}\" lexicographically.", charArray1, charArray2);
                }
                else
                {
                    Console.WriteLine("\"{0}\" is After \"{1}\" lexicographically.", charArray1, charArray2);
                }
            }
        }
        private static char ifSmallLetterConvertToCapital(char ch)
        { // check for small english or cyrillic letter and returns corresponding capital letter, else return same symbol
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'а' && ch <= 'я')) return Convert.ToChar(ch - 32);
            else return ch;
        }
    }
}