using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life_the_Universe_and_Everything
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            while(input != 42)
            {
                Console.WriteLine(input);
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
