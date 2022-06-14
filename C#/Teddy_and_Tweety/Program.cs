using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teddy_and_Tweety
{
    class Program
    {
        static void Main(string[] args)
        {

            int Chocolet = Convert.ToInt32(Console.ReadLine());

            if (Chocolet % 3 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
            Console.ReadKey();
        }
    }
}
