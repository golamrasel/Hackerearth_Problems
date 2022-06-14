using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ladderophilia
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*   *");
            Console.WriteLine("*   *");

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine("*****");
                Console.WriteLine("*   *");
                Console.WriteLine("*   *");
            }
            Console.ReadKey();
        }
    }
}
