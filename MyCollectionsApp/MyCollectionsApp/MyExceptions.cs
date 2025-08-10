using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class MyExceptions
    {
        public void exceptions()
        {
            try
            {

                try
                {
                    //10/0 is evaluated at compile time since 10 and 0 are constants- so throws error
                    // a/0 or 10/b or a/b are evaluated at runtime beccause atleast one of them are constants so, CLR runs the code and throws exception
                    int a = 10;
                    int b = 0;
                    int x = 2/b;
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Division by zero");
                }
                Student1 std = null;
                Console.WriteLine(std.Name);

            }
            catch (FormatException ex)
            {
                Console.WriteLine("message " + ex.Message);
                Console.WriteLine("stacktrace " + ex.StackTrace);
            }
            catch (Exception ex)
            {
                Console.WriteLine("message " + ex.Message);
                Console.WriteLine("stacktrace " + ex.StackTrace);
            }
            catch //this catch block has no use here flow wont enter and if we write catch(exception ex) below this block it will give error so it is generally recommended not to use catch with parameter and parameterless in same code. 
            {
                Console.WriteLine("catched");
            }
           
            finally
            {
                Console.WriteLine("finally exception");
            }
        }
        public void CustomExceptions()
        {
            decimal balance = 1000, withdrawalAmount = 2000;
            try
            {
                if(balance  < withdrawalAmount)
                {
                    throw new CustomExc("throw parameter: Insufficient balance");
                    //throw new CustomExc();
                    //throw new Exception();
                }
            }
            catch(CustomExc ex)
            {
                Console.WriteLine("Caught custom exception");
                Console.WriteLine("Exception message: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("General exception: " + ex.ToString());
                Console.WriteLine("Exception message: " + ex.Message);

            }
        }
    }
    class CustomExc : Exception
    {
        public CustomExc() 
        {
            //below is optional code
            Console.WriteLine("Default custom exception");
        }
        public CustomExc(string message):base(message)
        {
            Console.WriteLine(message);
        }
    }
}
