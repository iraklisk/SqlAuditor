using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using SqlAuditor.Config;
using System.Data.SqlClient;
using SqlAuditor.Trace;
using MetroFramework;

namespace SqlAuditor.Win
{
    public partial class frmSettings : MetroFramework.Forms.MetroForm
    {
        bool isnew;
        public TraceConfig Trace { get; set; }
        TraceContext context;
        public frmSettings(bool isNew, TraceConfig trace)
        {
            InitializeComponent();
            this.isnew = isNew;
            this.Trace = trace;
            InitDataBindings();
            this.lblTitle.Text = "SqlAuditor - " + trace.Instance.DataSource;
            mtcSettings.SelectedTab = mtpInstanceConfig;
        }

        private void InitDataBindings()
        {
            // Instance DataBindings
            this.txtDataSource.DataBindings.Add(new Binding("Text", Trace.Instance, "DataSource"));
            this.cbIntegratedSecurity.DataBindings.Add(new Binding("Checked", Trace.Instance, "IntegratedSecurity"));
            this.txtPassword.DataBindings.Add(new Binding("Text", Trace.Instance, "Password"));
            this.txtUserId.DataBindings.Add(new Binding("Text", Trace.Instance, "Username"));
            this.txtAuditDatabase.DataBindings.Add(new Binding("Text", Trace.Instance, "AuditDB"));
            // Email DataBindings
            this.txtEmailServer.DataBindings.Add(new Binding("Text", Trace.EmailConfig, "Server"));
            this.txtEmailUsername.DataBindings.Add(new Binding("Text", Trace.EmailConfig, "Username"));
            this.txtEmailPassword.DataBindings.Add(new Binding("Text", Trace.EmailConfig, "Password"));
            this.txtEmailPort.DataBindings.Add(new Binding("Text", Trace.EmailConfig, "Port"));
            this.txtEmailAddress.DataBindings.Add(new Binding("Text", Trace.EmailConfig, "EmailAddress"));
            this.cbEmailEnabled.DataBindings.Add(new Binding("Checked", Trace.EmailConfig, "Enabled"));
            this.cbEmailUseSSL.DataBindings.Add(new Binding("Checked", Trace.EmailConfig, "UseSSL"));
        }


        private void cbIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            lblUserId.Enabled = !cbIntegratedSecurity.Checked;
            txtUserId.Enabled = !cbIntegratedSecurity.Checked;
            lblPassword.Enabled = !cbIntegratedSecurity.Checked;
            txtPassword.Enabled = !cbIntegratedSecurity.Checked;
        }

        private Tuple<bool, Exception> CheckConnection(bool populate)
        {
            using (var conn = new SqlConnection(Trace.Instance.ConnectionString))
            {
                try
                {
                    conn.Open();
                    conn.Close();
                    if (populate) PopulateData();
                    return new Tuple<bool, Exception>(true, null);
                }
                catch (Exception ex)
                {
                    return new Tuple<bool, Exception>(false, ex);
                }
            }
        }

        private void PopulateData()
        {
            context = new TraceContext(Trace, new List<ITraceObserver>());
            grdEvents.SuspendDrawing();
            grdEvents.Rows.Clear();
            foreach (var evt in context.SqlTraceEvents.Values)
            {
                grdEvents.Rows.Add(evt.Id, context.SqlTraceCategories[evt.CategoryId].Name, evt.Name,
                    Trace.Events.Where(evcfg => evcfg.Event == evt.Id).Any(),
                    Trace.EmailConfig.Events.Contains(evt.Id));
            }
            grdEvents.ResumeDrawing();
            grdColumns.SuspendDrawing();
            grdColumns.Rows.Clear();
            foreach (var col in context.SqlTraceColumns.Values.OrderBy((c) => c.Name))
            {
                colFilterCol.Items.Add(col.Name);
                grdColumns.Rows.Add(col.Id, col.Name, Trace.Events.Where((evcfg) => evcfg.Columns.Contains(col.Id)).Any());
            }
            grdColumns.ResumeDrawing();
            grdFilters.SuspendDrawing();
            grdFilters.Rows.Clear();
            foreach (var flt in Trace.Filters)
            {
                grdFilters.Rows.Add(context.SqlTraceColumns[flt.Column].Name,
                    colLogicalOperator.Items[flt.LogicalOperator].ToString(),
                    colComparisonOperator.Items[flt.ComparisonOperator].ToString(),
                    flt.Value);
            }
            grdFilters.ResumeDrawing();

            grdEmailReceipients.SuspendDrawing();
            grdEmailReceipients.Rows.Clear();
            foreach (var email in Trace.EmailConfig.Receipients)
            {
                grdEmailReceipients.Rows.Add(email);
            }
            grdEmailReceipients.ResumeDrawing();
        }

        private void btnCheckConnection_Click(object sender, EventArgs e)
        {
            var res = CheckConnection(true);
            // SetTabsEnable(res.Item1);
            if (res.Item1)
            {
                MetroFramework.MetroMessageBox.Show(this, "Checking connection was successfull.", "SqlAuditor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, res.Item2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void grdEvents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var cell = grdEvents.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (cell.OwningColumn.Name == "colEmail")
                {
                    if ((bool)cell.Value == true)
                    {
                        if ((bool)grdEvents.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value != true)
                        {
                            cell.Value = false;
                        }
                    }
                }
                else if (cell.OwningColumn.Name == "colEnable")
                {
                    if ((bool)cell.Value == false)
                    {
                        grdEvents.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = false;
                    }
                }
            }
        }

        private void txtDataSource_Click(object sender, EventArgs e)
        {

        }

        private void txtDataSource_TextChanged(object sender, EventArgs e)
        {
            this.lblTitle.Text = "SqlAuditor - " + txtDataSource.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckConnection(false).Item1)
            {
                Trace.Events.Clear();
                Trace.EmailConfig.Events.Clear();
                List<int> cols = new List<int>();
                foreach (DataGridViewRow row in grdColumns.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if ((bool)row.Cells["colColumnEnable"].Value)
                        {
                            cols.Add(context.SqlTraceColumns.Where((c) => c.Value.Name == row.Cells["colColumn"].Value.ToString()).First().Key);
                        }
                    }
                }
                foreach (DataGridViewRow row in grdEvents.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if ((bool)row.Cells["colEnable"].Value)
                        {
                            Trace.Events.Add(new EventConfig(context.SqlTraceEvents.Where((evt) => evt.Value.Name == row.Cells["colEvent"].Value.ToString()).First().Key, cols.ToArray()));
                        }
                        if ((bool)row.Cells["colEmail"].Value)
                        {
                            Trace.EmailConfig.Events.Add(context.SqlTraceEvents.Where((evt) => evt.Value.Name == row.Cells["colEvent"].Value.ToString()).First().Key);
                        }
                    }
                }
                Trace.Filters.Clear();
                foreach (DataGridViewRow row in grdFilters.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        Trace.Filters.Add(new EventFilter(
                            context.SqlTraceColumns.Where((c) => c.Value.Name == row.Cells["colFilterCol"].Value.ToString()).First().Key,
                             (int)colLogicalOperator.GetIndex(row.Cells["colLogicalOperator"].Value.ToString()),
                            (int)colComparisonOperator.GetIndex(row.Cells["colComparisonOperator"].Value.ToString()),
                            row.Cells["colValue"].Value
                            ));
                    }
                }
                Trace.EmailConfig.Receipients.Clear();
                foreach (DataGridViewRow row in grdEmailReceipients.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        Trace.EmailConfig.Receipients.Add(row.Cells["colReceipient"].Value.ToString());
                    }
                }
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Settings are not valid.\nPlease check them again.", "Error Saving Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (!isnew) CheckConnection(true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var res = MetroMessageBox.Show(this, "Do you wan't to continue and cancel the changes?", "Cancel changes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }


    }


}
