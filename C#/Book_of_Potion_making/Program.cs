using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_of_Potion_making
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sum = 0, x = 1;
            char[] inputChar;

            if(input.Length == 10)
            {
                inputChar = input.ToCharArray();

                foreach(var item in inputChar)
                {
                    if (char.IsDigit(item))
                    {
                        sum += item * x;
                    }
                    else
                    {
                        Console.WriteLine("Illegal ISBN");
                        break;
                    }
                    x++;
                }

                if(sum % 11 == 0)
                {
                    Console.WriteLine("Legal ISBN");
                }
                else
                {
                    Console.WriteLine("Illegal ISBN");
                }
            }
            else
            {
                Console.WriteLine("Illegal ISBN");
            }
           
            Console.ReadKey();

        }
    }
}
