using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Divisors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int l = Convert.ToInt32(input[0]);
            int r = Convert.ToInt32(input[1]);
            int k = Convert.ToInt32(input[2]);
            int count = 0;

            for(int i = l; i <= r; i++)
            {
                if (i % k == 0)
                    count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
