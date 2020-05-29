using System;
using System.Numerics;

namespace Power_digit_sum
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BigInteger Base = 2;
            BigInteger Exponent = 1000;
            BigInteger Answer = Power(Base, Exponent);
            string AnswerString = Convert.ToString(Answer);

            int AnswerSum = 0;

            for (int i = 0; i < AnswerString.Length; i++)
            {
                AnswerSum += Convert.ToInt32(Convert.ToString(AnswerString[i]));
            }
            Console.WriteLine(Answer);
            Console.WriteLine(AnswerSum);

            BigInteger Power(BigInteger _Base, BigInteger _Exponent)
            {
                BigInteger Out = 1;
                for (int i = 0; i < _Exponent; i++)
                {
                    Out *= _Base;
                }

                return Out;
            }
        }
    }
}