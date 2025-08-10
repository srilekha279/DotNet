using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    public delegate void Notify();
    internal class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started");
            OnProcessCompleted();
        }
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }

       
    }
    class MySubscriber
    {
        public static void SubProcess()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; //register with an event
            bl.StartProcess();
        }
        //event handler
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed");
        }
    }
}
