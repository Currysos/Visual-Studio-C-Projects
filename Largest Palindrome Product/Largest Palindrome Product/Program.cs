using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Palindrome_Product
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long currentCheck;

            List<long> Palindromes = new List<long>();

            for (long p1 = 100; p1 < 999; p1++)
            {
                for (long p2 = 100; p2 < 999; p2++)
                {
                    currentCheck = p1 * p2;
                    if (CheckIfPalindrome(currentCheck) == true)
                    {
                        Palindromes.Add(currentCheck);
                    }
                }
            }

            Palindromes.Sort();
            Console.WriteLine("Palindromes: ");
            Palindromes.ForEach(Console.WriteLine);

            Console.WriteLine("Largest palindrome: " + Palindromes[Palindromes.Count - 1]);

            bool CheckIfPalindrome(long Number)
            {
                bool result = true;

                string NumberString = Convert.ToString(Number);
                char[] NumberChar = NumberString.ToCharArray();

                char[] InvertedNumberChar = new char[NumberChar.Length];
                string InvertedNumberString;
                long InvertedNumber;

                long index = 0;
                for (int i = NumberChar.Length; i > 0; i--)
                {
                    InvertedNumberChar[index] = NumberChar[i - 1];
                    index++;
                }
                InvertedNumberString = new string(InvertedNumberChar);
                InvertedNumber = Convert.ToInt64(InvertedNumberString);
                if (string.Equals(NumberString, InvertedNumberString))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}