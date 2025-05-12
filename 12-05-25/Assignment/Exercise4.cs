using System;
abstract class notification
{
    public abstract void send();

    public void showtype()
    {
        Console.WriteLine("Sending notifications");
    }

}

class Emailnotification : notification
{
    public override void send()
    {
        Console.WriteLine("Sending Email notifictaion");
    }
}

class SMSnotification : notification
{
    public override void send()
    {
        Console.WriteLine("Sending SMS notification");
    }
}

class program
{
    static void Main()
    {
       notification Email = new Emailnotification();
       notification SMS = new SMSnotification();  

       Email.showtype();
       Email.send();

        SMS .showtype();
        SMS .send();

    }
}

