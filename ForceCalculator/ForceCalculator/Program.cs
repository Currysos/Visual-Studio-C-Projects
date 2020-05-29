using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceCalculator
{
    [Serializable]
    public class Force
    {
        float Size;
        float Angle;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int ForceCount = Convert.ToInt32(Console.ReadLine());
            Force[] Forces = new Force[ForceCount];
        }
    }
}
