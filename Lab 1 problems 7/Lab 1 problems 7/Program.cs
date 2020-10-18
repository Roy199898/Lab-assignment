using System;

namespace Lab_1_problems_7
{
    class Program
    {
        static void Main(string[] args)
        {

            double width = 5.6;
            double height = 8.5;
            double area, perimeter;
            area = height * width;
            perimeter = 2 * (height + width);
            Console.WriteLine(area);
            Console.WriteLine(perimeter); ;
        }
    }
}
