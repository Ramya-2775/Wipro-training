using System;
using System.Collections.Generic;

class product
{
    public int ID { get; set; }
    public string Name { get; set; }

    private double Price;

    public double price { get; set; }
    public product(int id, string name, double price)
    {
        ID= id;
        Name = name;
        Price = price;

    }
    public override string ToString()
    {
        return $"ID: {ID}, Name:{Name}, Price: {Price}";
    }
}
class program
{
    static void Main()
    {
        //create a list 
        List<product> products= new List<product>
        {
            new product(1, "Laptop",80000),
            new product(2, "Headphones",40000),
            new product(3, "Smartphone",60000),
            new product(4, "Watch",30000),
            new product(5, "keyboard",10000)
        };

        //sort products by price in descending order
        products = products.OrderByDescending(p => p.price).ToList();

        Console.WriteLine("products sorted by price in descending order:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }

        //print the product with highest price
        var mostExpensive = products.First();
        Console.WriteLine($"\nproduct with the highest price:\n{mostExpensive}");

    }
}