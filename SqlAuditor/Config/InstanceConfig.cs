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
        public string DataSource { get; private set; }
        public string Username { get; private set; }

        public string Password { get; private set; }

        public string LogDB { get; private set; }
        public bool IntegratedSecurity { get; private set; }
        public InstanceConfig(string dataSource, string username, string password, string logDB)
        {
            this.DataSource = dataSource;
            this.Username = username;
            this.Password = password;
            this.IntegratedSecurity = false;
            this.LogDB = logDB;
        }

        public InstanceConfig(string dataSource, string logDB)
        {
            this.DataSource = dataSource;
            this.IntegratedSecurity = true;
            this.LogDB = logDB;
        }

        public string ConnectionString
        {
            get {
                var sqlConnBuilder = new SqlConnectionStringBuilder();
                sqlConnBuilder.ApplicationName = "SqlAuditor";
                sqlConnBuilder.DataSource = DataSource;
                sqlConnBuilder.IntegratedSecurity = IntegratedSecurity;
                sqlConnBuilder.InitialCatalog = LogDB;
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
