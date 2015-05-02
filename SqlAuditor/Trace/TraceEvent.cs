using SqlAuditor.Config;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlAuditor.Trace
{
    public class TraceEvent
    {

        public Dictionary<int, object> Values { get; set; }
        private TraceContext context;
        internal TraceEvent(TraceContext context)
        {
            this.context = context;
            this.Instance = context.Trace.Instance;
            Values = new Dictionary<int, object>();
        }
        public InstanceConfig Instance { get; set; }
        public string GetFormattedData(int idx, string format)
        {
            switch (context.SqlTraceColumns[idx].DbType)
            {
                case SqlDbType.BigInt:
                    return GetLong(idx).ToString(format);
                case SqlDbType.DateTime:
                    DateTime d = GetDateTime(idx);
                    return 1 == d.Year ? "" : d.ToString(format);
                case SqlDbType.Binary:
                case SqlDbType.Image:
                    return GetByte(idx).ToString();
                case SqlDbType.Int:
                    return GetInt(idx).ToString(format);
                case SqlDbType.NVarChar:
                    return GetString(idx);
                case  SqlDbType.UniqueIdentifier:
                    return GetGuid(idx).ToString();
            }
            return null;
        }

        private int GetInt(int idx)
        {
            if (!Values.ContainsKey(idx)) return 0;
            return Values[idx] == null ? 0 : (int)Values[idx];
        }

        private long GetLong(int idx)
        {
            if (!Values.ContainsKey(idx)) return 0;
            return Values[idx] == null ? 0 : (long)Values[idx];
        }

        private string GetString(int idx)
        {
            if (!Values.ContainsKey(idx)) return "";
            return Values[idx] == null ? "" : (string)Values[idx];
        }

        private byte[] GetByte(int idx)
        {
            return Values.ContainsKey(idx) ? (byte[])Values[idx] : new byte[1];
        }

        private DateTime GetDateTime(int idx)
        {
            return Values.ContainsKey(idx) ? (DateTime)Values[idx] : new DateTime(0);
        }

        private Guid GetGuid(int idx)
        {
            return Values.ContainsKey(idx) ? (Guid)Values[idx] : Guid.Empty;
        }

        public object this[int column]
        {
            get
            {
                if (Values.ContainsKey(column))
                    return Values[column];
                else return null;
            }
            set
            {
                Values.Add(column, value);
            }
        }
        public string TextData { get { return GetString(TraceColumns.TextData); } }
        public byte[] BinaryData { get { return GetByte(TraceColumns.BinaryData); } }
        public int DatabaseID { get { return GetInt(TraceColumns.DatabaseID); } }
        public long TransactionID { get { return GetLong(TraceColumns.TransactionID); } }
        public int LineNumber { get { return GetInt(TraceColumns.LineNumber); } }
        public string NTUserName { get { return GetString(TraceColumns.NTUserName); } }
        public string NTDomainName { get { return GetString(TraceColumns.NTDomainName); } }
        public string HostName { get { return GetString(TraceColumns.HostName); } }
        public int ClientProcessID { get { return GetInt(TraceColumns.ClientProcessID); } }
        public string ApplicationName { get { return GetString(TraceColumns.ApplicationName); } }
        public string LoginName { get { return GetString(TraceColumns.LoginName); } }
        public int SPID { get { return GetInt(TraceColumns.SPID); } }
        public long Duration { get { return GetLong(TraceColumns.Duration); } }
        public DateTime StartTime { get { return GetDateTime(TraceColumns.StartTime); } }
        public DateTime EndTime { get { return GetDateTime(TraceColumns.EndTime); } }
        public long Reads { get { return GetLong(TraceColumns.Reads); } }
        public long Writes { get { return GetLong(TraceColumns.Writes); } }
        public int CPU { get { return GetInt(TraceColumns.CPU); } }
        public long Permissions { get { return GetLong(TraceColumns.Permissions); } }
        public int Severity { get { return GetInt(TraceColumns.Severity); } }
        public int EventSubClass { get { return GetInt(TraceColumns.EventSubClass); } }
        public int ObjectID { get { return GetInt(TraceColumns.ObjectID); } }
        public int Success { get { return GetInt(TraceColumns.Success); } }
        public int IndexID { get { return GetInt(TraceColumns.IndexID); } }
        public int IntegerData { get { return GetInt(TraceColumns.IntegerData); } }
        public string ServerName { get { return GetString(TraceColumns.ServerName); } }
        public int EventClass { get { return GetInt(TraceColumns.EventClass); } }
        public int ObjectType { get { return GetInt(TraceColumns.ObjectType); } }
        public int NestLevel { get { return GetInt(TraceColumns.NestLevel); } }
        public int State { get { return GetInt(TraceColumns.State); } }
        public int Error { get { return GetInt(TraceColumns.Error); } }
        public int Mode { get { return GetInt(TraceColumns.Mode); } }
        public int Handle { get { return GetInt(TraceColumns.Handle); } }
        public string ObjectName { get { return GetString(TraceColumns.ObjectName); } }
        public string DatabaseName { get { return GetString(TraceColumns.DatabaseName); } }
        public string FileName { get { return GetString(TraceColumns.FileName); } }
        public string OwnerName { get { return GetString(TraceColumns.OwnerName); } }
        public string RoleName { get { return GetString(TraceColumns.RoleName); } }
        public string TargetUserName { get { return GetString(TraceColumns.TargetUserName); } }
        public string DBUserName { get { return GetString(TraceColumns.DBUserName); } }
        public byte[] LoginSid { get { return GetByte(TraceColumns.LoginSid); } }
        public string TargetLoginName { get { return GetString(TraceColumns.TargetLoginName); } }
        public byte[] TargetLoginSid { get { return GetByte(TraceColumns.TargetLoginSid); } }
        public int ColumnPermissions { get { return GetInt(TraceColumns.ColumnPermissions); } }
        public string LinkedServerName { get { return GetString(TraceColumns.LinkedServerName); } }
        public string ProviderName { get { return GetString(TraceColumns.ProviderName); } }
        public string MethodName { get { return GetString(TraceColumns.MethodName); } }
        public long RowCounts { get { return GetLong(TraceColumns.RowCounts); } }
        public int RequestID { get { return GetInt(TraceColumns.RequestID); } }
        public long XactSequence { get { return GetLong(TraceColumns.XactSequence); } }
        public long EventSequence { get { return GetLong(TraceColumns.EventSequence); } }
        public long BigintData1 { get { return GetLong(TraceColumns.BigintData1); } }
        public long BigintData2 { get { return GetLong(TraceColumns.BigintData2); } }
        public Guid GUID { get { return GetGuid(TraceColumns.GUID); } }
        public int IntegerData2 { get { return GetInt(TraceColumns.IntegerData2); } }
        public long ObjectID2 { get { return GetLong(TraceColumns.ObjectID2); } }
        public int Type { get { return GetInt(TraceColumns.Type); } }
        public int OwnerID { get { return GetInt(TraceColumns.OwnerID); } }
        public string ParentName { get { return GetString(TraceColumns.ParentName); } }
        public int IsSystem { get { return GetInt(TraceColumns.IsSystem); } }
        public int Offset { get { return GetInt(TraceColumns.Offset); } }
        public int SourceDatabaseID { get { return GetInt(TraceColumns.SourceDatabaseID); } }
        public byte[] SqlHandle { get { return GetByte(TraceColumns.SqlHandle); } }
        public string SessionLoginName { get { return GetString(TraceColumns.SessionLoginName); } }
        public byte[] PlanHandle { get { return GetByte(TraceColumns.PlanHandle); } }

        public int GroupID { get { return GetInt(TraceColumns.GroupID); } }
    }
}
