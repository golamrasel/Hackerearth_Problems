using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int data = input.Max();
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
