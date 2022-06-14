using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roy_and_Profile_Picture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Length of picture
            int L = Convert.ToInt32(Console.ReadLine());
            //Number of picture
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                //width and hight of picture
                string[] WH = Console.ReadLine().Split(' ');
                int W = Convert.ToInt32(WH[0]);
                int H = Convert.ToInt32(WH[1]);

                if (W < L || H < L)
                {
                    Console.WriteLine("UPLOAD ANOTHER");
                }
                else if (W == H && W == L)
                {
                    Console.WriteLine("ACCEPTED");
                }
                else if (W == H && (W > L || H > L))
                {
                    Console.WriteLine("ACCEPTED");
                }
                else if (W > L || H > L)
                {
                    Console.WriteLine("CROP IT");
                }
            }
            Console.ReadKey();
        }
    }
}
