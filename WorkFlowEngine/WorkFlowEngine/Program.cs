﻿using System;
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
            var workFlow = new Workflow();
            workFlow.Add(new VideoUploader());
            workFlow.Add(new CallWebService());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            var engine = new WorkFlowEngine();
            engine.Run(workFlow);

            Console.ReadLine();
        }
    }

    public interface ITask
    {
        void Execute();
    }

    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }

    public class Workflow : IWorkFlow
    {
        private readonly List<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }

    class VideoUploader : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading a video...");
        }
    }

    class CallWebService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling web service...");
        }
    }

    class SendEmail : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }

    class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Change status...");
        }
    }

    public class WorkFlowEngine
    {
        public void Run(IWorkFlow workFlow)
        {
            foreach (ITask I in workFlow.GetTasks())
            {
                I.Execute();
            }
        }
    }
}
