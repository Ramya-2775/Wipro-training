using System;
using System.Collections.Generic;
using System.Linq;
class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}
namespace ProductFilterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new()
            {
                new Product { Name = "Laptop", Price = 80000 },
                new Product { Name = "Mouse", Price = 2500 },
                new Product { Name = "Monitor", Price = 600000 },
                new Product { Name = "Keyboard", Price = 10000 },
                new Product { Name = "Phone", Price = 40000 }
            };

            var expensive = products.Where(p => p.Price > 50000);

            foreach (var p in expensive)
                Console.WriteLine($"{p.Name} - {p.Price}");
        }
    }
}