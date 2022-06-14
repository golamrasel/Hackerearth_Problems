using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toggle_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            for(int i = 0; i < input.Length; i++)
            {
                if(input[i] >= 'a' && input[i] <= 'z')
                {
                    result += (char) (input[i] - 32);
                }
                else if(input[i] >= 'A' && input[i] <= 'Z')
                {
                    result += (char) (input[i] + 32);
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
