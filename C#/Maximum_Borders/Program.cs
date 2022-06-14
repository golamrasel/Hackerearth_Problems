using System;

namespace Maximum_Borders
{
    class Program
    { 
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine()); //number of test cases

            while (T > 0)
            {
                //Read grid details
                string[] gridDetail = Console.ReadLine().Split(' ');
                int rows = int.Parse(gridDetail[0]);
                int columns = int.Parse(gridDetail[1]);
                bool[,] grid = new bool[rows, columns];
                int mb = 0; //Maximum border

                //Scan grid
                for (int i = 0; i < rows; i++)
                {
                    string line = Console.ReadLine();
                    for (int j = 0; j < columns; j++)
                    {
                        grid[i, j] = line[j] == '#';
                    }
                }

                //Check horizontally
                for (int i = 0; i < rows; i++)
                {
                    int ct = 0; //continue top
                    int cb = 0; //continue bottom

                    for (int j = 0; j < columns; j++)
                    {
                        if (grid[i, j]) //if black
                        {
                            if (i == 0 || !grid[i - 1, j]) //If first row or above cell is white
                            {
                                ct++;
                            }
                            else
                            {
                                if (ct > mb)
                                {
                                    mb = ct;
                                }
                                ct = 0;
                            }
                            if (i == rows - 1 || !grid[i + 1, j]) //If last row or below cell is white
                            {
                                cb++;
                            }
                            else
                            {
                                if (cb > mb)
                                {
                                    mb = cb;
                                }
                                cb = 0;
                            }
                        }
                        else
                        {
                            if (ct > mb)
                            {
                                mb = ct;
                            }
                            if (cb > mb)
                            {
                                mb = cb;
                            }

                            ct = 0;
                            cb = 0;
                        }
                    }
                }

                //Check vertically
                for (int i = 0; i < columns; i++)
                {
                    int cl = 0; //continue left
                    int cr = 0; //continue right

                    for (int j = 0; j < rows; j++)
                    {
                        if (grid[j, i]) //if black
                        {
                            if (i == 0 || !grid[j, i - 1]) //If first row or above cell is white
                            {
                                cl++;
                            }
                            else
                            {
                                if (cl > mb)
                                {
                                    mb = cl;
                                }
                                cl = 0;
                            }
                            if (i == columns - 1 || !grid[j, i + 1]) //If last row or below cell is white
                            {
                                cr++;
                            }
                            else
                            {
                                if (cr > mb)
                                {
                                    mb = cr;
                                }
                                cr = 0;
                            }
                        }
                        else
                        {
                            if (cl > mb)
                            {
                                mb = cl;
                            }
                            if (cr > mb)
                            {
                                mb = cr;
                            }

                            cl = 0;
                            cr = 0;
                        }
                    }
                }

                Console.WriteLine(mb);

                T--;
            }
        }
    }
}