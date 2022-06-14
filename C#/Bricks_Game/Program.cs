using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Total Number of bricks
            int x = Convert.ToInt32(Console.ReadLine());
            int i = 1;
             
            while(x > 0)
            {
                if (i >= x)
                {
                    Console.WriteLine("Patlu");
                    break;
                }

                else
                {
                    x = x - i;// Present number of bricks
                    if (i * 2 >= x)
                    {
                        Console.WriteLine("Motu");
                        break;
                    }
                    else
                    {
                        x = x - (i * 2); // Motu puts x bricks.
                    }
                }
                i++;
            } 
            Console.ReadKey();
        }
    }
}
