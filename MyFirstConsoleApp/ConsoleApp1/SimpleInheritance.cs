using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Shape
    {
        protected int width, height;
        public void setWidth(int w) { width = w; }
        public void setHeight(int h) { height = h; }
    }

    class Rectangle: Shape
    {
        long area;
        public long getArea()
        {
            area = width * height;
            return area;
        }
        public long getCost(long lCostPerUnit)
        {
            return area * lCostPerUnit;
        }
    }

    internal class SimpleInheritance
    {
        public void AcceptAndPrint()
        {
            long area, lcost = 75;
            Rectangle rect = new Rectangle();
            rect.setWidth(10);
            rect.setHeight(20);
            area = rect.getArea();
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Total cost: " + rect.getCost(lcost));

        }
    }
}
