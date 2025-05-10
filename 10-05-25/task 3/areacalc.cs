using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Area_calculation
    {
        public static double area(double length, double breadth)
        {
            return length*breadth;
        }

        public static double area(double radius)
        {
            return Math.PI*radius;
        }
    }
}
