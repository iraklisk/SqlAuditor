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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLink2 = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.mtDocumentation = new MetroFramework.Controls.MetroTile();
            this.mtSettings = new MetroFramework.Controls.MetroTile();
            this.mtAuditViewer = new MetroFramework.Controls.MetroTile();
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
            this.mtcMain.SelectedIndex = 0;
            this.mtcMain.Size = new System.Drawing.Size(674, 414);
            this.mtcMain.TabIndex = 0;
            this.mtcMain.UseSelectable = true;
            // 
            // mtpHome
            // 
            this.mtpHome.Controls.Add(this.metroTile2);
            this.mtpHome.Controls.Add(this.mtDocumentation);
            this.mtpHome.Controls.Add(this.mtSettings);
            this.mtpHome.Controls.Add(this.mtAuditViewer);
            this.mtpHome.Controls.Add(this.metroLabel1);
            this.mtpHome.HorizontalScrollbarBarColor = true;
            this.mtpHome.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpHome.HorizontalScrollbarSize = 10;
            this.mtpHome.Location = new System.Drawing.Point(4, 38);
            this.mtpHome.Name = "mtpHome";
            this.mtpHome.Size = new System.Drawing.Size(666, 372);
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
            this.mtpAuditViewe.Size = new System.Drawing.Size(666, 372);
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
            this.dtTo.MinimumSize = new System.Drawing.Size(4, 29);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(109, 29);
            this.dtTo.TabIndex = 11;
            // 
            // dtFrom
            // 
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(215, 23);
            this.dtFrom.MinimumSize = new System.Drawing.Size(4, 29);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdEvents.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdEvents.EnableHeadersVisualStyles = false;
            this.grdEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEvents.Location = new System.Drawing.Point(4, 58);
            this.grdEvents.Name = "grdEvents";
            this.grdEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdEvents.RowHeadersVisible = false;
            this.grdEvents.RowHeadersWidth = 50;
            this.grdEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEvents.Size = new System.Drawing.Size(666, 319);
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
            this.mtpSettings.Size = new System.Drawing.Size(666, 372);
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
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(138, 30);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(285, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Simple yet powerful auditor for MS SQL Server";
            // 
            // metroLink2
            // 
            this.metroLink2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink2.Location = new System.Drawing.Point(517, 30);
            this.metroLink2.Name = "metroLink2";
            this.metroLink2.Size = new System.Drawing.Size(109, 62);
            this.metroLink2.TabIndex = 9;
            this.metroLink2.Text = "Visit us on github";
            this.metroLink2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLink2.UseSelectable = true;
            this.metroLink2.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.BackgroundImage = global::SqlAuditor.Win.Properties.Resources.GitHubMark64px;
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Location = new System.Drawing.Point(632, 35);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(58, 57);
            this.metroLink1.TabIndex = 1;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(344, 67);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(156, 205);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile2.TabIndex = 7;
            this.metroTile2.Text = "Source Code";
            this.metroTile2.TileImage = global::SqlAuditor.Win.Properties.Resources.Octocat1;
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mtDocumentation
            // 
            this.mtDocumentation.ActiveControl = null;
            this.mtDocumentation.Location = new System.Drawing.Point(182, 67);
            this.mtDocumentation.Name = "mtDocumentation";
            this.mtDocumentation.Size = new System.Drawing.Size(156, 205);
            this.mtDocumentation.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtDocumentation.TabIndex = 6;
            this.mtDocumentation.Text = "Documentation";
            this.mtDocumentation.TileImage = global::SqlAuditor.Win.Properties.Resources.manual;
            this.mtDocumentation.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtDocumentation.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtDocumentation.UseSelectable = true;
            this.mtDocumentation.UseTileImage = true;
            this.mtDocumentation.Click += new System.EventHandler(this.mtDocumentation_Click);
            // 
            // mtSettings
            // 
            this.mtSettings.ActiveControl = null;
            this.mtSettings.Location = new System.Drawing.Point(20, 174);
            this.mtSettings.Name = "mtSettings";
            this.mtSettings.Size = new System.Drawing.Size(156, 98);
            this.mtSettings.Style = MetroFramework.MetroColorStyle.Red;
            this.mtSettings.TabIndex = 5;
            this.mtSettings.Text = "Settings";
            this.mtSettings.TileImage = global::SqlAuditor.Win.Properties.Resources.settings;
            this.mtSettings.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSettings.UseSelectable = true;
            this.mtSettings.UseTileImage = true;
            this.mtSettings.Click += new System.EventHandler(this.mtSettings_Click);
            // 
            // mtAuditViewer
            // 
            this.mtAuditViewer.ActiveControl = null;
            this.mtAuditViewer.Location = new System.Drawing.Point(20, 67);
            this.mtAuditViewer.Name = "mtAuditViewer";
            this.mtAuditViewer.Size = new System.Drawing.Size(156, 101);
            this.mtAuditViewer.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtAuditViewer.TabIndex = 4;
            this.mtAuditViewer.Text = "Audit Viewer";
            this.mtAuditViewer.TileImage = global::SqlAuditor.Win.Properties.Resources.logviewer;
            this.mtAuditViewer.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtAuditViewer.UseSelectable = true;
            this.mtAuditViewer.UseTileImage = true;
            this.mtAuditViewer.Click += new System.EventHandler(this.mtAuditViewer_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(714, 494);
            this.Controls.Add(this.metroLink2);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLink1);
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
            this.PerformLayout();

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
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroTile mtAuditViewer;
        private MetroFramework.Controls.MetroTile mtDocumentation;
        private MetroFramework.Controls.MetroTile mtSettings;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroLink metroLink2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}

