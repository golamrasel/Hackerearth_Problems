using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends_Relationship
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int data = 0,I = 0,J = 0,K = 0;

            for (int i = 0; i < input; i++)
            {
                data = int.Parse(Console.ReadLine());
                for (int j = 0; j < data; j++)
                {
                    J = j; 
                    for (int k = 0; k <= j; k++)
                    {
                        K = k;
                        Console.Write("*");
                    }
                    for (int k = 0; k < (data - (j + 1)); k++)
                    {
                        K = k;
                        Console.Write("##");
                    }
                    for (int k = 0; k <= j; k++)
                    {
                        K = k;
                        Console.Write("*");
                    }
                    Console.Write(Environment.NewLine);
                }
                Console.Write(Environment.NewLine);


            }
            Console.ReadKey();
        }
    }
}
