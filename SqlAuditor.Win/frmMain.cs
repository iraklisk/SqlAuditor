using DoddleReport;
using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using SqlAuditor.Config;
using SqlAuditor.Trace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            cbInstances.BeginUpdate();
            cbInstances.Items.Clear();
            flInstances.Controls.Clear();
            foreach (var trace in auditConfig.Traces)
            {
                cbInstances.Items.Add(trace.Instance.DataSource);
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
            cbInstances.EndUpdate();
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
                if (isnew) auditConfig.Traces.Add(frmSett.Trace);
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

        private void AddColumn(string name, string title)
        {
            var col = new DataGridViewTextBoxColumn();
            col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            col.Resizable = DataGridViewTriState.True;
            col.HeaderText = title;
            col.MinimumWidth = 60;
            col.Name = name;
            col.ReadOnly = true;
            grdEvents.Columns.Add(col);
        }

        private DataSet fetchData(TraceContext context, List<int> columns)
        {
            var ds = new DataSet();
            using (var conn = new SqlConnection(context.Trace.Instance.ConnectionString))
            {
                conn.Open();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("SELECT");
                sb.AppendLine("EVENTCATEGORY as EventCategory");
                sb.AppendLine(",EVENTNAME as EventName");
                sb.AppendLine(",EVENTDATETIME as EventaDateTime");
                columns.ForEach((c) =>
                {
                    if (context.SqlTraceColumns[c].HasSubClassValues)
                        sb.AppendFormat(",[{0}_VALUE] as [{0}]\n", context.SqlTraceColumns[c].Name);
                    else sb.AppendFormat(",[{0}]\n", context.SqlTraceColumns[c].Name);
                });
                sb.AppendLine("FROM SqlAuditor_EventsLog");
                sb.AppendLine("WHERE");
                sb.AppendLine("CONVERT(DATE,EVENTDATETIME) BETWEEN @DTFROM and @DTTO");
                using (SqlCommand cmd = new SqlCommand(sb.ToString(), conn))
                {
                    cmd.Parameters.Add("@DTFROM", SqlDbType.Date).Value = dtFrom.Value.Date;
                    cmd.Parameters.Add("@DTTO", SqlDbType.Date).Value = dtTo.Value.Date;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds);
                    }
                }
                conn.Close();
            }
            return ds;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cbInstances.Text))
            {
                var trace = auditConfig.Traces.First((t) => t.Instance.DataSource == cbInstances.Text);
                var context = new TraceContext(trace, (new ITraceObserver[] { }).ToList());
                var columns = new List<int>();
                trace.Events.ForEach((evt) => evt.Columns.ToList().ForEach((c) =>
                {
                    if (!columns.Contains(c)) columns.Add(c);
                }));
                var ds = fetchData(context, columns);
                this.grdEvents.DataSource = ds.Tables[0];
            }
        }

        private void Export(TraceContext context, DataSet ds, IReportWriter writer, string filepath)
        {


            var report = new Report(ds.Tables[0].ToReportSource());


            // Customize the Text Fields
            report.TextFields.Title = "SqlAuditor - Events Log";
            report.TextFields.Footer = "Powered by SqlAuditor.\n" + @"http://github.com/iraklisk/SqlAuditor";
            report.TextFields.Header = String.Format("Instance: {0}\nFrom: {1}\nTo: {2}\nReport Generated: {3}", context.Trace.Instance.DataSource, dtFrom.Value.ToShortDateString(), dtTo.Value.ToShortDateString(), DateTime.Now);
            report.RenderHints.Orientation = ReportOrientation.Landscape;
            report.RenderHints.BooleanCheckboxes = true;
            using (var stream = new FileStream(filepath, FileMode.Create))
            {
                writer.WriteReport(report, stream);
            }

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                if (!String.IsNullOrEmpty(cbInstances.Text))
                {
                    sfd.Filter = "Excel File|*.xlsx|PDF|*.pdf";
                    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        var trace = auditConfig.Traces.First((t) => t.Instance.DataSource == cbInstances.Text);
                        var context = new TraceContext(trace, (new ITraceObserver[] { }).ToList());
                        var columns = new List<int>();
                        trace.Events.ForEach((evt) => evt.Columns.ToList().ForEach((c) =>
                        {
                            if (!columns.Contains(c)) columns.Add(c);
                        }));
                        var ds = fetchData(context, columns);

                        IReportWriter writer;
                        if (sfd.FileName.EndsWith(".pdf"))
                        {
                            writer = new DoddleReport.iTextSharp.PdfReportWriter();
                        }
                        else
                        {
                            writer = new DoddleReport.OpenXml.ExcelReportWriter();
                        }
                        Export(context, ds, writer, sfd.FileName);
                        if (MetroMessageBox.Show(this, "Open file?", "Open File", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                        {
                            Process.Start(sfd.FileName);
                        }
                    }
                }
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://iraklisk.github.io/SqlAuditor");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://github.com/iraklisk/SqlAuditor");
        }

        private void mtAuditViewer_Click(object sender, EventArgs e)
        {
            mtcMain.SelectedTab = mtpAuditViewe;
        }

        private void mtSettings_Click(object sender, EventArgs e)
        {
            mtcMain.SelectedTab = mtpSettings;
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Process.Start(@"http://iraklisk.github.io/SqlAuditor");
        }

        private void mtDocumentation_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://github.com/iraklisk/SqlAuditor/wiki");
        }

    }
}
