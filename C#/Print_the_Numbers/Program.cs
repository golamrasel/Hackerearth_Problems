using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_the_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int data = Convert.ToInt32(Console.ReadLine());
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
