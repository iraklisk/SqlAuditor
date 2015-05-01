using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Config
{
    [Serializable]
    public class AuditConfig
    {
        public List<TraceConfig> Traces { get; private set; }
        public AuditConfig()
        {
            Traces = new List<TraceConfig>();
        }
    }
}