using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Progression
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            long result = 0, count;

            while (input != 0)
            {
                string[] arr = Console.ReadLine().Split(' ');
                var a = int.Parse(arr[0]);
                var b = int.Parse(arr[1]);
                var c = int.Parse(arr[2]);

                count = System.Math.Abs(2 * b - (a + c));
               
                result = count / 2;
                result += count % 2;
                input--;
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
