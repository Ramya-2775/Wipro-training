using System;
using ConsoleApp1;
namespace ConsoleApp1;

class program
{
    static void Main(string[] args)
    {
        Appliance appliance = new washingmachine();
        appliance.operate();
    }
}