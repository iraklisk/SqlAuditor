using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SqlAuditor.Service
{
    public partial class SqlAuditorSrv : ServiceBase
    {
        public SqlAuditorSrv()
        {
            InitializeComponent();
        }
        private SqlAuditor auditor;
        protected override void OnStart(string[] args)
        {
            auditor = new SqlAuditor(Config.AuditConfig.Load("Config.xml"));
            auditor.RegisterObserver(typeof(DBLogger));
            auditor.Start();
            auditor.WaitAll();
        }

        protected override void OnStop()
        {
            auditor.Stop();
        }
    }
}
