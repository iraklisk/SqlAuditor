using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SqlAuditor.Config
{
    [Serializable]
    public class AuditConfig
    {
        public List<TraceConfig> Traces { get; set; }
        public AuditConfig()
        {
            Traces = new List<TraceConfig>();
        }

        public static AuditConfig Load(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AuditConfig));
            using (TextReader reader = new StreamReader(filename))
            {
                return serializer.Deserialize(reader) as AuditConfig;
            }
        }

        public void Save(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AuditConfig));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
}