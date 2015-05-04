using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor
{
    public interface ITraceObserverFactory
    {
        ITraceObserver Create(TraceContext context);
    }
}
