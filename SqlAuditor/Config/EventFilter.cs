using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Config
{
    [Serializable]
    public class EventFilter
    {
        public int Column { get; set; }
        public object Value { get; set; }
        public int ComparisonOperator { get; set; }
        public int LogicalOperator { get; set; }
        internal EventFilter() { }
        public EventFilter(int column, int logicalOperator, int comparisonOperator, object value)
        {
            this.Column = column;
            this.Value = value;
            this.ComparisonOperator = comparisonOperator;
            this.LogicalOperator = logicalOperator;
        }
    }
}
