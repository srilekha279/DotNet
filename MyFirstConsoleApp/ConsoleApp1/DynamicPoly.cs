using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DynamicPoly
    {
        public void AcceptAndPrint()
        {
            Printer p = new Printer();
            p.show();
            p.print();

            Printer ls = new LaserJet();
            ls.show();
            ls.print();

            Printer oj = new OfficeJet();
            oj.show();
            oj.print();
        }
    }
    class Printer
    {
        public virtual void show()
        {
            Console.WriteLine("Printer dimension 6x6");
        }
        public virtual void print()
        {
            Console.WriteLine("Printer printing.....\n");
        }
    }
    class LaserJet: Printer
    {
        sealed override public void show()
        {
            Console.WriteLine("LaserJet dimension 12x12");
        }
        public override void print()
        {
            Console.WriteLine("Laserjet printing...\n");
        }
    }
    class OfficeJet: LaserJet
    {
        //cannot override inherited method because it is sealed
       // public override void show() { }
        public override void print() 
        {
            Console.WriteLine("Officejet printing...\n");
        }
    }
}
