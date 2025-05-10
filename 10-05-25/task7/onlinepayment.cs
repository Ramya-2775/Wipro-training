using System;
class payment
{
    public decimal amount;
    public string currency;

    public virtual void processpayment()
    {
        Console.WriteLine($"processing payment of {amount} {currency}");
    }

    //overload @ amount
    public void processpayment(decimal amount)
    {
        Console.WriteLine($"processing payment of {amount} with default currency");
    }

    //overload @ amount and currency
    public void processpayment(decimal amount, string currency)
    {
        Console.WriteLine($"processing payment of {amount} {currency}");
    }
}

class creditcardpayment : payment
{
    public string cardnumber;
    public override void processpayment()
    {
        Console.WriteLine($"processing credit card payment of {amount} {currency} using card {cardnumber}");
    }
}

class paypalpayment : payment
{
    public string emailaddress;
    public override void processpayment()
    {
        Console.WriteLine($"processing credit card payment of {amount} {currency} using card {emailaddress}");
    }
}

class program
{
    static void Main()
    {
        //credit card payment
        creditcardpayment credit = new creditcardpayment();
        credit.amount = 9000;
        credit.currency = "INR";
        credit.cardnumber = "1233456778";
        credit.processpayment();

        //paypal method
        paypalpayment paypalpayment = new paypalpayment();
        paypalpayment.amount = 8000;
        paypalpayment.currency = "USD";
        paypalpayment.emailaddress = "xyz@gmail.com";
        paypalpayment.processpayment();

        Console.WriteLine();

        //method overload
        payment payment = new payment();
        payment.processpayment(6000);
        payment.processpayment(600, "EUR");
    }
}

