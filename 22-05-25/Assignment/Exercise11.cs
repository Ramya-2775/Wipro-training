using System;
using System.Collections.Generic;
using System.Linq;

class Product
{ 
    public int Id;
    public string Name; 
    public decimal Price; 
}
namespace products
{
    class program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new()
            {
                new Product { Id = 1, Name = "Tablet", Price = 45000},
                new Product { Id = 2, Name = "Laptop", Price = 65000 },
                new Product { Id = 3, Name = "Phone", Price = 80000 },
                new Product { Id = 4, Name = "Mouse", Price = 5000 },
                new Product { Id = 5, Name = "Monitor", Price = 35000 }

            };
            var sorted = productList.OrderByDescending(p => p.Price);
            foreach (var p in sorted)
                Console.WriteLine($"{p.Name} - {p.Price}");

        }
    }
}



