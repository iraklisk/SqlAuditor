using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SqlAuditor.Trace
{
    public class SqlTraceColumn
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public SqlDbType DbType { get; set; }
        public int MaxLength { get; set; }
        public bool IsFilterable { get; set; }
        public bool HasSubClassValues { get; set; }
        public SqlTraceColumn(int id, string name, SqlDbType dbType, int maxLength, bool isFilterable)
        {
            this.Id = id;
            this.Name = name;
            this.DbType = dbType;
            this.MaxLength = maxLength;
            this.IsFilterable = IsFilterable;
            HasSubClassValues = false;
        }
    }
}
