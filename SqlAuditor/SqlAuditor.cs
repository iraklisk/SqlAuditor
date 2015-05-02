using SqlAuditor.Config;
using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SqlAuditor
{
    public class SqlAuditor
    {
        private AuditConfig config;
        private List<Type> observers;
        private List<SqlInstanceAuditor> auditors;
        public SqlAuditor(AuditConfig config)
        {
            this.config = config;
            observers = new List<Type>();
            auditors = new List<SqlInstanceAuditor>();
        }

        public void RegisterObserver(Type observer)
        {
            observers.Add(observer);
        }
        public void Start()
        {
            foreach (var trace in config.Traces)
            {
                var instObservers = new List<ITraceObserver>();
                var context = new TraceContext(trace, instObservers);
                foreach (var t in observers)
                {
                    var obs = Activator.CreateInstance(t) as ITraceObserver;
                    obs.Init(context);
                    instObservers.Add(obs);
                }
                SqlInstanceAuditor auditor = new SqlInstanceAuditor(context);
                auditors.Add(auditor);
                auditor.Start();

            }

        }

        public void Stop()
        {
            foreach (var auditor in auditors)
            {
                auditor.Stop();
            }
        }
    }
}
