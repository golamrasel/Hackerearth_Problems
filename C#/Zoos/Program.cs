using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoos
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            int z = 0, o = 0;

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] == 'z')
                {
                    z++;
                }
                else if (inputs[i] == 'o')
                {
                    o++;
                }
            }
            if (z * 2 == o)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
