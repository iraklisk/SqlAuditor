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
        private List<ITraceObserverFactory> observerFactories;
        private List<SqlInstanceAuditor> auditors;
        public SqlAuditor(AuditConfig config)
        {
            this.config = config;
            observerFactories = new List<ITraceObserverFactory>();
            auditors = new List<SqlInstanceAuditor>();
        }

        public void RegisterObserver(ITraceObserverFactory observerFactory)
        {
            observerFactories.Add(observerFactory);
        }
        public void Start()
        {
            foreach (var trace in config.Traces)
            {
                var instObservers = new List<ITraceObserver>();
                var context = new TraceContext(trace, instObservers);
                foreach (var observerFactory in observerFactories)
                {
                    var observer = observerFactory.Create(context);
                    observer.Init(context);
                    instObservers.Add(observer);
                }
                SqlInstanceAuditor auditor = new SqlInstanceAuditor(context);
                auditors.Add(auditor);
                auditor.Start();

            }

        }

        public void WaitAll()
        {
            auditors.Select((auditor) => auditor.ExecutionTask).ToList().ForEach((tsk) => tsk.Wait());
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
