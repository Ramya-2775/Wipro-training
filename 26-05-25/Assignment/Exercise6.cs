using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

/*namespace InventorySystem
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Stock { get; set; }
        public double Price { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var items = new List<Item>
            {
                new Item { Name = "Keyboard", Type = "Electronics", Stock = 5, Price = 50 },
                new Item { Name = "Mouse", Type = "Electronics", Stock = 2, Price = 30 },
                new Item { Name = "Monitor", Type = "Electronics", Stock = 7, Price = 150 },
                new Item { Name = "Chair", Type = "Furniture", Stock = 3, Price = 85 },
                new Item { Name = "Table", Type = "Furniture", Stock = 1, Price = 120 },
                new Item { Name = "Notebook", Type = "Stationery", Stock = 10, Price = 5 },
                new Item { Name = "Pen", Type = "Stationery", Stock = 50, Price = 1 },
                new Item { Name = "Headphones", Type = "Electronics", Stock = 4, Price = 80 },
                new Item { Name = "Lamp", Type = "Furniture", Stock = 6, Price = 40 },
                new Item { Name = "Shelf", Type = "Furniture", Stock = 2, Price = 90 },
                new Item { Name = "Marker", Type = "Stationery", Stock = 3, Price = 3 },
                new Item { Name = "Binder", Type = "Stationery", Stock = 7, Price = 2 },
                new Item { Name = "Eraser", Type = "Stationery", Stock = 8, Price = 0.5 },
                new Item { Name = "Fan", Type = "Electronics", Stock = 1, Price = 60 },
                new Item { Name = "Couch", Type = "Furniture", Stock = 1, Price = 300 }
            };

            var lowStock = items.Where(i => i.Stock < 5);
            var grouped = items.GroupBy(i => i.Type);
            var highestPriceEachGroup = grouped.Select(g => g.OrderByDescending(i => i.Price).First());

            Console.WriteLine("Low Stock Items:");
            foreach (var item in lowStock)
                Console.WriteLine($"{item.Name} ({item.Stock})");

            Console.WriteLine("\nHighest Priced Item per Type:");
            foreach (var item in highestPriceEachGroup)
                Console.WriteLine($"{item.Type}: {item.Name} - ${item.Price}");
        }
    }
}*/
