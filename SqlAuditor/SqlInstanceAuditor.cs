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
        private Timer timer;
        private bool isRunning = true;
        private ConcurrentQueue<TraceEvent> queue;
        public SqlInstanceAuditor(TraceConfig trace)
        {
            this.instance = trace.Instance;
            this.trace = trace;
            //this.conn = new SqlConnection(instance.ConnectionString);

            tsk = new Task(InternalStart, TaskCreationOptions.LongRunning);
            queue = new ConcurrentQueue<TraceEvent>();
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
                        //Console.WriteLine(evt.DatabaseName + " " + evt.TextData);
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

        private void Log(object state)
        {
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            TraceEvent pf;
            while (queue.TryDequeue(out pf))
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("RequestID:\t{0}", pf.RequestID);
                Console.WriteLine("EventClass:\t{0}", pf.EventClass);
                Console.WriteLine("EventSequence:\t{0}", pf.EventSequence);
                Console.WriteLine("EventSubClass:\t{0}", pf.EventSubClass);
                Console.WriteLine("***********************************************");
                Console.WriteLine("Application:\t{0}", pf.ApplicationName);
                Console.WriteLine("DatabaseName:\t{0}", pf.DatabaseName);
                Console.WriteLine("LoginName:\t{0}", pf.LoginName);
                Console.WriteLine("StartTime:\t{0}", pf.StartTime);
                Console.WriteLine("EndTime:\t{0}", pf.EndTime);
                Console.WriteLine("Duration:\t{0}", pf.Duration);
                Console.WriteLine(pf.TextData);
                Console.WriteLine("***********************************************");
                Console.WriteLine();
            }
            timer.Change(new TimeSpan(0, 0, 10), new TimeSpan(0, 0, 10));
        }

        public void Start()
        {
            traceConn = new TraceConnection(instance);
            traceConn.CreateTrace();
            foreach (var pe in trace.Events)
            {
                traceConn.SetEvent(pe.Event, pe.Columns);
            }
            foreach (var ef in trace.Filters.OrderBy((ef)=>ef.Column))
            {
                if (ef.Value.GetType() == typeof(int))
                    traceConn.SetFilter(ef.Column, (int)LogicalOperators.AND, (int)ef.Operator, (long)ef.Value);
                else
                    traceConn.SetFilter(ef.Column, (int)LogicalOperators.AND, (int)ef.Operator, (string)ef.Value);
            }
            traceConn.SetFilter(10, (int)LogicalOperators.AND, (int)ComparisonOperators.NotLike, "SqlAuditor");
            traceConn.StartTrace();
            tsk.Start();
            timer = new Timer(new TimerCallback(Log), new object(), new TimeSpan(0, 0, 10), new TimeSpan(0, 0, 10));
        }

        public void Stop()
        {
            isRunning = false;
            traceConn.StopTrace();
            tsk.Dispose();
            //;if (conn.State != System.Data.ConnectionState.Closed) conn.Close();
        }

        public void Dispose()
        {
            Stop();
        }
    }
}
