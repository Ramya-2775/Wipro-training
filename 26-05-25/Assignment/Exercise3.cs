using System;
using System.Collections.Generic;
using System.IO;

/*namespace BankLogger
{
    public class Transaction
    {
        public string Type { get; set; }
        public double Amount { get; set; }
        public DateTime Time { get; set; }
    }

    public class BankAccount
    {
        private List<Transaction> _transactions = new();
        public void Deposit(double amount) =>
            _transactions.Add(new Transaction { Type = "Deposit", Amount = amount, Time = DateTime.Now });

        public void Withdraw(double amount) =>
            _transactions.Add(new Transaction { Type = "Withdraw", Amount = amount, Time = DateTime.Now });

        public void SaveTransactions(string path)
        {
            using var writer = new StreamWriter(path);
            foreach (var t in _transactions)
                writer.WriteLine($"{t.Type},{t.Amount},{t.Time}");
        }

        public void LoadTransactions(string path)
        {
            if (!File.Exists(path)) return;
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(',');
                _transactions.Add(new Transaction { Type = parts[0], Amount = double.Parse(parts[1]), Time = DateTime.Parse(parts[2]) });
            }
        }

        public void DisplaySummary()
        {
            foreach (var t in _transactions)
                Console.WriteLine($"{t.Type} of {t.Amount} at {t.Time}");
        }
    }

    class Program
    {
        static void Main()
        {
            var account = new BankAccount();
            string filePath = "transactions.txt";

            account.LoadTransactions(filePath);
            account.Deposit(1000);
            account.Withdraw(200);
            account.SaveTransactions(filePath);
            account.DisplaySummary();
        }
    }
}*/