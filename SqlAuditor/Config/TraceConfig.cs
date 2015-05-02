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
        public InstanceConfig Instance { get; set; }
        public List<EventConfig> Events { get; set; }

        public List<EventFilter> Filters { get; set; }

        internal TraceConfig()
        {

        }
        public TraceConfig(InstanceConfig instance)
        {
            this.Instance = instance;
            this.Events = new List<EventConfig>();
            this.Filters = new List<EventFilter>();
        }
    }
}
