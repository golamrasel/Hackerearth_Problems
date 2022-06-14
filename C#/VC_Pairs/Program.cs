using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VC_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int len = 0;
            string s = "";
            char[] v = { 'a', 'e', 'i', 'o', 'u' };
            int result = 0;
            while (n > 0)
            {
                len = Convert.ToInt32(Console.ReadLine());
                s = Console.ReadLine();
                result = 0;
                for (int i = 0; i < len; i++)
                {
                    if (Array.IndexOf(v, s[i]) > -1 && i > 0 && Array.IndexOf(v, s[i - 1]) == -1)
                    {
                        result++;
                    }
                }
                Console.WriteLine(result);

                n--;
            }
            Console.ReadKey();
        }
    }
}
