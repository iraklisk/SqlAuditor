using SqlAuditor.Config;
using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.ConsoleServer
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new AuditConfig();
            TraceConfig trace = new TraceConfig(new InstanceConfig("IK", "demo"));
            trace.Events.Add(new EventConfig(TraceEvents.TSQL.SQLStmtCompleted,
                                   TraceColumns.TextData, TraceColumns.LoginName,
                                   TraceColumns.CPU, TraceColumns.Reads,
                                   TraceColumns.Writes, TraceColumns.Duration,
                                   TraceColumns.SPID
                                   , TraceColumns.StartTime, TraceColumns.EndTime
                                   , TraceColumns.DatabaseName
                                   , TraceColumns.LoginName
                                   , TraceColumns.ApplicationName, TraceColumns.RequestID, TraceColumns.GUID));
            trace.Events.Add(new EventConfig(TraceEvents.TSQL.PrepareSQL,
                                  TraceColumns.TextData, TraceColumns.LoginName,
                                  TraceColumns.CPU, TraceColumns.Reads,
                                  TraceColumns.Writes, TraceColumns.Duration,
                                  TraceColumns.SPID
                                  , TraceColumns.StartTime, TraceColumns.EndTime
                                  , TraceColumns.DatabaseName
                                  , TraceColumns.LoginName
                                  , TraceColumns.ApplicationName, TraceColumns.RequestID, TraceColumns.GUID));
            trace.Events.Add(new EventConfig(TraceEvents.TSQL.SQLBatchCompleted,
                                       TraceColumns.TextData,
                                       TraceColumns.LoginName,
                                       TraceColumns.CPU,
                                       TraceColumns.Reads,
                                       TraceColumns.Writes,
                                       TraceColumns.Duration,
                                       TraceColumns.SPID,
                                       TraceColumns.StartTime,
                                       TraceColumns.EndTime,
                                       TraceColumns.DatabaseName,
                                       TraceColumns.ApplicationName, TraceColumns.RequestID, TraceColumns.GUID));
            trace.Events.Add(new EventConfig(TraceEvents.StoredProcedures.RPCCompleted,
                                   TraceColumns.TextData, TraceColumns.LoginName,
                                   TraceColumns.CPU, TraceColumns.Reads,
                                   TraceColumns.Writes, TraceColumns.Duration,
                                   TraceColumns.SPID
                                   , TraceColumns.StartTime, TraceColumns.EndTime
                                   , TraceColumns.DatabaseName
                                   , TraceColumns.ObjectName
                                   , TraceColumns.ApplicationName, TraceColumns.RequestID, TraceColumns.GUID));
            config.Traces.Add(trace);
            var instAudit = new SqlInstanceAuditor(config.Traces.First());
            instAudit.Start();
            Console.ReadKey();
        }
    }
}
