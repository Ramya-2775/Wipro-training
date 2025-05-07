
//Arraylist
using System;
using System.Collections;
class program
{
    static void Main()
    {
        ArrayList list = new ArrayList();
        list.Add("Apple");
        list.Add(42);
        list.Add(3.14);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.Read();
    }
}