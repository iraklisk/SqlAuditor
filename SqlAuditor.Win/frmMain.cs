using MetroFramework.Controls;
using MetroFramework.Forms;
using SqlAuditor.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SqlAuditor.Win
{
    public partial class frmMain : MetroForm
    {
        private AuditConfig auditConfig;

        public frmMain()
        {
            InitializeComponent();
        }

        private void LoadConfig()
        {
            if (!File.Exists("Config.xml"))
            {
                auditConfig = new AuditConfig();
            }
            else
            {
                auditConfig = AuditConfig.Load("Config.xml");
            }
        }

        void ReloadTraceInstances()
        {
            flInstances.SuspendDrawing();
            flInstances.Controls.Clear();
            foreach (var trace in auditConfig.Traces)
            {
                var mtile = new MetroTile();

                mtile.ActiveControl = null;
                mtile.Location = new System.Drawing.Point(171, 3);
                mtile.Size = new System.Drawing.Size(162, 69);
                mtile.TabIndex = 4;
                mtile.Text = trace.Instance.DataSource;
                mtile.UseSelectable = true;
                mtile.Tag = trace;
                mtile.Click += mtile_Click;
                this.flInstances.Controls.Add(mtile);
            }
            flInstances.ResumeDrawing();
        }

        void mtile_Click(object sender, EventArgs e)
        {
         ShowSettings(false,((sender as MetroTile).Tag as TraceConfig));  
        }
        private void SaveConfig()
        {
            auditConfig.Save("Config.xml");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadConfig();
            ReloadTraceInstances();
        }

        private void ShowSettings(bool isnew, TraceConfig trace)
        {
            if (new frmSettings(isnew, trace).ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                auditConfig.Save("Config.xml");
            }
            else
            {
                LoadConfig();
            }
            ReloadTraceInstances();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            ShowSettings(true, new TraceConfig(new InstanceConfig("localhost", "SqlAudit")));
        }

    }
}
