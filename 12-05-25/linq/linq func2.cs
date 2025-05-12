using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class program
{
    static void Main(string[] args)
    {
        string[] names = { "Ramya", "sowmya", "Anil", "reddy", "prasad" };
        UsingLinqextensions(names);

    }
    /*private static void UsingLinq(string[] names)
    {
        IEnumerable<string> query = from s in names
                                    where s.Length == 5
                                    orderby s
                                    select s.ToUpper();
        foreach (string item in query)

            Console.WriteLine(item);

        Console.Read();



    }

    private static void UsingLinqextensions(string[] names)
    { 

    IEnumerable<string> query = names
                                .Where(s => s.Length == 5)
                                .OrderBy(s => s)
                                .Select(s => s.ToUpper());
    foreach (string item in query)

        Console.WriteLine(item);

    Console.Read();



    }*/

    private static void UsingLinqextensions(string[] names)
    {
        Func<string, bool> filter = s => s.Length == 5;
        Func<string, string> extract = s => s;
        Func<string, string> project = s => s.ToUpper();
        IEnumerable<string> query = names
                                .Where(filter)
                                .OrderBy(extract)
                                .Select(project);
        foreach (string item in query)

            Console.WriteLine(item);

        Console.Read();
    }
}