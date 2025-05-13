using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq.projects
{
    internal class delegates
    {
        delegate void customdel(string s);
        class testclass
        {
            static void hello(string s)
            {
                Console.WriteLine(s);
            }

            static void goodbye(string s)
            {
                Console.WriteLine(s);
            }
            static void Main()
            {
                customdel hidel, byedel, multidel;

                hidel = hello;
                byedel = goodbye;
                multidel = hidel + byedel;

                Console.WriteLine("invoking delegate hidel");
                hidel("A");
                Console.WriteLine("invoking delegate byedel");
                byedel("B");
                Console.WriteLine("invoking delegate multidel");
                multidel("C");


            }
        }
    }
}
