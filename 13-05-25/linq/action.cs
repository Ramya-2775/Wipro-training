using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq.projects
{
    internal class action
    {
        class Action
        {
            public static void Main()
            {
                Action<int> printActiondel = consoleprint;
                Action<int> printtoprinter = PrinterPrint;

                printActiondel(10);
                printtoprinter(10);
                Console.Read();
            }
            public static void consoleprint(int i)
            {
                Console.WriteLine(i);   
            }
            public static void PrinterPrint(int i)
            {
                Console.WriteLine("this is being printed to printer");
            }

        }

    }
}
