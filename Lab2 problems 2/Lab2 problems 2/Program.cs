using System;

namespace Lab2_problems_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 0;
            for (int x = 0; x < 4; x++)
            {
                if (l % 2 == 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("XO");

                    }
                    Console.WriteLine();
                    l++;

                }
                else
                {
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("OX");
                    }
                    Console.WriteLine();
                    l++;
                }
            }
        }
    }
}
