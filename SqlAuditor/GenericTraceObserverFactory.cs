using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor
{
    public class GenericTraceObserverFactory : ITraceObserverFactory
    {
        Func<Trace.TraceContext, ITraceObserver> func;
        public GenericTraceObserverFactory(Func<Trace.TraceContext, ITraceObserver> Function)
        {
            this.func = Function;
        }
        public ITraceObserver Create(Trace.TraceContext context)
        {
            return func(context);
        }
    }
}
