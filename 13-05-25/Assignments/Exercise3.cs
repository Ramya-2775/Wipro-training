using System;
abstract class paymentgateway
{
    public abstract void processpayment(double amount);

    public void showgatewayname()
    {
        Console.WriteLine("processing payment through gateway");
    }
}
class stripegateway : paymentgateway
{
    public override void processpayment(double amount)
    {
        Console.WriteLine($"processing payment through stripe:{amount}");
    }

}
class paypalgateway : paymentgateway
{
    public override void processpayment(double amount)
    {
        Console.WriteLine($"processing payment through paypal:{amount}");
    }

}
class program
{
    static void Main( string[] args )
    {
        paymentgateway stripe = new stripegateway();
        paymentgateway paypal = new paypalgateway();

        stripe.showgatewayname();
        stripe.processpayment(1000);

        paypal.processpayment(1000);
        paypal.showgatewayname();
    }
}