using System;

namespace Anagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int x = 0; x < t; x++)
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                int output = 0, count = 0;

                for (int i = 0; i < input1.Length; i++)
                {

                    for (int j = 0; j < input2.Length; j++)
                    {
                        if (input1[i] == input2[j])
                        {
                            ++count;
                            input2 = input2.Remove(j, 1).Insert(j, "0");
                            break;
                        }
                    }
                }
                output = (input1.Length + input2.Length) - (count * 2);
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    }
}
