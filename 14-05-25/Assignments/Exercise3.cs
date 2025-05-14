using System;
namespace ticketbooking
{
    abstract class ticketbooking
    {
        public abstract void bookticket(int seats);

        public void showbookinginfo()
        {
            Console.WriteLine("booking tickets");
        }
    }

    class busbooking : ticketbooking
    {
        public override void bookticket(int seats)
        {
            Console.WriteLine($"booking {seats} bus ticket (s)");
        }
    }

    class flightbooking : ticketbooking
    {
        public override void bookticket(int seats)
        {
            Console.WriteLine($"booking {seats} flight ticket(s)");
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            ticketbooking busbooking = new busbooking();
            ticketbooking flightbooking = new flightbooking();

            busbooking.showbookinginfo();
            busbooking.bookticket(1);

            Console.WriteLine();

            flightbooking.showbookinginfo();
            flightbooking.bookticket(2);
            
        }
    }
}