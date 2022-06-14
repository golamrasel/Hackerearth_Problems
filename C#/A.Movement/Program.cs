using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A.Movement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Position of his Friends
            int position = Convert.ToInt32(Console.ReadLine());
            int Result1 = position / 5;
            int Result2 = 0;
            
            if((position % 5 < 5) && (position % 5 != 0))
            {
                Result2 = 1;
            }
            Console.WriteLine(Result1 + Result2);
            Console.ReadKey();
        }
    }
}
