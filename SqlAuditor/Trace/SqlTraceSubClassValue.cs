using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor.Trace
{
    public class SqlTraceSubClassValue
    {
        public int EventId { get; set; }
        public int ColumnId { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }

        public SqlTraceSubClassValue(int eventId, int columnId, string name, int value)
        {
            this.EventId = eventId;
            this.ColumnId = columnId;
            this.Name = name;
            this.Value = value;
        }

    }
}
