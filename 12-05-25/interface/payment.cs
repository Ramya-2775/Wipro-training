using System.Reflection.Metadata;

interface ipayment
{
    void processpayment(decimal amount);
}

class creditcardpayment : ipayment
{
    public void processpayment(decimal amount)
    {
        Console.WriteLine($"processsing credit card payment of {amount}");  
    }
}
class paypalpayment : ipayment
{
    public void processpayment(decimal amount)
    {
        Console.WriteLine($"processsing paypal  payment of {amount}");
    }
}

class program
{
    static void Main()
    {
        //Interface as refernce
        ipayment payment;

        //creditcard payment
        payment = new creditcardpayment();
        payment.processpayment(1500);

        //paypal payment
        payment = new paypalpayment();
        payment.processpayment(1500);

    }
}
