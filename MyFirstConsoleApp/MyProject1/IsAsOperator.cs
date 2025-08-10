using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1
{
    class Class1
    {

    }

    class Class2
    {

    }

     class IsAsOperator
    {
        public void IsTest(object o)
        {
            Class1 a;
            Class1 b;
            if (o is Class1)
            {
                Console.WriteLine($"{o} is of type Class1");
                a = (Class1)(o);
            }
            else if(o is Class2)
            {
                Console.WriteLine($"{o} is of type Class2");
                b = (Class2)(o);
            }
            else
            {
                Console.WriteLine($"{o} is neither Class1 nor Class2");
            }
        }
        
    }
}
