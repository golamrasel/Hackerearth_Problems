using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numWork = int.Parse(Console.ReadLine());
            for (int i = 0; i < numWork; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int SH = Convert.ToInt32(input[0]); // Starting Houre
                int SM = Convert.ToInt32(input[1]); // Starting Min
                int EH = Convert.ToInt32(input[2]); // Ending Houre
                int EM = Convert.ToInt32(input[3]); // Ending Min

                int difference = (EH * 60 + EM) - (SH * 60 + SM);
                int workHoure = difference / 60;
                int workMin = difference % 60;

                Console.WriteLine(workHoure + " " + workMin);

            }
            Console.ReadKey();
        }
    }
}
