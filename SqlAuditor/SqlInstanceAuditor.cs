using SqlAuditor.Config;
using SqlAuditor.Trace;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SqlAuditor
{
    public class SqlInstanceAuditor : IDisposable
    {
        private InstanceConfig instance;
        private TraceConfig trace;
        //private RawTraceReader rtr;
        //private SqlConnection conn;
        private TraceConnection traceConn;
        private Task tsk;
        private CancellationTokenSource ts;
        private Timer timer;
        private bool isRunning = true;
        private ConcurrentQueue<TraceEvent> queue;
        private List<ITraceObserver> observers;
        private TraceContext context;
        public SqlInstanceAuditor(TraceContext context)
        {
            this.trace = context.Trace;
            this.instance = trace.Instance;
            this.context = context;
            //this.conn = new SqlConnection(instance.ConnectionString);
            ts = new CancellationTokenSource();
            tsk = new Task(InternalStart, ts.Token,TaskCreationOptions.LongRunning);
      
            queue = new ConcurrentQueue<TraceEvent>();
            this.observers = context.TraceObservers;
        }


        private void InternalStart()
        {
            try
            {
                while (isRunning && traceConn.HasResults)
                {
                    TraceEvent evt = traceConn.Next();
                    if (evt != null)
                    {
                        queue.Enqueue(evt);
                    }
                }
            }
            catch (Exception e)
            {
                if (isRunning && traceConn.HasResults)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void ConsumeEvents(object state)
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            TraceEvent pf;
            while (queue.TryDequeue(out pf))
            {
                observers.ForEach((observer) => observer.EventReceived(pf));
            }
            timer.Change(new TimeSpan(0, 0, 5), new TimeSpan(0, 0, 5));
        }

        public void Start()
        {
            traceConn = new TraceConnection(context);
            traceConn.CreateTrace();
            foreach (var pe in trace.Events)
            {
                traceConn.SetEvent(pe.Event, pe.Columns);
            }
            foreach (var ef in trace.Filters.OrderBy((ef)=>ef.Column))
            {
                    traceConn.SetFilter(ef.Column, LogicalOperators.AND, ef.Operator, ef.Value);
            }
            traceConn.SetFilter(10, LogicalOperators.AND, ComparisonOperators.NotLike, "SqlAuditor");
            traceConn.StartTrace();
            tsk.Start();
            timer = new Timer(new TimerCallback(ConsumeEvents), new object(), new TimeSpan(0, 0, 5), new TimeSpan(0, 0, 5));
        }

        public void Stop()
        {
            isRunning = false;
            traceConn.StopTrace();
            ts.Cancel();
            ts.Token.WaitHandle.WaitOne();
            tsk.Wait();
            tsk.Dispose();
            ts.Dispose();
        }

        public void Dispose()
        {
           if(isRunning) Stop();
        }
    }
}
