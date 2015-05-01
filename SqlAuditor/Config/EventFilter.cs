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
        public int Column { get; private set; }
        public object Value { get; private set; }
        public int Operator { get; private set; }

        public EventFilter(int column, object value, int op)
        {
            this.Column = column;
            this.Value = value;
            this.Operator = op;
        }
    }
}
