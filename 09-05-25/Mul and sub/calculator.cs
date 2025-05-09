using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        //multiplication
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public double Mul(double a, double b)
        {
            return a * b;
        }
        public int Mul(int a, int b, int c)
        {
            return a * b * c;
        }

        //Subtraction
        public int sub(int a, int b)
        {
            return a -  b;
        }
        public double sub(double a, double b)
        {
            return a - b;
        }
        public int sub(int a, int b, int c)
        {
            return a - b - c;
        }
    }
}
