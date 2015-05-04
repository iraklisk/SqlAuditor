using MetroFramework;
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
                auditConfig.Encryption = EncryptionOptions.Normal;
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
                mtile.Size = new System.Drawing.Size(160, 70);
                mtile.TabIndex = 4;
                mtile.Text = trace.Instance.DataSource;
                mtile.UseSelectable = true;
                mtile.Tag = trace;
                mtile.MouseUp += mtile_MouseUp;
                this.flInstances.Controls.Add(mtile);
            }
            flInstances.ResumeDrawing();
        }

        void mtile_MouseUp(object sender, MouseEventArgs e)
        {
            var mtile = (sender as MetroTile);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ShowSettings(false, mtile.Tag as TraceConfig);
            }
            else
            {
                ctxmInstance.Show(mtile, e.Location);
            }
        }


        private void SaveConfig()
        {
            auditConfig.Save("Config.xml");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadConfig();
            ReloadTraceInstances();
            mtcMain.SelectedTab = mtpHome;
        }

        private void ShowSettings(bool isnew, TraceConfig trace)
        {
            var frmSett = new frmSettings(isnew, trace);
            if (frmSett.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if(isnew)auditConfig.Traces.Add(frmSett.Trace);
                SaveConfig();
            }
            else
            {
                LoadConfig();
            }
            ReloadTraceInstances();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

            ShowSettings(true, new TraceConfig(new InstanceConfig("localhost", "SqlAuditor")));
        }

        private void ctxItmEdit_Click(object sender, EventArgs e)
        {
            var t = sender as ToolStripMenuItem;
            var mtile = (t.Owner as MetroContextMenu).SourceControl as MetroTile;
            var trace = mtile.Tag as TraceConfig;
            ShowSettings(false, trace);
        }

        private void ctxItmTest_Click(object sender, EventArgs e)
        {
            var t = sender as ToolStripMenuItem;
            var mtile = (t.Owner as MetroContextMenu).SourceControl as MetroTile;
            var trace = mtile.Tag as TraceConfig;
            (new frmTest(trace)).ShowDialog();
        }

        private void ctxItmDelete_Click(object sender, EventArgs e)
        {
            var t = sender as ToolStripMenuItem;
            var mtile = (t.Owner as MetroContextMenu).SourceControl as MetroTile;
            var trace = mtile.Tag as TraceConfig;
            var res = MetroMessageBox.Show(this, String.Format("Do you wan't to delete {0}?", trace.Instance.DataSource), "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                auditConfig.Traces.Remove(trace);
                SaveConfig();
                ReloadTraceInstances();
            }
        }

    }
}
