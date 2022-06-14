using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_String
{
    class Program
    {
        static void Main(string[] args)
        {
            int MAX_CHAR = 26;
            int n = int.Parse(Console.ReadLine());
            int[] countS1 = new int[MAX_CHAR];
            int[] countS2 = new int[MAX_CHAR];

            for (int j = 0; j < n; j++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string S1 = input[0];
                string S2 = input[1];
                bool equal = true;

                for (int i = 0; i < MAX_CHAR; i++)
                {
                    countS1[i] = 0;
                    countS2[i] = 0;
                }
                for (int i = 0; i < S1.Length; i++)
                {
                    char xS1 = S1[i];
                    char xS2 = S2[i];
                    ++countS1[xS1 - 'a'];
                    ++countS2[xS2 - 'a'];
                }
                for (int i = 0; i < MAX_CHAR; i++)
                {
                    if (countS1[i] != countS2[i])
                    {
                        equal = false;
                        break;
                    }
                }
                if (equal)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadKey();
        }
    }
}
