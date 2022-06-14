using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int x = input, result = input;

            for(int i = 1; i < input; i++)
            {
                x--;
                result *= x;
            }
            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
