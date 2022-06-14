using System;

namespace Number_of_stepss
{
    class Program
    {
        static void Main(string[] args)
        {
            int ln = int.Parse(Console.ReadLine());
            int[] input1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] input2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int min = 0, steps = 0, x = 0;

            min = input1[0];

            for (int i = 1; i < ln; i++)
            {
                if (input1[i] < min)
                    min = input1[i];
            }

            for (int i = 0; i < ln; i++)
            {
                while(input1[i] > min && input2[i] != 0)
                {
                    input1[i] -= input2[i];
                    ++steps;
                }

                if (input1[i] < 0)
                {
                    x = 1;
                    break;
                }

                if (input1[i] < min)
                {

                    min = input1[i];
                    i = -1;

                }
            }
            if(x != 1)
                Console.WriteLine(steps);
            else
                Console.WriteLine("-1");
            Console.ReadKey();
        }
    }
}
