using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctors_Secret
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            if (inputs[0] <= 23 && inputs[1] >= 500 && inputs[1] <= 1000)
            {
                Console.WriteLine("Take Medicine");
            }
            else
            {
                Console.WriteLine("Don't take Medicine");
            }

            Console.ReadKey();
        }
    }
}
