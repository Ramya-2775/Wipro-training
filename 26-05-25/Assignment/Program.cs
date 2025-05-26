using System;
using System.Collections.Generic;

/*namespace PaymentGatewaySystem
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }

    public abstract class PaymentGateway
    {
        public string GatewayName { get; set; }
        public virtual bool Validate()
        {
            Console.WriteLine($"{GatewayName} validation complete.");
            return true;
        }
    }

    public class Razorpay : PaymentGateway, IPaymentProcessor
    {
        public Razorpay() => GatewayName = "Razorpay";
        public void ProcessPayment(double amount)
        {
            if (Validate())
                Console.WriteLine($"Razorpay processed payment of {amount}");
        }
    }

    public class PayPal : PaymentGateway, IPaymentProcessor
    {
        public PayPal() => GatewayName = "PayPal";
        public void ProcessPayment(double amount)
        {
            if (Validate())
                Console.WriteLine($"PayPal processed payment of {amount}");
        }
    }

    public class Stripe : PaymentGateway, IPaymentProcessor
    {
        public Stripe() => GatewayName = "Stripe";
        public void ProcessPayment(double amount)
        {
            if (Validate())
                Console.WriteLine($"Stripe processed payment of {amount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var processors = new List<IPaymentProcessor> { new Razorpay(), new PayPal(), new Stripe() };
            foreach (var processor in processors)
                processor.ProcessPayment(100);
        }
    }
}*/

            
        