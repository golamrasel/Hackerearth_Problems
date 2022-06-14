using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Char_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string C = Console.ReadLine();
            char[] charArry = C.ToCharArray();
            int Z = 0;
            
            for(int i = 0; i < C.Length; i++)
            {
                Z =  Z + ((int)C[i] - 96);
            }
            Console.WriteLine(Z);
            Console.ReadKey();

        }
    }
}
