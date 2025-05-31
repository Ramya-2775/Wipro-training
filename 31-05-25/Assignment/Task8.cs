using System;
using System.Collections.Generic;


interface IPrintable
{
    void Print();
}

abstract class Invoice
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(Product p)
    {
        Products.Add(p);
    }

    public abstract double CalculateTotal();
}

class Product
{
    public string Name;
    public double Price;
    public int Quantity;

    public Product(string name, double price, int qty)
    {
        Name = name;
        Price = price;
        Quantity = qty;
    }
}


class RetailInvoice : Invoice, IPrintable
{
    public override double CalculateTotal()
    {
        double total = 0;
        foreach (var item in Products)
        {
            total += item.Price * item.Quantity;
        }
        double tax = total * 0.1; // 10% tax
        return total + tax;
    }

    public void Print()
    {
        Console.WriteLine("\n--- Retail Invoice ---");
        foreach (var item in Products)
        {
            Console.WriteLine($"{item.Name} x {item.Quantity} @ {item.Price} = {item.Price * item.Quantity}");
        }
        Console.WriteLine($"Total (with 10% tax): {CalculateTotal():0.00}");
    }
}

class WholesaleInvoice : Invoice, IPrintable
{
    public override double CalculateTotal()
    {
        double total = 0;
        foreach (var item in Products)
        {
            total += item.Price * item.Quantity;
        }
        double discount = total * 0.2; 
        return total - discount;
    }

    public void Print()
    {
        Console.WriteLine("\n--- Wholesale Invoice ---");
        foreach (var item in Products)
        {
            Console.WriteLine($"{item.Name} x {item.Quantity} @ {item.Price} = {item.Price * item.Quantity}");
        }
        Console.WriteLine($"Total (with 20% discount): {CalculateTotal():0.00}");
    }
}


/*class Program
{
    static void Main()
    {
       
        RetailInvoice retail = new RetailInvoice();
        retail.AddProduct(new Product("Pen", 10, 3));
        retail.AddProduct(new Product("Notebook", 40, 2));
        retail.Print();

        
        WholesaleInvoice wholesale = new WholesaleInvoice();
        wholesale.AddProduct(new Product("Box of Pens", 100, 1));
        wholesale.AddProduct(new Product("Bundle of Notebooks", 200, 1));
        wholesale.Print();
    }
}*/
