using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_letter_counts
{
    internal class Program
    {
        private static void Main()
        {
            string[] Singulars = { "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] Tenths = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninty" };

            List<string> NumbersStringList = new List<string>();
            int NumberOfLetters = 0;
            for (int CurrentNumber = 1; CurrentNumber <= 1000; CurrentNumber++)
            {
                string TempString = ReturnString(Convert.ToString(CurrentNumber));
                NumbersStringList.Add(TempString);
                NumberOfLetters += TempString.Length;
            }

            NumbersStringList.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine(NumberOfLetters);

            string ReturnString(string Number)
            {
                string ReturnString = "";
                int _NumberLength = Number.Length;
                bool SingularsDone = false;

                for (int i = 0; i < _NumberLength; i++)
                {
                    //Thousands
                    if (i == _NumberLength - 4)
                    {
                        ReturnString += Singulars[Convert.ToInt32(Convert.ToString(Number[i])) - 1] + "Thousand";
                    }
                    //Hundreds
                    else if (i == _NumberLength - 3)
                    {
                        if (Convert.ToInt32(Convert.ToString(Number[i])) != 0)
                        {
                            ReturnString += Singulars[Convert.ToInt32(Convert.ToString(Number[i])) - 1] + "Hundred";
                        }
                        if (Convert.ToInt32(Convert.ToString(Number[_NumberLength - 1])) > 0 || Convert.ToInt32(Convert.ToString(Number[_NumberLength - 2])) > 0)
                        {
                            ReturnString += "And";
                        }
                    }
                    //Tenths
                    else if (i == _NumberLength - 2 && Convert.ToInt32(Convert.ToString(Number[i])) > 1)
                    {
                        ReturnString += Tenths[Convert.ToInt32(Convert.ToString(Number[i])) - 2];
                    }
                    //Teens
                    else if (i == _NumberLength - 2 && Convert.ToInt32(Convert.ToString(Number[i])) == 1 && SingularsDone == false)
                    {
                        ReturnString += Singulars[Convert.ToInt32(Convert.ToString(Number[i + 1])) + 9];

                        SingularsDone = true;
                    }
                    //Singulars
                    else if (i == _NumberLength - 1 && SingularsDone == false)
                    {
                        if (Convert.ToInt32(Convert.ToString(Number[i])) != 0)
                        {
                            ReturnString += Singulars[Convert.ToInt32(Convert.ToString(Number[i])) - 1];
                        }
                        SingularsDone = true;
                    }
                }

                return ReturnString;
            }

            void VisualizeNumberPyramid(int Number)
            {
                int NumberLength = Convert.ToString(Number).Length;
                for (int i = 0; i < NumberLength; i++)
                {
                    string CurrentNumberString = Convert.ToString(Convert.ToString(Number)[i]);

                    for (int a = 0; a < NumberLength - 1 - i; a++)
                    {
                        CurrentNumberString += "0";
                    }
                    Console.WriteLine(CurrentNumberString);
                }
                Console.WriteLine();
            }
        }
    }
}