using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;

namespace MachineLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary n = new ClassLibrary();

            n.Print("Hello World");
            int a = 3;
            string b = n.ToString(a);
            n.Print(b);

            Console.WriteLine("Hello World");
            int c = 5;
            string d = Convert.ToString(c);
            Console.WriteLine(d);
        }
    }
}
