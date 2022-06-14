using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Its_Magic
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            string[] data = Console.ReadLine().ToString().Split(' ');

            long min = 1000000000;
            int index = -1;
            long sum = 0;

            for(int i = 0; i < data.Length; i++)
            {
                sum += Convert.ToInt32(data[i]);
            }

            for(int j = 0; j < data.Length; j++)
            {
               if((sum - int.Parse(data[j])) % 7 == 0 && min > int.Parse(data[j]))
                {
                    min = int.Parse(data[j]);
                    index = j;
                }
            }
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
