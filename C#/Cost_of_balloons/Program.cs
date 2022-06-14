using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cost_of_balloons
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCase = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < testCase; i++)
            {
                string[] colors = Console.ReadLine().Split(' ');
                int colorOne = int.Parse(colors[0]);
                int colorTwo = int.Parse(colors[1]);

                int participant = int.Parse(Console.ReadLine());
                int one = 0;
                int two = 0;

                for (int j = 0; j < participant; j++)
                {
                    string[] solvedBy = Console.ReadLine().Split();
                    if (int.Parse(solvedBy[0]) == 1)
                    {
                        one++;
                    }
                    if (int.Parse(solvedBy[1]) == 1)
                    {
                        two++;
                    }
                }
                int oneOne = one * colorOne;
                int twoTwo = two * colorTwo;

                int twoOne = two * colorOne;
                int oneTwo = one * colorTwo;

                result.Append(Math.Min((oneOne + twoTwo), (twoOne + oneTwo)) + "\n");
            }
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
