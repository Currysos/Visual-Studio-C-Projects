using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Counting_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int lown, highn, stagedelay;
            var SW = new Stopwatch();
            long visualize, delay, nia, YN, numberplace = 0, indexplace = 0, currentValue = 0, HighestNumber = 0, Calculations = 0;
            Random rnd = new Random();
            long[] arr, Index, Places, sortedArr;   

            Start();

            void Start()
            {
                Console.WriteLine("Counting Sort");

                Console.WriteLine("Numbers in the array? ");
                string nias = Console.ReadLine();
                nia = Convert.ToInt64(nias);
                Console.Clear();

                arr = new long[nia];

                Console.WriteLine("Want to visualize the sorting?\n   Yes(1)  No(2)  Stage Visualization(3)");
                string visualizes = Console.ReadLine();
                visualize = Convert.ToInt64(visualizes);
                Console.Clear();

                if (visualize == 1)
                {
                    Console.WriteLine("Delay? \nMore numbers in array requires less delay for it to sort" +
                        "\n Recomendations;" +
                        "\n     *10 numbers or less: 100 delay" +
                        "\n     *100 numbers or less: 10 delay" +
                        "\n     *500 numbers or less; 0 delay" +
                        "\n     *500 numbers or more: 0 delay" +
                        "\n");
                    string delays = Console.ReadLine();
                    delay = Convert.ToInt64(delays);
                    stagedelay = 0;
                }
                else if(visualize == 3)
                {
                    Console.WriteLine("Delay between stages? \nThis will help you see the different stages in the sorting but not the sorting itself. \nRecomended: 500 \n");
                    string stagedelays = Console.ReadLine();
                    stagedelay = Convert.ToInt32(stagedelays);
                    delay = 0;
                }
                else
                {
                    delay = 0;
                    stagedelay = 0;
                }
                Console.Clear();

                Console.WriteLine("Lowest possible number? ");
                string lows = Console.ReadLine();
                lown = Convert.ToInt32(lows);

                Console.WriteLine("Highest highest number? ");
                string highs = Console.ReadLine();
                highn = Convert.ToInt32(highs);
                RandomizeArray();
                Console.Clear();

                if (visualize == 1)
                {
                    Console.WriteLine("Looks good?\n" +
                        "*Numbers in array: " + nia +
                        "\n*Delay; " + delay +
                        "\n*Array is from: " + lown + " to: " + highn +
                        "\n Yes(1)  No(2)");
                }
                else
                {
                    Console.WriteLine("Looks good?\n" +
                        "*Numbers in array: " + nia +
                        "\n*No Visualization" +
                        "\n*Array is from: " + lown + " to: " + highn +
                        "\n Yes(1)  No(2)");
                }

                string YNs = Console.ReadLine();
                YN = Convert.ToInt64(YNs);
                Console.Clear();

                if (YN == 1)
                {
                    if (visualize != 2)
                    {
                        printarray(arr, "");
                        Console.WriteLine("\nYour array");

                        Console.WriteLine("\n\nGreen means done, red means working. The text may flash green, it means that that number is set to position" +
                            "\n\n\n                                         Start sorting, press enter");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    //Start void is done and sorting chall begin
                    SW.Start();
                    StartCountSorting();
                }
                else
                {
                    Start();
                }
            }

            void RandomizeArray()
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = rnd.Next(lown, highn + 1);
                }
            }

            void printarray(long[] Arr, string BeforeText)
            {
                Console.Write(BeforeText + ":\n");
                Console.WriteLine(string.Join(", ", Arr));
                Console.WriteLine("\n");
            }

            void CreateIndex()
            {
                if (visualize == 1)
                {
                    Console.Clear();
                    printarray(arr, "Original Array");
                    Thread.Sleep(Convert.ToInt32(delay));
                }
                if (visualize == 3)
                {
                    printarray(arr, "Original Array");
                    Thread.Sleep(stagedelay);
                }

                //Find Highest Number in arr[]
                for(long c = 0; c < arr.Length; c++)
                {
                    Calculations++;
                    if(HighestNumber < arr[c])
                    {
                        Calculations++;
                        HighestNumber = arr[c];
                    }
                    if(visualize == 1)
                    {
                        Console.Clear();
                        printarray(arr, "Original Array");
                        Console.WriteLine(HighestNumber);
                        Thread.Sleep(Convert.ToInt32(delay));
                    }
                }
                if (visualize == 3)
                {
                    Console.WriteLine("Highest number in array: " + HighestNumber);
                    Thread.Sleep(stagedelay);
                }
                //Set Length of index
                Index = new long[HighestNumber + 1];

                if (visualize == 1)
                {
                    Console.Clear();
                    printarray(arr, "Original Array");
                    printarray(Index, "Index Array");
                    Thread.Sleep(Convert.ToInt32(delay));
                }
                if (visualize == 3)
                {
                    printarray(Index, "Index Array");
                    Thread.Sleep(stagedelay);
                }

                SetIndexValues();
            }
            void SetIndexValues()
            {
                for (long i = 0; i < arr.Length; i++)
                {
                    Calculations++;
                    currentValue = arr[i];
                    Index[currentValue]++;

                    if (visualize == 1)
                    {
                        Console.Clear();
                        printarray(arr, "Original Array");
                        printarray(Index, "Index Array");
                        Thread.Sleep(Convert.ToInt32(delay));
                    }
                }

                if (visualize == 3)
                {
                    printarray(Index, "Index Array, values set");
                    Thread.Sleep(stagedelay);
                }

                CompleteIndex();
            }
            void CompleteIndex()
            {
                for (long b = 1; b < Index.Length; b++)
                {
                    Calculations++;
                    Index[b] += Index[b - 1];

                    if (visualize == 1)
                    {
                        Console.Clear();
                        printarray(arr, "Original Array");
                        printarray(Index, "Index Array");
                        Thread.Sleep(Convert.ToInt32(delay));
                    }
                }

                if (visualize == 3)
                {
                    printarray(Index, "Index Array, finalized");
                    Thread.Sleep(stagedelay);
                }

                CreatePlaces();
            }
            void CreatePlaces()
            {
                Places = new long[arr.Length];
                if (visualize == 1)
                {
                    Console.Clear();
                    printarray(arr, "Original Array");
                    printarray(Index, "Index Array");
                    printarray(Places, "Places Array");
                    Thread.Sleep(Convert.ToInt32(delay));
                }
                if (visualize == 3)
                {
                    printarray(Places, "Place Array");
                }

                for (long i = 0; i < arr.Length; i++)
                {
                    Calculations++;
                    indexplace = arr[i];
                    Calculations++;
                    numberplace = Index[indexplace];

                    //Minus Index
                    Calculations++;
                    Index[indexplace]--;

                    Calculations++;
                    Places[numberplace - 1] = arr[i];

                    if (visualize == 1)
                    {
                        Console.Clear();
                        printarray(arr, "Original Array");
                        printarray(Index, "Index Array");
                        printarray(Places, "Places Array");
                        Thread.Sleep(Convert.ToInt32(delay));
                    }
                }
                if (visualize == 3)
                {
                    printarray(Places, "Places Array, done");
                    Thread.Sleep(stagedelay);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                PlacesToArrConvert();
            }
            void PlacesToArrConvert()
            {
                sortedArr = new long[arr.Length];
                for(long i = 0; i < arr.Length; i++)
                {
                    sortedArr[i] = Places[i];
                }
            }

            void StartCountSorting()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                CreateIndex();
            }
            if (visualize == 1)
            {
                Console.Clear();
                printarray(arr, "Original Array");
                Console.WriteLine(HighestNumber + "\n\n");
                printarray(Index, "Index Array");
                printarray(Places, "Places Array");
                printarray(sortedArr, "Sorted Array");
            }
            SW.Stop();
            Console.WriteLine("\nDone!" +
                "\nComputer calculations: " + Calculations +
                "\n" + "Elapsed time: " + SW.ElapsedMilliseconds + "ms" +
                "\nPress Enter to Exit");
            Console.ReadKey();
        }
    }
}
