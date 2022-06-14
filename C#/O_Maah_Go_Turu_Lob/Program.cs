using System;

namespace O_Maah_Go_Turu_Lob
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if ((input.Contains('a')) && (input.Contains('e')) && (input.Contains('i')) && (input.Contains('o')) && (input.Contains('u')) ||
                    (input.Contains('A')) && (input.Contains('E')) && (input.Contains('I')) && (input.Contains('O')) && (input.Contains('U')))
                    Console.WriteLine("lovely string");
                else
                    Console.WriteLine("ugly string");
            }
            Console.ReadKey();
        }
    }
}
