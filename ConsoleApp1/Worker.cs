using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace TasksOOP
{
    public class Worker1 : IWorker
    {
        ILogger Logger { get; }

        public Worker1(ILogger ilogger)
        {
            Logger = ilogger;
        }

        public void Work()
        {
            Logger.Event("Worker 1 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker 1 закончил свою работу");
        }
    }
    public class Worker2 : IWorker
    {
        ILogger Logger { get; }

        public Worker2(ILogger ilogger)
        {
            Logger = ilogger;
        }

        public void Work()
        {
            Logger.Event("Worker 2 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker 2 закончил свою работу");
        }
    }
    public class Worker3 : IWorker
    {
        ILogger Logger { get; }

        public Worker3(ILogger ilogger)
        {
            Logger = ilogger;
        }

        public void Work()
        {
            Logger.Event("Worker 3 начал свою работу");
            Thread.Sleep(3000);
            Logger.Event("Worker 3 закончил свою работу");
        }
    }
}
