using System;
using System.Collections.Generic;


class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}

class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public double GetTotalPrice()
    {
        return Product.Price * Quantity;
    }
}

class ShoppingCart
{
    private List<CartItem> items = new List<CartItem>();

    public void AddItem(Product product, int quantity)
    {
        CartItem existingItem = null;
        foreach (CartItem item in items)
        {
            if (item.Product.Id == product.Id)
            {
                existingItem = item;
                break;
            }
        }

        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            CartItem newItem = new CartItem();
            newItem.Product = product;
            newItem.Quantity = quantity;
            items.Add(newItem);
        }
    }

    public void RemoveItem(int productId)
    {
        CartItem itemToRemove = null;
        foreach (CartItem item in items)
        {
            if (item.Product.Id == productId)
            {
                itemToRemove = item;
                break;
            }
        }

        if (itemToRemove != null)
        {
            items.Remove(itemToRemove);
        }
    }

    public double GetCartTotal()
    {
        double total = 0;
        foreach (CartItem item in items)
        {
            total += item.GetTotalPrice();
        }
        return total;
    }
}

class Program
{
    static void Main()
    {
        Product p1 = new Product();
        p1.Id = 1;
        p1.Name = "Laptop";
        p1.Price = 800;

        Product p2 = new Product();
        p2.Id = 2;
        p2.Name = "Mouse";
        p2.Price = 20;

        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(p1, 1);
        cart.AddItem(p2, 2);

        Console.WriteLine("Total Cart Value: " + cart.GetCartTotal());
    }
}
