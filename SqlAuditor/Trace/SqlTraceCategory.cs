using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor.Trace
{
    public class SqlTraceCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SqlTraceCategory(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
