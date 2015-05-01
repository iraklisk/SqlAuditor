using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Config
{
    [Serializable]
    public class TraceConfig
    {
        public InstanceConfig Instance { get; private set; }
        public List<EventConfig> Events { get; private set; }

        public List<EventFilter> Filters { get; private set; }
        public TraceConfig(InstanceConfig instance)
        {
            this.Instance = instance;
            this.Events = new List<EventConfig>();
            this.Filters = new List<EventFilter>();
        }
    }
}
