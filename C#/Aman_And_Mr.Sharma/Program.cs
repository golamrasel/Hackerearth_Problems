using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aman_And_Mr.Sharma
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 0; i < input; i++)
            {
                string[] sr = Console.ReadLine().Split(' ');

                int r = Convert.ToInt32(sr[0]);
                int s = Convert.ToInt32(sr[1]);

                decimal radiusOfaCircle = (decimal)2 * (22.0m / 7.0m) * r;
                decimal running = (decimal) 100 * s;

                if (running >= radiusOfaCircle)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
