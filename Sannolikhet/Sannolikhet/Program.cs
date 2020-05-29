using System;
using System.Collections.Generic;

namespace Sannolikhet
{
    class Program
    {
        static void Main(string[] args)
        {
            int listlength;
            float medel, median, standardA, summa, typ, kvartil1, kvartil3, variation;
            List<float> InputList = new List<float>();
            
            //Start
            Console.WriteLine("Från stickprov");
            Console.WriteLine("Antalet nummer?");
            listlength = Convert.ToInt32(Console.ReadLine());

            //Get values
            for (int i = 0; i < listlength; i++)
            {
                Console.WriteLine("\n");
                //Input values
                Console.WriteLine("Value " + (i + 1));
                InputList.Add(Convert.ToSingle(Console.ReadLine()));
            }

            Sortera(InputList);

            Console.Clear();
            InputList.ForEach(Console.WriteLine);
            Console.WriteLine("\n");

            GetMedel(InputList);
            GetMedian(InputList);
            GetSpridning(InputList);
            GetTyp(InputList);
            GetKvartil(InputList);
            Variation(InputList);
            Resultat(InputList);

            void Sortera(List<float> CountList)
            {
                bool isdone = false;
                float n3;
                while (isdone == false)
                {
                    isdone = true;
                    for (int i = 0; i < CountList.Count - 1; i++)
                    {
                        if (CountList[i] > CountList[i + 1])
                        {
                            isdone = false;
                            n3 = CountList[i];
                            CountList[i] = CountList[i + 1];
                            CountList[i + 1] = n3;
                            Console.ForegroundColor = ConsoleColor.Red;
                        }

                        if (isdone == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                            for (int a = 0; a < CountList.Count; a++)
                            {
                                InputList[a] = CountList[a];
                            }
                        }

                    }
                }
            }

            void GetMedel(List<float> CountList)
            {
                float temp = new float();
                for (int i = 0; i < CountList.Count; i++)
                {
                    temp += CountList[i];
                }

                medel = temp / CountList.Count;
            }
            void GetMedian (List<float> CountList)
            {
                try
                {
                    Console.WriteLine("Try");
                    float TRY = CountList.Count / 2;
                    median = CountList[Convert.ToInt32(TRY)];
                }
                catch
                {
                    Console.WriteLine("Catch");
                    float tempa = (CountList.Count - 1) / 2;
                    float tempb = (CountList.Count + 1) / 2;
                    float CATCH = (tempa + tempb) / 2;

                    median = CATCH;
                }
            }

            void GetTyp(List<float> CountList)
            {
                typ = new float();
                float max = new float();
                int max2 = 0;
                int temp = 0;

                for (int i = 0; i < CountList.Count; i++)
                {
                    if(CountList[i] > max)
                    {
                        max = CountList[i];
                    }
                }

                int[] arr = new int[Convert.ToInt32(max + 1)];

                for(int i = 0; i < CountList.Count; i++)
                {
                    arr[Convert.ToInt32(CountList[i])]++;
                }

                for(int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] > max2)
                    {
                        max2 = arr[i];
                        temp = i;
                    }
                }
                typ = temp;
            }

            void GetSpridning(List<float> CountList)
            {
                summa = new float();
                standardA = new float();
                for (int i = 0; i < CountList.Count; i++)
                {
                    summa += Convert.ToSingle(Math.Pow(CountList[i] - medel, 2));
                    standardA = Convert.ToSingle(Math.Sqrt(summa / (CountList.Count - 1)));
                }
            }

            void GetKvartil(List<float> CountList)
            {
                List<float> templist1 = new List<float>();
                List<float> templist2 = new List<float>();

                //templist 1
                for(int i = 0; i < CountList.Count / 2; i++)
                {
                    templist1.Add(CountList[i]);
                }
                //Kvartil 1
                try
                {
                    Console.WriteLine("Try");
                    float TRY = templist1.Count / 2;
                    kvartil1 = templist1[Convert.ToInt32(TRY)];
                }
                catch
                {
                    Console.WriteLine("Catch");
                    float tempa = (templist1.Count - 1) / 2;
                    float tempb = (templist1.Count + 1) / 2;
                    float CATCH = (tempa + tempb) / 2;

                    kvartil1 = CATCH;
                }
                //templist 2
                for (int i = CountList.Count / 2; i < CountList.Count; i++)
                {
                    templist2.Add(CountList[i]);
                }
                //Kvartil 3
                try
                {
                    Console.WriteLine("Try");
                    float TRY = templist2.Count / 2;
                    kvartil3 = templist2[Convert.ToInt32(TRY)];
                }
                catch
                {
                    Console.WriteLine("Catch");
                    float tempa = (templist2.Count - 1) / 2;
                    float tempb = (templist2.Count + 1) / 2;
                    float CATCH = (tempa + tempb) / 2;

                    kvartil3 = CATCH;
                }

            }

            void Variation(List<float> CountList)
            {
                float min = 0;
                float max = 0;
                variation = new float();

                //get min value
                for (int i = 0; i < CountList.Count; i++)
                {
                    if (min > CountList[i])
                    {
                        min = CountList[i];
                    }
                }
                //get max value
                for (int i = 0; i < CountList.Count; i++)
                {
                    if (max < CountList[i])
                    {
                        max = CountList[i];
                    }
                }

                variation = max - min;
            }


            void Resultat(List<float> CountList)
            {
                Console.WriteLine("\nAntalet tal i listan");
                Console.WriteLine(CountList.Count);

                Console.WriteLine("\nSumma");
                Console.WriteLine(summa);

                Console.WriteLine("\nMedian");
                Console.WriteLine(median);

                Console.WriteLine("\nMedelvärde");
                Console.WriteLine(medel);

                Console.WriteLine("\nTypvärde");
                Console.WriteLine(typ);

                Console.WriteLine("\nFörsta kvartil");
                Console.WriteLine(kvartil1);

                Console.WriteLine("\nTredje kvartil");
                Console.WriteLine(kvartil3);

                Console.WriteLine("\nVariationsbrädd");
                Console.WriteLine(variation);

                Console.WriteLine("\nStandardavvikelse");
                Console.WriteLine(standardA);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nDone!");
            }
            Console.WriteLine();
        }
    }
}
