using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        Queue<string> customers = new Queue<string>();

        // adding cunstomers to the queue
        customers.Enqueue("Ramya");
        customers.Enqueue("Vara");
        customers.Enqueue("Prasad");

        Console.WriteLine("serving customers");

        while (customers.Count > 0)
        {
            Console.WriteLine("serving" + customers.Dequeue());

        }
 

    }


}