using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] intArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int isDivisible = intArray[n - 1] % 10;
            if (isDivisible == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.ReadKey();
        }
    }
}
