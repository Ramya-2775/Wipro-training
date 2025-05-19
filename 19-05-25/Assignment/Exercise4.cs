using System;
abstract class PaymentMethod
{
    public abstract void ProcessPayment(decimal amount);

    public virtual void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: [Method]");
    }
}

class CreditCardPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }

    public override void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: Credit Card");
    }
}

class UPIPayment : PaymentMethod
{
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of {amount}");
    }

    public override void ShowPaymentMethod()
    {
        Console.WriteLine("Payment Method: UPI");
    }
}

class Program
{
    static void Main()
    {
        PaymentMethod creditCard = new CreditCardPayment();
        PaymentMethod upi = new UPIPayment();

        creditCard.ShowPaymentMethod();
        creditCard.ProcessPayment(1500);

        upi.ShowPaymentMethod();
        upi.ProcessPayment(750);
    }
}
