using SqlAuditor.Config;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace SqlAuditor.Trace
{
    public class TraceContext
    {
        public TraceConfig Trace { get; set; }
        public Dictionary<int, SqlTraceEvent> SqlTraceEvents { get; set; }

        public Dictionary<int, SqlTraceColumn> SqlTraceColumns { get; set; }

        public Dictionary<int, SqlTraceCategory> SqlTraceCategories { get; set; }

        public List<ITraceObserver> TraceObservers { get; set; }

        public TraceContext(TraceConfig trace, List<ITraceObserver> observers)
        {
            this.Trace = trace;
            this.TraceObservers = observers;
            this.SqlTraceColumns = new Dictionary<int, SqlTraceColumn>();
            this.SqlTraceEvents = new Dictionary<int, SqlTraceEvent>();
            this.SqlTraceCategories = new Dictionary<int, SqlTraceCategory>();
            LoadSqlTraceEntities();
        }

        private SqlDbType GetSqlDbType(string typename)
        {
            switch (typename)
            {
                case "int":
                    return SqlDbType.Int;
                case "bigint":
                    return SqlDbType.BigInt;
                case "binary":
                    return SqlDbType.Binary;
                case "text":
                    return SqlDbType.Text;
                case "nvarchar":
                    return SqlDbType.NVarChar;
                case "uniqueidentifier":
                    return SqlDbType.UniqueIdentifier;
                case "image":
                    return SqlDbType.Image;
                case "datetime":
                    return SqlDbType.DateTime;
                default:
                    return SqlDbType.NVarChar;
            }
        }
        private void LoadSqlTraceEntities()
        {
            using (SqlConnection conn = new SqlConnection(Trace.Instance.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("select * from sys.trace_columns", conn))
                {
                    using (SqlDataReader da = cmd.ExecuteReader())
                    {
                        while (da.Read())
                        {
                            var col = new SqlTraceColumn(da.GetInt16(0), da.GetString(1), GetSqlDbType(da.GetString(2)), da.GetInt32(3), da.GetBoolean(4));
                            SqlTraceColumns.Add(col.Id, col);
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("select * from sys.trace_events", conn))
                {
                    using (SqlDataReader da = cmd.ExecuteReader())
                    {
                        while (da.Read())
                        {
                            var evt = new SqlTraceEvent(da.GetInt16(0), da.GetString(2), da.GetInt16(1));
                            SqlTraceEvents.Add(evt.Id, evt);
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("select * from sys.trace_categories", conn))
                {
                    using (SqlDataReader da = cmd.ExecuteReader())
                    {
                        while (da.Read())
                        {
                            var ctgr = new SqlTraceCategory(da.GetInt16(0), da.GetString(1));
                            SqlTraceCategories.Add(ctgr.Id, ctgr);
                        }
                    }
                }
                using (SqlCommand cmd = new SqlCommand("select * from sys.trace_subclass_values", conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var subclassvalue = new SqlTraceSubClassValue(dr.GetInt16(0), dr.GetInt16(1), dr.GetString(2), dr.GetInt16(3));

                            if (!SqlTraceEvents[subclassvalue.EventId].SubClassValues.ContainsKey(subclassvalue.ColumnId))
                            {
                                SqlTraceEvents[subclassvalue.EventId].SubClassValues.Add(subclassvalue.ColumnId, new Dictionary<int, SqlTraceSubClassValue>());
                            }
                            SqlTraceEvents[subclassvalue.EventId].SubClassValues[subclassvalue.ColumnId].Add(subclassvalue.Value, subclassvalue);
                            SqlTraceColumns[subclassvalue.ColumnId].HasSubClassValues = true;
                        }
                    }
                }
                conn.Close();
            }


        }

    }
}
