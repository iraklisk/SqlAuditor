using SqlAuditor.Properties;
using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlAuditor
{
   public class DBLogger : ITraceObserver
    {
        SqlConnection conn;
        private TraceContext context;
        private const string DbTable = "SqlAuditor_EventsLog";
        private string CreateLogTableIfNotExistsQuery()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("if not exists (select * from sysobjects where name='{0}' and xtype='U')\n", DbTable);
            sb.AppendFormat("CREATE TABLE {0}(\n", DbTable);
            sb.AppendLine("[ID] [uniqueidentifier] NOT NULL,");
            sb.AppendLine("[EVENTDATETIME] [datetime] NOT NULL,");
            foreach (var col in context.SqlTraceColumns.Values)
            {
                sb.AppendFormat("[{0}] {1} NULL,\n", col.Name, col.DbType.ToString() + (col.DbType == SqlDbType.NVarChar ? "(" + col.MaxLength + ")" : ""));
            }
            sb.AppendLine(")");
            return sb.ToString();
        }

        private SqlCommand CreateInsertEventCommand(TraceEvent evt)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("INSERT INTO [dbo].[{0}]\n",DbTable);
           sb.AppendLine("([ID]");
           sb.AppendLine(",[EVENTDATETIME]");
           foreach (var col in evt.Values.Keys)
           {
               sb.AppendFormat(",[{0}]\n",context.SqlTraceColumns[col].Name);
           }
           sb.AppendLine(") VALUES (");
           sb.AppendLine("newid()");
           sb.AppendLine(",getdate()");
           foreach (var col in evt.Values.Keys)
           {
               sb.AppendFormat(",@{0}\n", context.SqlTraceColumns[col].Name);
           }
           sb.AppendLine(")");

           SqlCommand cmd = new SqlCommand(sb.ToString());
           foreach (var col in evt.Values.Keys)
           {
               cmd.Parameters.Add("@" + context.SqlTraceColumns[col].Name, context.SqlTraceColumns[col].DbType).Value = evt[col];
           }
           return cmd;

        }
       
        public void Init(TraceContext context)
        {
            this.context = context;
            conn = new SqlConnection(context.Trace.Instance.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(CreateLogTableIfNotExistsQuery(), conn);
            cmd.ExecuteNonQuery();
        }
        public void EventReceived(Trace.TraceEvent traceEvent)
        {
            SqlCommand cmd = CreateInsertEventCommand(traceEvent);
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
        }


    }
}
