using System;

namespace Seven_Segment_Display
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                int x = 0;
                int y = (input.Length) - 1;
                while (y >= 0)
                {
                    if ((input[y] == '0') || (input[y] == '6') || (input[y] == '9'))
                        x = x + 6;
                    else
                    {
                        if (input[y] == '1')
                            x = x + 2;
                        else
                        {
                            if ((input[y] == '2') || (input[y] == '3') || (input[y] == '5'))
                                x = x + 5;
                            else
                            {
                                if (input[y] == '7')
                                    x = x + 3;
                                else
                                {
                                    if (input[y] == '8')
                                        x = x + 7;
                                    else
                                        if (input[y] == '4')
                                        x = x + 4;
                                }
                            }
                        }
                    }
                    y--;
                }
                if (x % 2 == 1)
                {
                    Console.Write(7);
                    x = x - 3;
                }
                for (int j = 1; j <= x / 2; j++)
                    Console.Write(1);
                Console.WriteLine();
            }
        }
    }
}
