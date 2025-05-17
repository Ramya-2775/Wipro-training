using System;

namespace CustomersupportTickets

{
    interface Isupportticket
    {
        void createticket(string issue);
        void resolveticket(int TicketId);
    }
    class Emailsupport : Isupportticket
    {
        public void createticket(string issue)
        {
            Console.WriteLine($"creating ticket via email:{issue}");
        }

        public void resolveticket(int TicketId)
        {
            Console.WriteLine($"Resolving ticket{TicketId} via email");
        }
    }
    class phonesupport : Isupportticket
    {
        public void createticket(string issue)
        {

            Console.WriteLine($"creating ticket via email:{issue}");
        }

        public void resolveticket(int TicketId)
        {
            Console.WriteLine($"Resolving ticket{TicketId} via email");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Isupportticket Emailsupport = new Emailsupport();
            Isupportticket phonesupport = new phonesupport();


            Emailsupport.createticket("Cannot Access amount");
            Emailsupport.resolveticket(90);

            phonesupport.createticket("Connection issue");
            phonesupport.resolveticket(80);
        }
    }
}
