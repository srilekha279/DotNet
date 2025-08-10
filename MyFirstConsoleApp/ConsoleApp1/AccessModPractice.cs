using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AccessModPractice
    {
        public int pubInt = 10;
        private int priInt = 20;
        protected int protectedInt = 30;
        internal int intInt = 40;
        protected internal int protintInt = 50;
        public void public_member()
        {
            Console.WriteLine("I am public method");
            Console.WriteLine("Public Int: " + pubInt);
        }
        private void private_member()
        {
            Console.WriteLine("I am private method");
            Console.WriteLine("Private Int: " + priInt);
        }
        protected void protected_member()
        {
            Console.WriteLine("I am protected method");
            Console.WriteLine("Protected Int: " + protectedInt);
        }
        internal void internal_member()
        {
            Console.WriteLine("I am internal method");
            Console.WriteLine("Internal Int: " + intInt);
        }
        protected internal void protected_internal_member()
        {
            Console.WriteLine("I am protected internal method");
            Console.WriteLine("Protected Internal Int: " + protintInt);
        }
    }
    class Derived:AccessModPractice
    {
        public void AccessFromDervied()
        {
            Console.WriteLine("Accessing from derived");
            Console.WriteLine("public: " + pubInt);
            //Console.WriteLine(priInt);
            Console.WriteLine("protected: " + protectedInt);
            Console.WriteLine("internal: " + intInt);
;           Console.WriteLine("protected internal: " + protintInt);
            public_member();
            //private_member();
            protected_member();
            internal_member();
            protected_internal_member();
        }
    }

}
