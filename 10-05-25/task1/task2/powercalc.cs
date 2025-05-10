using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class powercalculation
    {
        public static double Power(int basevalue, int exponent)
        {
            return Math.Pow(basevalue, exponent);  
        }

        public static double power(double basevalue, double exponent)
        {
            return Math.Pow(basevalue, exponent);
        }
    }
}
