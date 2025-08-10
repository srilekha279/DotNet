using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCollectionsApp
{
    internal class ProcessEventData
    {
        public event EventHandler<ProcessEventArgs> ProcessCompleted;
        public void StartProcess()
        {
            var data = new ProcessEventArgs();
            try
            {
                Console.WriteLine("Process started");
                //some processing code 
                //update data object with true and datetime;
                data.IsSuccessful = true;
                data.CompletionTime = DateTime.Now;
                OnProcessCompleted(data);
            }
            catch(Exception ex)
            {
                data.IsSuccessful = false;
                OnProcessCompleted(data);
            }
        }

        protected virtual void OnProcessCompleted(ProcessEventArgs e)
        {
            ProcessCompleted ? .Invoke(this, e);
        }
    }
    class ProcessEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
    class Exec
    {
        public static void execute()
        {
            ProcessEventData bl = new ProcessEventData();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();
        }
        public static void bl_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion time: " + e.CompletionTime.ToLongDateString());
        }
    }
}
