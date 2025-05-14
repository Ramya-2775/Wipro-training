using System;
namespace bankingoperations
{
    interface ibankaccount
    {
        void deposit(double amount);
        void withdraw(double amount);
        void checkbalance();
    }

    class savingsaccount : ibankaccount
    {
        private double balance = 0;
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} into savings account");
        }
        public void withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"withdrew {amount} from savings account");
            }
            else
            {
                Console.WriteLine("insufficient balance in savings amount");
            }
        }

        public void checkbalance()
        {
            Console.WriteLine($"savings account balance {balance}");
        }
    }
    class currentaccount : ibankaccount
    {
        private double balance = 0;
        public void deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount} into current account");
        }
        public void withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"withdrew {amount} from current account");
            }
            else
            {
                Console.WriteLine("insufficient balance in current amount");
            }
        }
        public void checkbalance()
        {
            Console.WriteLine($"current account balance {balance}");
        }

        class program
        {
            static void Main(string[] args)
            {
                ibankaccount savings = new savingsaccount();
                ibankaccount current = new currentaccount();

                savings.deposit(5000);
                savings.withdraw(1000);
                savings.checkbalance();

                Console.WriteLine();

                current.deposit(10000);
                current.withdraw(800);
                current.checkbalance();


            }
        }

    }
}