using SqlAuditor.Config;
using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor
{
    public interface ITraceObserver
    {
        void Init(TraceContext context);
        void EventReceived(TraceEvent traceEvent);
    }
}
