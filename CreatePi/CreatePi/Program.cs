using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePI
{
    //Create object 1
    [Serializable]
    public class Object1
    {
        public double mass;
        public double v;
        public double position;
    }

    //Create object 2
    [Serializable]
    public class Object2
    {
        public double mass;
        public double v;
        public double position;
    }

    class Program
    {

        static void Main(string[] args)
        {
            long count = 0;


            Object1 obj1 = new Object1();
            Object2 obj2 = new Object2();

            Console.WriteLine("How many digits? \n");
            long digits = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\nHow much timestep? \n");
            long TimeStep = Convert.ToInt64(Console.ReadLine());

            obj1.mass = Math.Pow(100, digits - 1);
            obj1.v = 1;
            obj1.position = 0;

            obj2.mass = 1;
            obj2.v = 0;
            obj2.position = 3;

            double WallPos = 100;

            double percentToDone = 0;

            //Creating Variables
            double u1;
            double u2;

            double msub;
            double msubInverted;
            double madd;
            double TimesMass2;
            double TimesMass1;

            bool isDone = false;

            int IsDoneCount = 0;

            for (; ; )
            {
                if(IsDoneCount >= 50)
                {
                    if(TimeStep == 0)
                    {
                        TimeStep = 100;
                    }
                    if(IsDoneCount == 100)
                    {
                        break;
                    }
                }

                if (Math.Pow(obj1.v, 2) > Math.Pow(obj2.v, 2))
                {
                    isDone = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    IsDoneCount++;
                }
                else
                {
                    isDone = false;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                for (long i = 0; i < TimeStep + 1; i++)
                {
                    //call move function
                    obj1.position += obj1.v;
                    obj2.position += obj2.v;

                    //Check if objects hit
                    if (obj1.position >= obj2.position)
                    {
                        //Call bounce function
                        bounce();
                    }

                    //Check if object hits wall
                    if (obj2.position >= WallPos)
                    {
                        //Change Velocity
                        obj2.v = -obj2.v;

                        //Add count and display counts
                        count++;
                    }
                }

                WriteConsole();

                void WriteConsole()
                {
                    Console.Clear();
                    Console.WriteLine("Object1 Velocity: " + obj1.v + "    Object2 Velocity: " + obj2.v);
                    Console.WriteLine("Object1 Position: " + obj1.position + "    Object2 Position: " + obj2.position);
                    Console.WriteLine("Hits: " + count);

                    percentToDone = 100 - (100 * ((obj1.v + 1) / 2));
                    Console.WriteLine(Math.Round(percentToDone) + "% Done");

                    if (isDone == true)
                    {
                        Console.WriteLine("\n\nDoublechecking if done...");
                        Console.WriteLine(IsDoneCount + "%");
                        Thread.Sleep(40);
                    }
                    Thread.Sleep(10);
                }
                //Bounce function
                void bounce()
                {
                    //Set old velocities
                    u1 = obj1.v;
                    u2 = obj2.v;

                    //Calculate new velocities
                    msub = obj1.mass - obj2.mass;
                    msubInverted = obj2.mass - obj1.mass;
                    madd = obj1.mass + obj2.mass;
                    TimesMass2 = 2 * obj2.mass;
                    TimesMass1 = 2 * obj1.mass;

                    obj1.v = ((msub / madd * u1)) + ((TimesMass2 / madd) * u2);
                    obj2.v = ((TimesMass1 / madd) * u1 + (msubInverted / madd) * u2);

                    //Add count and display counts
                    count++;
                }
            }

            Console.WriteLine("\n\nDone!");
            Console.ReadKey();
        }
    }
}
