using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksOOP
{
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
    public interface IWorker
    {
        void Work();
    }
}
