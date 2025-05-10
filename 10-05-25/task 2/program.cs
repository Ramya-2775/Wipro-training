using System;
namespace ConsoleApp1
{
    public class program
    {
        public static void Main(string[] args)
        {
            int intresult = (int)powercalculation.power(2, 3);
            double doubleresult = powercalculation.power(3.3, 6);

            Console.WriteLine("2^3 = " + intresult);
            Console.WriteLine("3.3^6 = " + doubleresult);

        }
    }
}