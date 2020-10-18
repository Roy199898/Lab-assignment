using System;

namespace Lab2_problems8
{
    class Program
    {
        static void Main(string[] args)
        {
            string p, c, b, m, co;

            Console.WriteLine("Enter Marks of OOP2 :");
            p = Console.ReadLine();
            double ph = Convert.ToDouble(p);
            Console.WriteLine("Enter Marks of DATA COM :");
            c = Console.ReadLine();
            double ch = Convert.ToDouble(c);
            Console.WriteLine("Enter Marks of AI :");
            b = Console.ReadLine();
            double bi = Convert.ToDouble(b);
            Console.WriteLine("Enter Marks of COMPUTER GRAPHICS :");
            m = Console.ReadLine();
            double ma = Convert.ToDouble(m);
            Console.WriteLine("Enter Marks of COMPUTER NETWORK :");
            co = Console.ReadLine();
            double com = Convert.ToDouble(co);

            if (ph >= 90 && ph <= 100)
            {
                Console.WriteLine("Grade of OOP2 : A+");
            }
            else if (ph >= 85 && ph <= 89)
            {
                Console.WriteLine("Grade of OOP2 : A");
            }
            else if (ph >= 80 && ph <= 84)
            {
                Console.WriteLine("Grade of OOP2 : B+");
            }
            else if (ph >= 75 && ph <= 79)
            {
                Console.WriteLine("Grade of OOP2 : B");
            }
            else if (ph >= 50 && ph <= 74)
            {
                Console.WriteLine("Grade of OOP2 : C+");
            }
            else if (ph < 50)
            {
                Console.WriteLine("Grade of OOP2 : F");
            }

            // Data Com 
            if (ch >= 90 && ch <= 100)
            {
                Console.WriteLine("Grade of DATA COM : A+");
            }
            else if (ch >= 85 && ch <= 89)
            {
                Console.WriteLine("Grade of DATA COM  : A");
            }
            else if (ch >= 80 && ch <= 84)
            {
                Console.WriteLine("Grade of DATA COM  : B+");
            }
            else if (ch >= 75 && ch <= 79)
            {
                Console.WriteLine("Grade of DATA COM  : B");
            }
            else if (ch >= 50 && ch <= 74)
            {
                Console.WriteLine("Grade of DATA COM : C+");
            }
            else if (ch < 50)
            {
                Console.WriteLine("Grade of DATA COM : F");
            }

            // AI 
            if (ma >= 90 && ma <= 100)
            {
                Console.WriteLine("Grade of AI : A+");
            }
            else if (ma >= 85 && ma <= 89)
            {
                Console.WriteLine("Grade of AI : A");
            }
            else if (ma >= 80 && ma <= 84)
            {
                Console.WriteLine("Grade of AI : B+");
            }
            else if (ma >= 75 && ma <= 79)
            {
                Console.WriteLine("Grade of AI : B");
            }
            else if (ma >= 50 && ma <= 74)
            {
                Console.WriteLine("Grade of AI : C+");
            }
            else if (ma < 50)
            {
                Console.WriteLine("Grade of AI: F");
            }

            //computer network

            if (bi >= 90 && bi <= 100)
            {
                Console.WriteLine("Grade of COMPUTER NETWORKS : A+");
            }
            else if (bi >= 85 && bi <= 89)
            {
                Console.WriteLine("Grade of COMPUTER NETWORKS : A");
            }
            else if (bi >= 80 && bi <= 84)
            {
                Console.WriteLine("Grade of COMPUTER NETWORKS : B+");
            }
            else if (bi >= 75 && bi <= 79)
            {
                Console.WriteLine("Grade of COMPUTER NETWORKS : B");
            }
            else if (bi >= 50 && bi <= 74)
            {
                Console.WriteLine("Grade of COMPUTER NETWORKS : C+");
            }
            else if (bi < 50)
            {
                Console.WriteLine("Grade of COMPUTER NETWORKS : F");
            }

            // computer  graphics
            if (com >= 90 && com <= 100)
            {
                Console.WriteLine("Grade of  COMPUTER GRAPHICS : A+");
            }
            else if (com >= 85 && com <= 89)
            {
                Console.WriteLine("Grade of COMPUTER GRAPHICS : A");
            }
            else if (com >= 80 && com <= 84)
            {
                Console.WriteLine("Grade of COMPUTER GRAPHICS : B+");
            }
            else if (com >= 75 && com <= 79)
            {
                Console.WriteLine("Grade of COMPUTER GRAPHICS : B");
            }
            else if (com >= 50 && com <= 74)
            {
                Console.WriteLine("Grade of COMPUTER GRAPHICS : C+");
            }
            else if (com < 50)
            {
                Console.WriteLine("Grade of COMPUTER GRAPHICS : F");
            }


        }
    }
}
