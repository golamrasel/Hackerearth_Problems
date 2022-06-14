using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            long result = 0, count;

            while(input != 0) { 

                string[] arr = Console.ReadLine().Split(' ');
                var a = int.Parse(arr[0]);
                var b = int.Parse(arr[1]);
                var c = int.Parse(arr[2]);

                count = System.Math.Abs(2 * b - (a + c));
                if(count / 2 == 0)
                {
                    result = count / 2;
                }
                else
                {
                    result = count / 2 + 1;
                }
                input--;
            }
            Console.WriteLine(result);
            //int noOfTestcases = int.Parse(Console.ReadLine());
            //long result, time;
            //var output = new StringBuilder();
            //for (int i = 0; i < noOfTestcases; i++)
            //{
            //    string[] arr = Console.ReadLine().Split(' ');
            //    var a = int.Parse(arr[0]);
            //    var b = int.Parse(arr[1]);
            //    var c = int.Parse(arr[2]);

            //    result = a - 2 * b + c;
            //    if (result < 0)
            //    {
            //        result *= -1;
            //    }

            //    time = result / 2;

            //    time += result % 2;
            //    output.AppendLine(time.ToString());
            //}
            //Console.WriteLine(output.ToString());



            //int n = int.Parse(Console.ReadLine());
            //string[] strArray = Console.ReadLine().Split(' ');
            //int[] intArray = Array.ConvertAll(strArray, int.Parse);

            //string isDivisible = intArray[n - 1] % 10 == 0 ? "Yes" : "No";
            //Console.WriteLine(isDivisible);


            //int numOfTestCases = int.Parse(Console.ReadLine());
            //StringBuilder res = new StringBuilder();
            //while (numOfTestCases-- > 0)
            //{
            //    string[] rates = Console.ReadLine().Split(" ");
            //    int participants = int.Parse(Console.ReadLine()); ;
            //    int green = 0;
            //    int purple = 0;
            //    while (participants-- > 0)
            //    {
            //        string userStatusStr = Console.ReadLine();
            //        string[] userStatus = userStatusStr.Split(" ");
            //        green += int.Parse(userStatus[0]);
            //        purple += int.Parse(userStatus[1]);
            //    }
            //    res.Append(Math.Min((green * int.Parse(rates[0]) + purple * int.Parse(rates[1])), (green * int.Parse(rates[1]) + purple * int.Parse(rates[0]))) + "\n");
            //}
            //Console.WriteLine(res.ToString());


            //int t = Convert.ToInt32(Console.ReadLine());
            //int Z = 0,Y = 0;
            //for (int s = 0; s < t; s++)
            //{
            //    string[] ab = Console.ReadLine().Split(' ').ToArray();
            //    string a = ab[0];
            //    string b = ab[1];

            //    for (int i = 0; i < a.Length; i++)
            //    {
            //        Z += (char)a[i] - 96;
            //    }
            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        Y += (char)b[i] - 96;
            //    }
            //    bool equal = true;

            //    if (Z != Y)
            //    {
            //        equal = false;
            //    }
            //    if (equal)
            //    {
            //        Console.WriteLine("YES");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //    }
            //}
            Console.ReadKey();

        }
    }
}
