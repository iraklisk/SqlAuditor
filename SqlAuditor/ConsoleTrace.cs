using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor
{
    public class ConsoleTrace : ITraceObserver
    {
        public void EventReceived(TraceEvent traceEvent)
        {
            Console.WriteLine("***********************************************");
            Console.WriteLine("RequestID:\t{0}", traceEvent.RequestID);
            Console.WriteLine("EventClass:\t{0}", traceEvent.EventClass);
            Console.WriteLine("EventSequence:\t{0}", traceEvent.EventSequence);
            Console.WriteLine("EventSubClass:\t{0}", traceEvent.EventSubClass);
            Console.WriteLine("***********************************************");
            Console.WriteLine("Application:\t{0}", traceEvent.ApplicationName);
            Console.WriteLine("DatabaseName:\t{0}", traceEvent.DatabaseName);
            Console.WriteLine("LoginName:\t{0}", traceEvent.LoginName);
            Console.WriteLine("StartTime:\t{0}", traceEvent.StartTime);
            Console.WriteLine("EndTime:\t{0}", traceEvent.EndTime);
            Console.WriteLine("Duration:\t{0}", traceEvent.Duration);
            Console.WriteLine(traceEvent.TextData);
            Console.WriteLine("***********************************************");
            Console.WriteLine();
        }

        public void Init(TraceContext context)
        {
            
        }
    }
}
