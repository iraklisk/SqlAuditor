using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Config
{
    [Serializable]
    public class EventConfig
    {
        public int Event { get; private set; }

        public int[] Columns { get; private set; }

        public EventConfig(int profilerEvent, params int[] columns )
        {
            this.Event = profilerEvent;
            this.Columns = columns;
        }

    }
}
