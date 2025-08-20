using MyCollectionsApp;
using System.Collections;

namespace MyCollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyArrayList myal = new MyArrayList();
            //myal.ArrayListFunctions();

            MyList mylist = new MyList();
           // mylist.ListFunctions();

            StudentClassList mystudentlist = new StudentClassList();    
           // mystudentlist.StudentListFunctions();

            MySortedList mysortedlist = new MySortedList();
          // mysortedlist.SortedListFunctions();

            MyStack myStack = new MyStack();
            //myStack.StackFunctions();

            Queues q = new Queues();
            //q.QueueFunctions();

            MyExceptions myexc = new MyExceptions();
            //  myexc.exceptions();
            //myexc.CustomExceptions();
            
            StudentExceptions se = new StudentExceptions();
            //se.GetStudentDetails();


            //Delegates 
            Delegates1 d = new Delegates1();
            //d.AcceptAndPrint();
            GenericDelegates gd = new GenericDelegates();
            // gd.CallFunctions();
            TypesOfDelegates deltypes = new TypesOfDelegates();
            //deltypes.Execute();

            //extension methods - these can be applied anywhere using namespace in which extension method or class is present- here, file in which we are using extension method and the implementation of extension method are in same namespace.
            //string str = "1234";
            //int result = str.IntegerExtension();
            //Console.WriteLine(result);
            //Console.WriteLine("hello everyone".GetWordCount());


            StudentClassList stu = new StudentClassList();


            MySubscriber sub = new MySubscriber();
            // MySubscriber.SubProcess();
            // Exec.execute();

            //  BasicLinq blq = new BasicLinq();
            // blq.LinqBasics();


            // LinqProgram.WorkWithLinq();
            LinqProgram lp = new LinqProgram();
            //lp.SelectManyLinq();
            lp.MoreLinq();
        }
    }
}
