using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_maze_in
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            string command = Console.ReadLine();

            foreach(char item in command)
            {
                switch (item)
                {
                    case 'L':
                        x--;
                        break;
                    case 'R':
                        x++;
                        break;
                    case 'D':
                        y--;
                        break;
                    case 'U':
                        y++;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(x + " " + y);
            Console.ReadKey();
        }
    }
}
