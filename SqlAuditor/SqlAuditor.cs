using SqlAuditor.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor
{
    public class SqlAuditor
    {
        private AuditConfig config;
        public SqlAuditor(AuditConfig config)
        {
            this.config = config;
        }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }
}
