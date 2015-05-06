using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor
{
    public class ConsoleTrace : ITraceObserver
    {
        TraceContext context;
        public void EventReceived(TraceEvent traceEvent)
        {
            var e = context.SqlTraceEvents[traceEvent.EventClass];
            var evtCtgr = context.SqlTraceCategories[e.CategoryId];
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**********************************************");
            sb.AppendFormat("Event Name: {0}\n", e.Name);
            sb.AppendFormat("Event Category: {0}\n", evtCtgr.Name);
            foreach (var kv in traceEvent.Values)
            {
                sb.AppendFormat("{0}: {1}\n", context.SqlTraceColumns[kv.Key].Name, kv.Value.ToString());
                if (context.SqlTraceColumns[kv.Key].HasSubClassValues && context.SqlTraceEvents[traceEvent.EventClass].SubClassValues.ContainsKey(kv.Key))
                    sb.AppendFormat("{0}_VALUE: {1}\n", context.SqlTraceColumns[kv.Key].Name, context.SqlTraceEvents[traceEvent.EventClass].SubClassValues[kv.Key][(int)kv.Value].Name);
            }
            sb.AppendLine("**********************************************");
            sb.AppendLine();
            Console.WriteLine(sb.ToString());
        }

        public void Init(TraceContext context)
        {
            this.context = context;
        }
    }
}
