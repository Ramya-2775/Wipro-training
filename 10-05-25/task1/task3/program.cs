using System;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            double rectanglearea= Area_calculation.area(6.6, 7.6);
            double circlearea = Area_calculation.area(9.0);

            Console.WriteLine("Area of rectangle = " + rectanglearea);
            Console.WriteLine("Area of circle = " + circlearea);

        }
    }
}