namespace SqlAuditor.Win
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtcMain = new MetroFramework.Controls.MetroTabControl();
            this.mtpHome = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpAuditViewe = new MetroFramework.Controls.MetroTabPage();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.btnRun = new MetroFramework.Controls.MetroButton();
            this.dtTo = new MetroFramework.Controls.MetroDateTime();
            this.dtFrom = new MetroFramework.Controls.MetroDateTime();
            this.cbInstances = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblInstance = new MetroFramework.Controls.MetroLabel();
            this.grdEvents = new MetroFramework.Controls.MetroGrid();
            this.mtpSettings = new MetroFramework.Controls.MetroTabPage();
            this.flInstances = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ctxmInstance = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ctxItmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItmTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItmSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctxItmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.mtcMain.SuspendLayout();
            this.mtpHome.SuspendLayout();
            this.mtpAuditViewe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvents)).BeginInit();
            this.mtpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.ctxmInstance.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtcMain
            // 
            this.mtcMain.Controls.Add(this.mtpHome);
            this.mtcMain.Controls.Add(this.mtpAuditViewe);
            this.mtcMain.Controls.Add(this.mtpSettings);
            this.mtcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtcMain.Location = new System.Drawing.Point(20, 60);
            this.mtcMain.Name = "mtcMain";
            this.mtcMain.SelectedIndex = 1;
            this.mtcMain.Size = new System.Drawing.Size(912, 512);
            this.mtcMain.TabIndex = 0;
            this.mtcMain.UseSelectable = true;
            // 
            // mtpHome
            // 
            this.mtpHome.Controls.Add(this.metroLabel1);
            this.mtpHome.HorizontalScrollbarBarColor = true;
            this.mtpHome.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpHome.HorizontalScrollbarSize = 10;
            this.mtpHome.Location = new System.Drawing.Point(4, 38);
            this.mtpHome.Name = "mtpHome";
            this.mtpHome.Size = new System.Drawing.Size(904, 470);
            this.mtpHome.TabIndex = 0;
            this.mtpHome.Text = "Home";
            this.mtpHome.VerticalScrollbarBarColor = true;
            this.mtpHome.VerticalScrollbarHighlightOnWheel = false;
            this.mtpHome.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(20, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(156, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Welcome to SQL Auditor";
            // 
            // mtpAuditViewe
            // 
            this.mtpAuditViewe.Controls.Add(this.btnExport);
            this.mtpAuditViewe.Controls.Add(this.btnRun);
            this.mtpAuditViewe.Controls.Add(this.dtTo);
            this.mtpAuditViewe.Controls.Add(this.dtFrom);
            this.mtpAuditViewe.Controls.Add(this.cbInstances);
            this.mtpAuditViewe.Controls.Add(this.metroLabel6);
            this.mtpAuditViewe.Controls.Add(this.metroLabel5);
            this.mtpAuditViewe.Controls.Add(this.metroLabel4);
            this.mtpAuditViewe.Controls.Add(this.lblInstance);
            this.mtpAuditViewe.Controls.Add(this.grdEvents);
            this.mtpAuditViewe.HorizontalScrollbarBarColor = true;
            this.mtpAuditViewe.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpAuditViewe.HorizontalScrollbarSize = 10;
            this.mtpAuditViewe.Location = new System.Drawing.Point(4, 38);
            this.mtpAuditViewe.Name = "mtpAuditViewe";
            this.mtpAuditViewe.Size = new System.Drawing.Size(904, 470);
            this.mtpAuditViewe.TabIndex = 1;
            this.mtpAuditViewe.Text = "Audit Viewer";
            this.mtpAuditViewe.VerticalScrollbarBarColor = true;
            this.mtpAuditViewe.VerticalScrollbarHighlightOnWheel = false;
            this.mtpAuditViewe.VerticalScrollbarSize = 10;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(567, 23);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(95, 29);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(466, 23);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 29);
            this.btnRun.TabIndex = 12;
            this.btnRun.Text = "Run";
            this.btnRun.UseSelectable = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // dtTo
            // 
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(342, 23);
            this.dtTo.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(109, 29);
            this.dtTo.TabIndex = 11;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(215, 23);
            this.dtFrom.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(109, 29);
            this.dtFrom.TabIndex = 10;
            // 
            // cbInstances
            // 
            this.cbInstances.FormattingEnabled = true;
            this.cbInstances.ItemHeight = 23;
            this.cbInstances.Location = new System.Drawing.Point(4, 23);
            this.cbInstances.Name = "cbInstances";
            this.cbInstances.Size = new System.Drawing.Size(193, 29);
            this.cbInstances.TabIndex = 9;
            this.cbInstances.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(342, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(53, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "To Date";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(234, 4);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(0, 0);
            this.metroLabel5.TabIndex = 7;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(215, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(72, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "From Date";
            // 
            // lblInstance
            // 
            this.lblInstance.AutoSize = true;
            this.lblInstance.Location = new System.Drawing.Point(3, 0);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(55, 19);
            this.lblInstance.TabIndex = 5;
            this.lblInstance.Text = "Instance";
            // 
            // grdEvents
            // 
            this.grdEvents.AllowUserToAddRows = false;
            this.grdEvents.AllowUserToDeleteRows = false;
            this.grdEvents.AllowUserToResizeRows = false;
            this.grdEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdEvents.ColumnHeadersHeight = 35;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEvents.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdEvents.EnableHeadersVisualStyles = false;
            this.grdEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEvents.Location = new System.Drawing.Point(-1, 58);
            this.grdEvents.Name = "grdEvents";
            this.grdEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdEvents.RowHeadersVisible = false;
            this.grdEvents.RowHeadersWidth = 50;
            this.grdEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEvents.Size = new System.Drawing.Size(909, 409);
            this.grdEvents.TabIndex = 4;
            // 
            // mtpSettings
            // 
            this.mtpSettings.Controls.Add(this.flInstances);
            this.mtpSettings.Controls.Add(this.metroLabel2);
            this.mtpSettings.Controls.Add(this.metroLabel3);
            this.mtpSettings.Controls.Add(this.metroTile1);
            this.mtpSettings.HorizontalScrollbarBarColor = true;
            this.mtpSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpSettings.HorizontalScrollbarSize = 10;
            this.mtpSettings.Location = new System.Drawing.Point(4, 38);
            this.mtpSettings.Name = "mtpSettings";
            this.mtpSettings.Size = new System.Drawing.Size(904, 470);
            this.mtpSettings.TabIndex = 2;
            this.mtpSettings.Text = "Settings";
            this.mtpSettings.VerticalScrollbarBarColor = true;
            this.mtpSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mtpSettings.VerticalScrollbarSize = 10;
            // 
            // flInstances
            // 
            this.flInstances.BackColor = System.Drawing.Color.Transparent;
            this.flInstances.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flInstances.Location = new System.Drawing.Point(94, 55);
            this.flInstances.Name = "flInstances";
            this.flInstances.Size = new System.Drawing.Size(573, 313);
            this.flInstances.TabIndex = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(94, 17);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(130, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "SQL Server Instances";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(0, 17);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Actions";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 58);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(85, 70);
            this.metroTile1.TabIndex = 4;
            this.metroTile1.Text = "New";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            // 
            // ctxmInstance
            // 
            this.ctxmInstance.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxItmEdit,
            this.ctxItmTest,
            this.ctxItmSep1,
            this.ctxItmDelete});
            this.ctxmInstance.Name = "ctxmInstance";
            this.ctxmInstance.Size = new System.Drawing.Size(108, 76);
            // 
            // ctxItmEdit
            // 
            this.ctxItmEdit.Name = "ctxItmEdit";
            this.ctxItmEdit.Size = new System.Drawing.Size(107, 22);
            this.ctxItmEdit.Text = "Edit";
            this.ctxItmEdit.Click += new System.EventHandler(this.ctxItmEdit_Click);
            // 
            // ctxItmTest
            // 
            this.ctxItmTest.Name = "ctxItmTest";
            this.ctxItmTest.Size = new System.Drawing.Size(107, 22);
            this.ctxItmTest.Text = "Test";
            this.ctxItmTest.Click += new System.EventHandler(this.ctxItmTest_Click);
            // 
            // ctxItmSep1
            // 
            this.ctxItmSep1.Name = "ctxItmSep1";
            this.ctxItmSep1.Size = new System.Drawing.Size(104, 6);
            // 
            // ctxItmDelete
            // 
            this.ctxItmDelete.Name = "ctxItmDelete";
            this.ctxItmDelete.Size = new System.Drawing.Size(107, 22);
            this.ctxItmDelete.Text = "Delete";
            this.ctxItmDelete.Click += new System.EventHandler(this.ctxItmDelete_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(952, 592);
            this.Controls.Add(this.mtcMain);
            this.Name = "frmMain";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "SqlAuditor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mtcMain.ResumeLayout(false);
            this.mtpHome.ResumeLayout(false);
            this.mtpHome.PerformLayout();
            this.mtpAuditViewe.ResumeLayout(false);
            this.mtpAuditViewe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvents)).EndInit();
            this.mtpSettings.ResumeLayout(false);
            this.mtpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ctxmInstance.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcMain;
        private MetroFramework.Controls.MetroTabPage mtpHome;
        private MetroFramework.Controls.MetroTabPage mtpAuditViewe;
        private MetroFramework.Controls.MetroTabPage mtpSettings;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private System.Windows.Forms.FlowLayoutPanel flInstances;
        private MetroFramework.Controls.MetroContextMenu ctxmInstance;
        private System.Windows.Forms.ToolStripMenuItem ctxItmEdit;
        private System.Windows.Forms.ToolStripMenuItem ctxItmTest;
        private System.Windows.Forms.ToolStripSeparator ctxItmSep1;
        private System.Windows.Forms.ToolStripMenuItem ctxItmDelete;
        private MetroFramework.Controls.MetroDateTime dtTo;
        private MetroFramework.Controls.MetroDateTime dtFrom;
        private MetroFramework.Controls.MetroComboBox cbInstances;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblInstance;
        private MetroFramework.Controls.MetroGrid grdEvents;
        private MetroFramework.Controls.MetroButton btnExport;
        private MetroFramework.Controls.MetroButton btnRun;
    }
}

