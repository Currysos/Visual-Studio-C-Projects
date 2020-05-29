using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Collatz_squanece
{
    internal class Program
    {
        private static void Main()
        {
            long Number = 1;
            List<List<long>> CollatzNumbers = new List<List<long>>();

            for (; Number <= 1000000; Number++)
            {
                CollatzNumbers.Add(FindCollatzNumbers(Number));
            }

            int LargestListIndex = 0;
            int LargestSequence = 0;
            int TempSequence = 0;

            for (int i = 0; i < CollatzNumbers.Count; i++)
            {
                TempSequence = CollatzNumbers[i].Count;

                if (LargestSequence < TempSequence)
                {
                    LargestSequence = TempSequence;
                    LargestListIndex = i;
                }
            }

            List<long> LargestCollatzSequence = CollatzNumbers[LargestListIndex];
            long LargestIndex = LargestCollatzSequence[0];
            Console.WriteLine(LargestIndex);

            List<long> FindCollatzNumbers(long CurrentNumber)
            {
                List<long> Answer = new List<long>();
                bool isDone = false;
                long Current = CurrentNumber;
                Answer.Add(Current);
                while (isDone == false)
                {
                    if (Current % 2 == 0)
                    {
                        Current /= 2;
                    }
                    else
                    {
                        Current = (Current * 3) + 1;
                    }
                    Answer.Add(Current);
                    //Checking if done
                    if (Current == 1)
                    {
                        isDone = true;
                        break;
                    }
                }
                return Answer;
            }
        }
    }
}