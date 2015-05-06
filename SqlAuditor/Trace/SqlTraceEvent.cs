using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor.Trace
{
    public class SqlTraceEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Dictionary<int, Dictionary<int,SqlTraceSubClassValue>> SubClassValues { get; set; }
        public SqlTraceEvent(int id, string name, int categoryId)
        {
            this.Id = id;
            this.Name = name;
            this.CategoryId = categoryId;
            this.SubClassValues = new Dictionary<int, Dictionary<int, SqlTraceSubClassValue>>();
        }
    }
}
