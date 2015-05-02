using SqlAuditor.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Trace
{
    public class TraceConnection : IDisposable
    {
        private SqlConnection connection;
        private int traceid;
        private SqlDataReader dreader;
        private bool hasResults;
        private Dictionary<SqlDbType, Action<TraceEvent, int>> DecodeFunctions;
        private InstanceConfig instance;
        private TraceContext context;
        public TraceConnection(TraceContext context)
        {
            this.context = context;
            this.instance = context.Trace.Instance;
            connection = new SqlConnection(instance.ConnectionString);
            traceid = -1;
            Open();
            DecodeFunctions = new Dictionary<SqlDbType, Action<TraceEvent, int>>();
            DecodeFunctions.Add(SqlDbType.Int, SetIntColumn);
            DecodeFunctions.Add(SqlDbType.BigInt, SetLongColumn);
            DecodeFunctions.Add(SqlDbType.DateTime, SetDateTimeColumn);
            DecodeFunctions.Add(SqlDbType.NVarChar, SetStringColumn);
            DecodeFunctions.Add(SqlDbType.Image, SetByteColumn);
            DecodeFunctions.Add(SqlDbType.Text, SetStringColumn);
            DecodeFunctions.Add(SqlDbType.UniqueIdentifier, SetGuidColumn);
        }

        private void Open()
        {
            connection.Open();
        }

        private void Close()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public void CreateTrace()
        {
            // Execute sp_trace_create
            // https://msdn.microsoft.com/en-us/library/ms190362.aspx
            SqlCommand cmd = new SqlCommand("sp_trace_create", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@traceid", SqlDbType.Int).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@options", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@trace_file", SqlDbType.NVarChar, 245).Value = DBNull.Value;
            cmd.Parameters.Add("@maxfilesize", SqlDbType.BigInt).Value = DBNull.Value;
            cmd.Parameters.Add("@stoptime", SqlDbType.DateTime).Value = DBNull.Value;
            cmd.Parameters.Add("@filecount", SqlDbType.Int).Value = DBNull.Value;
            cmd.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int result = (int)cmd.Parameters["@result"].Value;
            traceid = result != 0 ? -result : (int)cmd.Parameters["@traceid"].Value;
        }


        private void SetTraceStatus(int status)
        {
            // Execute sp_trace_setstatus
            // https://msdn.microsoft.com/en-us/library/ms176034.aspx
            var conn = new SqlConnection(instance.ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_trace_setstatus", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@traceid", SqlDbType.Int).Value = traceid;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void CloseTrace()
        {
            SetTraceStatus(2);
        }

        public void StopTrace()
        {
            SetTraceStatus(0);
        }

        private void CreateTraceReader()
        {
            // Execute sp_trace_getdata
            SqlCommand cmd = new SqlCommand("sp_trace_getdata", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandTimeout = 0;
            cmd.Parameters.Add("@traceid", SqlDbType.Int).Value = traceid;
            cmd.Parameters.Add("@records", SqlDbType.Int).Value = 0;
            dreader = cmd.ExecuteReader(CommandBehavior.SingleResult);
        }

        private bool ReadTrace()
        {

            hasResults = dreader.Read();
            return hasResults;
        }

        public bool HasResults { get { return hasResults; } }
        public void StartTrace()
        {
            SetTraceStatus(1);
            CreateTraceReader();
            ReadTrace();
        }
        private readonly byte[] m_B16 = new byte[16];
        private readonly byte[] m_B8 = new byte[8];
        private readonly byte[] m_B2 = new byte[2];
        private readonly byte[] m_B4 = new byte[4];

        private delegate void SetEventDelegate(TraceEvent evt, int columnid);
        readonly SetEventDelegate[] m_Delegates = new SetEventDelegate[66];
        private void SetDateTimeColumn(TraceEvent evt, int columnid)
        {
            //2 byte - year
            //2 byte - month
            //2 byte - ???
            //2 byte - day
            //2 byte - hour
            //2 byte - min
            //2 byte - sec
            //2 byte - msec
            dreader.GetBytes(2, 0, m_B16, 0, 16);
            int year = m_B16[0] | m_B16[1] << 8;
            int month = m_B16[2] | m_B16[3] << 8;
            int day = m_B16[6] | m_B16[7] << 8;
            int hour = m_B16[8] | m_B16[9] << 8;
            int min = m_B16[10] | m_B16[11] << 8;
            int sec = m_B16[12] | m_B16[13] << 8;
            int msec = m_B16[14] | m_B16[15] << 8;
            evt[columnid] = new DateTime(year, month, day, hour, min, sec, msec);

        }

        private void SetByteColumn(TraceEvent evt, int columnid)
        {
            byte[] b = new byte[(int)dreader[1]];
            evt[columnid] = b;
        }

        private void SetStringColumn(TraceEvent evt, int columnid)
        {
            evt[columnid] = Encoding.Unicode.GetString((byte[])dreader[2]);
        }
        private void SetGuidColumn(TraceEvent evt, int columnid)
        {
            evt[columnid] = new Guid(Encoding.Unicode.GetString((byte[])dreader[2]));
        }

        private void SetIntColumn(TraceEvent evt, int columnid)
        {
            dreader.GetBytes(2, 0, m_B4, 0, 4);
            evt[columnid] = ToInt32(m_B4);
        }

        private void SetLongColumn(TraceEvent evt, int columnid)
        {
            dreader.GetBytes(2, 0, m_B8, 0, 8);
            evt[columnid] = ToInt64(m_B8);
        }

        private long ToInt64(byte[] value)
        {
            int i1 = (value[0]) | (value[1] << 8) | (value[2] << 16) | (value[3] << 24);
            int i2 = (value[4]) | (value[5] << 8) | (value[6] << 16) | (value[7] << 24);
            return (uint)i1 | ((long)i2 << 32);
        }
        private int ToInt32(byte[] value)
        {
            return (value[0]) | (value[1] << 8) | (value[2] << 16) | (value[3] << 24);
        }
        private int ToInt16(byte[] value)
        {
            return (value[0]) | (value[1] << 8);
        }
        public TraceEvent Next()
        {
            if (!hasResults) return null;
            int columnid = (int)dreader[0];
            //skip to begin of new event
            while (columnid != 65526 && ReadTrace() && hasResults)
            {
                columnid = (int)dreader[0];
            }
            //start of new event
            if (columnid != 65526) return null;
            if (!hasResults) return null;
            //get potential event class
            dreader.GetBytes(2, 0, m_B2, 0, 2);
            int eventClass = ToInt16(m_B2);

            //we got new event
            if (eventClass >= 0 && eventClass < 255)
            {
                TraceEvent evt = new TraceEvent(context);
                evt[27] = eventClass;
                while (ReadTrace())
                {
                    columnid = (int)dreader[0];
                    if (columnid > 64) return evt;
                    DecodeFunctions[context.SqlTraceColumns[columnid].DbType](evt, columnid);
                }
            }
            ReadTrace();
            return null;
        }

        public void SetEvent(int eventId, params int[] columns)
        {
            // Execute sp_trace_setevent
            // https://msdn.microsoft.com/en-us/library/ms186265.aspx
            SqlCommand cmd = new SqlCommand("sp_trace_setevent", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@traceid", SqlDbType.Int).Value = traceid;
            cmd.Parameters.Add("@eventid", SqlDbType.Int).Value = eventId;
            SqlParameter p = cmd.Parameters.Add("@columnid", SqlDbType.Int);
            cmd.Parameters.Add("@on", SqlDbType.Bit).Value = 1;
            foreach (int i in columns)
            {
                p.Value = i;
                cmd.ExecuteNonQuery();
            }
        }
        public void SetFilter(int columnID, int logicalOperator, int comparisonOperator, object value)
        {
            // Execute sp_trace_setfilter
            // https://msdn.microsoft.com/en-us/library/ms174404.aspx
            SqlCommand cmd = new SqlCommand("sp_trace_setfilter", connection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@traceid", SqlDbType.Int).Value = traceid;
            cmd.Parameters.Add("@columnid", SqlDbType.Int).Value = columnID;
            cmd.Parameters.Add("@logical_operator", SqlDbType.Int).Value = logicalOperator;
            cmd.Parameters.Add("@comparison_operator", SqlDbType.Int).Value = comparisonOperator;
            switch (context.SqlTraceColumns[columnID].DbType)
            {
                case SqlDbType.Int:
                case SqlDbType.BigInt:
                case SqlDbType.DateTime:
                case SqlDbType.Image:
                case SqlDbType.Binary:
                    cmd.Parameters.Add("@value", context.SqlTraceColumns[columnID].DbType).Value = (value == null ? DBNull.Value : value);
                    break;
                case SqlDbType.NVarChar:
                case SqlDbType.Text:
                    cmd.Parameters.Add("@value", context.SqlTraceColumns[columnID].DbType).Value = (String.IsNullOrEmpty(value.ToString()) ? DBNull.Value : value);
                    break;
                case SqlDbType.UniqueIdentifier:
                    cmd.Parameters.Add("@value", SqlDbType.UniqueIdentifier).Value = (value == null || (Guid)value == Guid.Empty ? DBNull.Value : value);
                    break;
            }
            cmd.ExecuteNonQuery();

        }


        public void Dispose()
        {
            if (connection != null && connection.State != ConnectionState.Closed)
            {
                CloseTrace();
                Close();
            }
        }
    }
}
