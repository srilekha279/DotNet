using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AbstractClasses
    {
        public void Display()
        {
            CTransaction t = new CTransaction("T01", "02/03/2025", 3000);
            t.showTransaction();
            CTransaction t1 = new CTransaction();
            t1.showTransaction();
        }
    }
    public abstract class Transactions
    {
        public abstract void showTransaction();
        public abstract double getAmount();
    }
    public class CTransaction: Transactions
    {
        private string tCode, date;
        private double amount;
        public CTransaction()
        {
            tCode = ""; date = ""; amount = 0.0;
        }
        public CTransaction(string tCode, string date, double amount)
        {
            this.tCode = tCode;
            this.date = date;
            this.amount = amount;
        }
        public override double getAmount()
        {
            return amount;
        }
        public override void showTransaction()
        {
            Console.WriteLine("Tramsaction {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }
    }
}
