using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Config
{
    [Serializable]
    public class InstanceConfig
    {
        public string DataSource { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }

        public string AuditDB { get; set; }
        public bool IntegratedSecurity { get; set; }

        internal InstanceConfig() { }
        public InstanceConfig(string dataSource, string username, string password, string auditDB)
        {
            this.DataSource = dataSource;
            this.Username = username;
            this.Password = password;
            this.IntegratedSecurity = false;
            this.AuditDB = auditDB;
        }

        public InstanceConfig(string dataSource, string auditDB)
        {
            this.DataSource = dataSource;
            this.IntegratedSecurity = true;
            this.AuditDB = auditDB;
        }

        public string ConnectionString
        {
            get {
                var sqlConnBuilder = new SqlConnectionStringBuilder();
                sqlConnBuilder.ApplicationName = "SqlAuditor";
                sqlConnBuilder.DataSource = DataSource;
                sqlConnBuilder.IntegratedSecurity = IntegratedSecurity;
                sqlConnBuilder.InitialCatalog = AuditDB;
                if (!IntegratedSecurity)
                {
                    sqlConnBuilder.UserID = Username;
                    sqlConnBuilder.Password = Password;
                }
                return sqlConnBuilder.ConnectionString;
            }
        }
    }
}
