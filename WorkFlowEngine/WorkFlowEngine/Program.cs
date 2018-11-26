using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlowEngine();
            workFlow.AddWorkFlowObject(new VideoUploader());
            workFlow.AddWorkFlowObject(new CallWebService());
            workFlow.AddWorkFlowObject(new SendEmail());
            workFlow.AddWorkFlowObject(new ChangeStatus());

            workFlow.Run();

            Console.ReadLine();
        }
    }

    interface IWorkFlow
    {
        void Execute();
    }

    class VideoUploader : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video...");
        }
    }

    class CallWebService : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }

    class SendEmail : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }

    class ChangeStatus : IWorkFlow
    {
        public void Execute()
        {
            Console.WriteLine("Change status...");
        }
    }

    class WorkFlowEngine
    {
        private List<IWorkFlow> T;

        public WorkFlowEngine()
        {
            T = new List<IWorkFlow>();
        }

        public void AddWorkFlowObject(IWorkFlow iObject)
        {
            T.Add(iObject);
        }

        public void RemoveWorkFlowObject(IWorkFlow iObject)
        {
            T.Remove(iObject);
        }

        public void Run()
        {
            foreach (IWorkFlow I in T)
            {
                I.Execute();
            }
        }
    }
}
