using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lift_queries
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, data, leftA = 0, leftB = 7, a, b;
            input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                data = Convert.ToInt32(Console.ReadLine());
                a = System.Math.Abs(leftA - data);
                b = System.Math.Abs(leftB - data);

                if (a <= b)
                {
                    Console.WriteLine("A");
                    leftA = data;
                }
                else
                {
                    Console.WriteLine("B");
                    leftB = data;
                }
            }
            Console.ReadKey();
        }
    }
}
