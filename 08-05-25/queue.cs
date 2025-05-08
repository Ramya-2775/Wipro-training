using System;
using System.Collections.Generic;
class program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();

        //enqueue
        queue.Enqueue("Ramya");
        queue.Enqueue("Vara");
        queue.Enqueue("Prasad");
        queue.Enqueue("Reddy");

        Console.WriteLine("Queue elements");

        foreach (var name in queue)
        {
            Console.WriteLine(name);
        }

        //dequeue -- remove
        Console.WriteLine("\nDequeued: " + queue.Dequeue());

        //peek-- only read
        Console.WriteLine("next in line:" + queue.Peek());

    }


}