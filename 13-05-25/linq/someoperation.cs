using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq.projects
{
    internal class delegatesum
    {
        class simpledelegate

        {
            public delegate int someOperation(int a, int b);
            class program
            {
                static int sum (int a, int b)
                {
                    return a + b;
                }

                static void Main(string[] args)
                {
                    someOperation add = sum;
                    int result = add(8, 9);
                    Console.WriteLine(result);
                }
            }
        }
    }
}
