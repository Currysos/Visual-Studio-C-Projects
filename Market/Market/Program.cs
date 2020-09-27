using System;
using System.Collections.Generic;

namespace Market
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<Costumer> Costumers = new List<Costumer>();
            int input;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Welcome to this Supermarket");
                Console.WriteLine("---------------------------");
                Console.WriteLine("\n\n");
                Console.WriteLine("What do you want to do?");
                Console.WriteLine(" 1. Add Costumer");
                Console.WriteLine(" 2. Replace Costumer");
                Console.WriteLine(" 3. Print costumers");
                Console.WriteLine(" 4. Print specific costumer order");
                Console.WriteLine(" 5. EXIT");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 5)
                {
                    break;
                }

                switch (input)
                {
                    case 1:
                        AddCostumer();
                        break;

                    case 2:
                        EditCostumer();
                        break;

                    case 3:
                        PrintCostumers();
                        break;

                    case 4:
                        PrintCostumerOrder();
                        break;
                }
            } while (true);

            Console.Clear();
            Console.WriteLine("Thank you, please comee again!");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Reciept:");
            for (int i = 0; i < Costumers.Count; i++)
            {
                Console.WriteLine(Costumers[i].GetName());

                List<Product> CurrentProducts = Costumers[i].GetProducts();
                for (int a = 0; a < CurrentProducts.Count; a++)
                {
                    Console.WriteLine("     --" + CurrentProducts[a].GetName());
                    Console.WriteLine("     --" + CurrentProducts[a].GetCost());
                    Console.WriteLine("     ----------------------");
                }

                Console.WriteLine("---------------------------");
            }

            void AddCostumer()
            {
                Console.Clear();
                Costumers.Add(MakeCostumer());

                Console.WriteLine("Add another costumer? \n 1. Yes \n   2. No");
                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    AddCostumer();
                }
                return;
            }

            Costumer MakeCostumer()
            {
                Console.Clear();
                Costumer CurrentCostumer = new Costumer();

                Console.WriteLine("Enter costumer name:");
                CurrentCostumer.SetName(Console.ReadLine());

                do
                {
                    Console.WriteLine("Enter product name:");
                    string CurrentProductName = Console.ReadLine();
                    Console.WriteLine("Enter product cost");
                    int CurrentProductCost = Convert.ToInt32(Console.ReadLine());

                    CurrentCostumer.AddProduct(CurrentProductName, CurrentProductCost);

                    Console.WriteLine("Add another product? \n  1. Yes \n   2. No");
                    input = Convert.ToInt32(Console.ReadLine());

                    if (input != 1)
                    {
                        break;
                    }
                } while (true);

                return CurrentCostumer;
            }

            void EditCostumer()
            {
                Console.Clear();

                for (int i = 0; i < Costumers.Count; i++)
                {
                    Console.WriteLine(i + ": " + Costumers[i].GetName());
                }

                Console.WriteLine("---------------------------");

                Console.WriteLine("What Costumer?");
                input = Convert.ToInt32(Console.ReadLine());
                Costumers[input] = MakeCostumer();
                return;
            }

            void PrintCostumers()
            {
                Console.Clear();
                for (int i = 0; i < Costumers.Count; i++)
                {
                    Console.WriteLine(i + ": " + Costumers[i].GetName());
                }

                Console.WriteLine("Press ENTER to go back");
                Console.ReadKey();

                return;
            }

            void PrintCostumerOrder()
            {
                Console.Clear();

                for (int i = 0; i < Costumers.Count; i++)
                {
                    Console.WriteLine(i + ": " + Costumers[i].GetName());
                }

                Console.WriteLine("---------------------------");

                Console.WriteLine("What Costumer?");
                input = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Costumers[input].PrintProducts();

                Console.WriteLine("Press ENTER to go back");
                Console.ReadKey();
                return;
            }
        }
    }
}