using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MyCollectionsApp
{
    internal class Queues
    {
        public void QueueFunctions()
        {
            Queue q = new Queue();
            q.Enqueue("jan");
            q.Enqueue("feb");
            q.Enqueue("mar");
            q.Enqueue("apr");
            Console.WriteLine(q.Count);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
            int count = q.Count;
            while (count > 0)
            {
                string month = (string)q.Dequeue();
                DateTime dt = DateTime.Now;
                Console.Write("No of days in: " + month);
                switch (month)
                {
                    case "feb":
                        Console.WriteLine(DateTime.DaysInMonth(dt.Year, 2));
                        break;
                    case "jan":
                    case "mar":
                    case "may":
                    case "jul":
                    case "aug":
                    case "oct":
                    case "dec":
                        Console.WriteLine(31);
                        break;
                    case "apr":
                    case "jun":
                    case "sep":
                    case "nov":
                        Console.WriteLine(30);
                        break;

                }
                count--;
            }
            
        }
    }
}
