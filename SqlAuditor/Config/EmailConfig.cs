using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SqlAuditor.Config
{
    [Serializable]
    public class EmailConfig
    {
        public string Username { get; set; }
        public string Password {get;set;}
        public int Port { get; set; }
        public string Server { get; set; }
        public bool UseSSL { get; set; }
        public bool Enabled { get; set; }
        public string EmailAddress { get; set; }
        public List<string> Receipients { get; set; }
        public List<int> Events { get; set; }

        public EmailConfig()
        {
            Enabled = false;
            this.Port = 25;
            this.UseSSL = false;
            this.Server = "localhost";
            this.Receipients = new List<string>();
            this.Events = new List<int>();
        }
    }
}