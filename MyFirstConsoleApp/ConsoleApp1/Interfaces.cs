using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Interfaces
    {
        public void Display()
        {
            Transaction t = new Transaction("T01", "02/03/2025", 3000);
            t.showTransaction();
            Transaction t1 = new Transaction();
            t1.showTransaction();
        }
    }
    public interface ITransactions
    {
        void showTransaction();
        double getAmount();
    }
    public class Transaction: ITransactions
    {
        private string tCode, date;
        private double amount;
        public Transaction()
        {
            tCode = "";
            date = "";
            amount = 0.0;
        }
        public Transaction(string tCode, string date, double amount)
        {
            this.tCode = tCode;
            this.date = date;
            this.amount = amount;
        }
        public double getAmount()
        {
            return amount;
        }
        public void showTransaction()
        {
            Console.WriteLine("Tramsaction {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
}

