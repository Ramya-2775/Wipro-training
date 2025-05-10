using System;

namespace ConsoleApp1
{

    class program
    {
        static void Main(string[] args)
        {
            facebook fb = new facebook();
            twitter tw = new twitter();
            instagram ig = new instagram();

            fb.post();
            tw.post();
            ig.post();
            Console.WriteLine();

            socialmedia post;

            post = new facebook();
            post.post();

            post = new instagram();
            post.post();

            post = new twitter();
            post.post();

            Console.ReadLine();
        }
    }
}