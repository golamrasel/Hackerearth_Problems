using System;
using System.Collections.Generic;
using System.Text;

namespace Divisible
{
    class Program
    {
        static int remainder(string str)
        {
            int len = str.Length;

            int rem = 0;

            for (int i = 0; i < len; i++)
            {
                rem = (rem * 10 + (int)str[i] - '0') % 11;
            }
            return rem;
        }
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var intArray = Console.ReadLine().Split(' ');
            StringBuilder LastAndFirstNum = new StringBuilder();
            for (int i = 0; i < n / 2; i++)
            {
                var firstNumber = intArray[i][0];
                LastAndFirstNum.Append(firstNumber);
            }
            for (int i = n / 2; i < n; i++)
            {
                var lastNumber = intArray[i][intArray[i].Length - 1];
                LastAndFirstNum.Append(lastNumber);
            }
            if (remainder(LastAndFirstNum.ToString()) == 0)
                Console.WriteLine("OUI");
            else
                Console.WriteLine("NON");

            Console.ReadKey();

        }
    }
}
