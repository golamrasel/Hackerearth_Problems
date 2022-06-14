using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goki_and_his_breakup
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfFriends = Convert.ToInt32(Console.ReadLine());
            int minimumskills = Convert.ToInt32(Console.ReadLine());
            int[] friends = new int[numberOfFriends];

            for(int i = 0; i<numberOfFriends; i++)
            {
                friends[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<numberOfFriends; i++)
            {
                if(friends[i] >= minimumskills)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            Console.ReadKey();
        }
    }
}
