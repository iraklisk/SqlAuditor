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
        public EncryptionOptions Encryption { get; set; }

        public AuditConfig()
        {
            Traces = new List<TraceConfig>();
            Encryption = EncryptionOptions.None;
        }

        public static AuditConfig Load(string filename)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AuditConfig));
            using (TextReader reader = new StreamReader(filename))
            {
                var conf = serializer.Deserialize(reader) as AuditConfig;
                Decrypt(conf);
                return conf;
            }
        }

        public void Save(string filename)
        {
            Encrypt(this);
            XmlSerializer serializer = new XmlSerializer(typeof(AuditConfig));
            using (TextWriter writer = new StreamWriter(filename))
            {
                serializer.Serialize(writer, this);
            }
            Decrypt(this);
        }

        static void Decrypt(AuditConfig conf)
        {
            conf.Traces.ForEach((trace) => {
                trace.Instance.Password = EncryptionUtils.Decrypt(conf)(trace.Instance.Password);
                trace.EmailConfig.Password = EncryptionUtils.Decrypt(conf)(trace.EmailConfig.Password);
            });
            
        }

        static void Encrypt(AuditConfig conf)
        {
            conf.Traces.ForEach((trace) =>
            {
                trace.Instance.Password = EncryptionUtils.Encrypt(conf)(trace.Instance.Password);
                trace.EmailConfig.Password = EncryptionUtils.Encrypt(conf)(trace.EmailConfig.Password);
            });
        }
    }
}