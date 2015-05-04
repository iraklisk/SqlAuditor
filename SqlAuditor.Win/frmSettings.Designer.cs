﻿namespace SqlAuditor.Win
{
    partial class frmSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mtcSettings = new MetroFramework.Controls.MetroTabControl();
            this.mtpInstanceConfig = new MetroFramework.Controls.MetroTabPage();
            this.cbIntegratedSecurity = new MetroFramework.Controls.MetroCheckBox();
            this.lblInstance = new MetroFramework.Controls.MetroLabel();
            this.txtDataSource = new MetroFramework.Controls.MetroTextBox();
            this.btnCheckConnection = new MetroFramework.Controls.MetroButton();
            this.lblAuditDatabase = new MetroFramework.Controls.MetroLabel();
            this.txtAuditDatabase = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblUserId = new MetroFramework.Controls.MetroLabel();
            this.txtUserId = new MetroFramework.Controls.MetroTextBox();
            this.mtpEvents = new MetroFramework.Controls.MetroTabPage();
            this.grdEvents = new MetroFramework.Controls.MetroGrid();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mtpColumns = new MetroFramework.Controls.MetroTabPage();
            this.grdColumns = new MetroFramework.Controls.MetroGrid();
            this.colColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColumnEnable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mtpFilters = new MetroFramework.Controls.MetroTabPage();
            this.grdFilters = new MetroFramework.Controls.MetroGrid();
            this.colFilterCol = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colLogicalOperator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colComparisonOperator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtpEmailSettings = new MetroFramework.Controls.MetroTabPage();
            this.grdEmailReceipients = new MetroFramework.Controls.MetroGrid();
            this.colReceipient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailAddress = new MetroFramework.Controls.MetroTextBox();
            this.cbEmailUseSSL = new MetroFramework.Controls.MetroCheckBox();
            this.cbEmailEnabled = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailServer = new MetroFramework.Controls.MetroTextBox();
            this.lblTitle = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mtcSettings.SuspendLayout();
            this.mtpInstanceConfig.SuspendLayout();
            this.mtpEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEvents)).BeginInit();
            this.mtpColumns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).BeginInit();
            this.mtpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFilters)).BeginInit();
            this.mtpEmailSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmailReceipients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // mtcSettings
            // 
            this.mtcSettings.Controls.Add(this.mtpInstanceConfig);
            this.mtcSettings.Controls.Add(this.mtpEvents);
            this.mtcSettings.Controls.Add(this.mtpColumns);
            this.mtcSettings.Controls.Add(this.mtpFilters);
            this.mtcSettings.Controls.Add(this.mtpEmailSettings);
            this.mtcSettings.Location = new System.Drawing.Point(3, 42);
            this.mtcSettings.Name = "mtcSettings";
            this.mtcSettings.SelectedIndex = 4;
            this.mtcSettings.Size = new System.Drawing.Size(673, 381);
            this.mtcSettings.TabIndex = 1;
            this.mtcSettings.UseSelectable = true;
            // 
            // mtpInstanceConfig
            // 
            this.mtpInstanceConfig.Controls.Add(this.cbIntegratedSecurity);
            this.mtpInstanceConfig.Controls.Add(this.lblInstance);
            this.mtpInstanceConfig.Controls.Add(this.txtDataSource);
            this.mtpInstanceConfig.Controls.Add(this.btnCheckConnection);
            this.mtpInstanceConfig.Controls.Add(this.lblAuditDatabase);
            this.mtpInstanceConfig.Controls.Add(this.txtAuditDatabase);
            this.mtpInstanceConfig.Controls.Add(this.lblPassword);
            this.mtpInstanceConfig.Controls.Add(this.txtPassword);
            this.mtpInstanceConfig.Controls.Add(this.lblUserId);
            this.mtpInstanceConfig.Controls.Add(this.txtUserId);
            this.mtpInstanceConfig.HorizontalScrollbarBarColor = true;
            this.mtpInstanceConfig.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpInstanceConfig.HorizontalScrollbarSize = 10;
            this.mtpInstanceConfig.Location = new System.Drawing.Point(4, 38);
            this.mtpInstanceConfig.Name = "mtpInstanceConfig";
            this.mtpInstanceConfig.Size = new System.Drawing.Size(665, 339);
            this.mtpInstanceConfig.TabIndex = 0;
            this.mtpInstanceConfig.Text = "Instance";
            this.mtpInstanceConfig.VerticalScrollbarBarColor = true;
            this.mtpInstanceConfig.VerticalScrollbarHighlightOnWheel = false;
            this.mtpInstanceConfig.VerticalScrollbarSize = 10;
            // 
            // cbIntegratedSecurity
            // 
            this.cbIntegratedSecurity.AutoSize = true;
            this.cbIntegratedSecurity.Location = new System.Drawing.Point(16, 73);
            this.cbIntegratedSecurity.Name = "cbIntegratedSecurity";
            this.cbIntegratedSecurity.Size = new System.Drawing.Size(176, 15);
            this.cbIntegratedSecurity.TabIndex = 3;
            this.cbIntegratedSecurity.Text = "Use Windows Authentication";
            this.cbIntegratedSecurity.UseSelectable = true;
            this.cbIntegratedSecurity.CheckedChanged += new System.EventHandler(this.cbIntegratedSecurity_CheckedChanged);
            // 
            // lblInstance
            // 
            this.lblInstance.AutoSize = true;
            this.lblInstance.Location = new System.Drawing.Point(16, 11);
            this.lblInstance.Name = "lblInstance";
            this.lblInstance.Size = new System.Drawing.Size(55, 19);
            this.lblInstance.TabIndex = 9;
            this.lblInstance.Text = "Instance";
            // 
            // txtDataSource
            // 
            this.txtDataSource.Lines = new string[0];
            this.txtDataSource.Location = new System.Drawing.Point(16, 33);
            this.txtDataSource.MaxLength = 32767;
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.PasswordChar = '\0';
            this.txtDataSource.PromptText = "SQL Server Instance";
            this.txtDataSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDataSource.SelectedText = "";
            this.txtDataSource.Size = new System.Drawing.Size(230, 23);
            this.txtDataSource.TabIndex = 2;
            this.txtDataSource.UseSelectable = true;
            this.txtDataSource.TextChanged += new System.EventHandler(this.txtDataSource_TextChanged);
            this.txtDataSource.Click += new System.EventHandler(this.txtDataSource_Click);
            // 
            // btnCheckConnection
            // 
            this.btnCheckConnection.Location = new System.Drawing.Point(58, 287);
            this.btnCheckConnection.Name = "btnCheckConnection";
            this.btnCheckConnection.Size = new System.Drawing.Size(120, 23);
            this.btnCheckConnection.TabIndex = 7;
            this.btnCheckConnection.Text = "Check Connection";
            this.btnCheckConnection.UseSelectable = true;
            this.btnCheckConnection.Click += new System.EventHandler(this.btnCheckConnection_Click);
            // 
            // lblAuditDatabase
            // 
            this.lblAuditDatabase.AutoSize = true;
            this.lblAuditDatabase.Location = new System.Drawing.Point(16, 223);
            this.lblAuditDatabase.Name = "lblAuditDatabase";
            this.lblAuditDatabase.Size = new System.Drawing.Size(98, 19);
            this.lblAuditDatabase.TabIndex = 7;
            this.lblAuditDatabase.Text = "Audit Database";
            // 
            // txtAuditDatabase
            // 
            this.txtAuditDatabase.Lines = new string[0];
            this.txtAuditDatabase.Location = new System.Drawing.Point(16, 245);
            this.txtAuditDatabase.MaxLength = 32767;
            this.txtAuditDatabase.Name = "txtAuditDatabase";
            this.txtAuditDatabase.PasswordChar = '\0';
            this.txtAuditDatabase.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAuditDatabase.SelectedText = "";
            this.txtAuditDatabase.Size = new System.Drawing.Size(230, 23);
            this.txtAuditDatabase.TabIndex = 6;
            this.txtAuditDatabase.UseSelectable = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 161);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(16, 183);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(230, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSelectable = true;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(16, 102);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(50, 19);
            this.lblUserId.TabIndex = 3;
            this.lblUserId.Text = "User Id";
            // 
            // txtUserId
            // 
            this.txtUserId.Lines = new string[0];
            this.txtUserId.Location = new System.Drawing.Point(16, 124);
            this.txtUserId.MaxLength = 32767;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserId.SelectedText = "";
            this.txtUserId.Size = new System.Drawing.Size(230, 23);
            this.txtUserId.TabIndex = 4;
            this.txtUserId.UseSelectable = true;
            // 
            // mtpEvents
            // 
            this.mtpEvents.Controls.Add(this.grdEvents);
            this.mtpEvents.HorizontalScrollbarBarColor = true;
            this.mtpEvents.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpEvents.HorizontalScrollbarSize = 10;
            this.mtpEvents.Location = new System.Drawing.Point(4, 38);
            this.mtpEvents.Name = "mtpEvents";
            this.mtpEvents.Size = new System.Drawing.Size(665, 339);
            this.mtpEvents.TabIndex = 1;
            this.mtpEvents.Text = "Events";
            this.mtpEvents.VerticalScrollbarBarColor = true;
            this.mtpEvents.VerticalScrollbarHighlightOnWheel = false;
            this.mtpEvents.VerticalScrollbarSize = 10;
            // 
            // grdEvents
            // 
            this.grdEvents.AllowUserToAddRows = false;
            this.grdEvents.AllowUserToDeleteRows = false;
            this.grdEvents.AllowUserToResizeRows = false;
            this.grdEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle25;
            this.grdEvents.ColumnHeadersHeight = 35;
            this.grdEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCategory,
            this.colEvent,
            this.colEnable,
            this.colEmail});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEvents.DefaultCellStyle = dataGridViewCellStyle26;
            this.grdEvents.EnableHeadersVisualStyles = false;
            this.grdEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEvents.Location = new System.Drawing.Point(3, 3);
            this.grdEvents.Name = "grdEvents";
            this.grdEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.grdEvents.RowHeadersVisible = false;
            this.grdEvents.RowHeadersWidth = 50;
            this.grdEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEvents.Size = new System.Drawing.Size(662, 330);
            this.grdEvents.TabIndex = 2;
            this.grdEvents.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdEvents_CellValueChanged);
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colEvent
            // 
            this.colEvent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colEvent.HeaderText = "Event";
            this.colEvent.MinimumWidth = 100;
            this.colEvent.Name = "colEvent";
            this.colEvent.ReadOnly = true;
            // 
            // colEnable
            // 
            this.colEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colEnable.HeaderText = "Enable";
            this.colEnable.Name = "colEnable";
            this.colEnable.Width = 53;
            // 
            // colEmail
            // 
            this.colEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 45;
            // 
            // mtpColumns
            // 
            this.mtpColumns.Controls.Add(this.grdColumns);
            this.mtpColumns.HorizontalScrollbarBarColor = true;
            this.mtpColumns.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpColumns.HorizontalScrollbarSize = 10;
            this.mtpColumns.Location = new System.Drawing.Point(4, 38);
            this.mtpColumns.Name = "mtpColumns";
            this.mtpColumns.Size = new System.Drawing.Size(665, 339);
            this.mtpColumns.TabIndex = 2;
            this.mtpColumns.Text = "Columns";
            this.mtpColumns.VerticalScrollbarBarColor = true;
            this.mtpColumns.VerticalScrollbarHighlightOnWheel = false;
            this.mtpColumns.VerticalScrollbarSize = 10;
            // 
            // grdColumns
            // 
            this.grdColumns.AllowUserToAddRows = false;
            this.grdColumns.AllowUserToDeleteRows = false;
            this.grdColumns.AllowUserToResizeRows = false;
            this.grdColumns.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdColumns.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdColumns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdColumns.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle28;
            this.grdColumns.ColumnHeadersHeight = 35;
            this.grdColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColumnID,
            this.colColumn,
            this.colColumnEnable});
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdColumns.DefaultCellStyle = dataGridViewCellStyle29;
            this.grdColumns.EnableHeadersVisualStyles = false;
            this.grdColumns.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdColumns.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdColumns.Location = new System.Drawing.Point(1, 3);
            this.grdColumns.Name = "grdColumns";
            this.grdColumns.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdColumns.RowHeadersDefaultCellStyle = dataGridViewCellStyle30;
            this.grdColumns.RowHeadersVisible = false;
            this.grdColumns.RowHeadersWidth = 50;
            this.grdColumns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdColumns.Size = new System.Drawing.Size(662, 330);
            this.grdColumns.TabIndex = 3;
            // 
            // colColumnID
            // 
            this.colColumnID.HeaderText = "ID";
            this.colColumnID.Name = "colColumnID";
            this.colColumnID.ReadOnly = true;
            this.colColumnID.Visible = false;
            // 
            // colColumn
            // 
            this.colColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colColumn.HeaderText = "Column";
            this.colColumn.MinimumWidth = 100;
            this.colColumn.Name = "colColumn";
            this.colColumn.ReadOnly = true;
            // 
            // colColumnEnable
            // 
            this.colColumnEnable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colColumnEnable.HeaderText = "Enable";
            this.colColumnEnable.Name = "colColumnEnable";
            this.colColumnEnable.Width = 53;
            // 
            // mtpFilters
            // 
            this.mtpFilters.Controls.Add(this.grdFilters);
            this.mtpFilters.HorizontalScrollbarBarColor = true;
            this.mtpFilters.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpFilters.HorizontalScrollbarSize = 10;
            this.mtpFilters.Location = new System.Drawing.Point(4, 38);
            this.mtpFilters.Name = "mtpFilters";
            this.mtpFilters.Size = new System.Drawing.Size(665, 339);
            this.mtpFilters.TabIndex = 3;
            this.mtpFilters.Text = "Filters";
            this.mtpFilters.VerticalScrollbarBarColor = true;
            this.mtpFilters.VerticalScrollbarHighlightOnWheel = false;
            this.mtpFilters.VerticalScrollbarSize = 10;
            // 
            // grdFilters
            // 
            this.grdFilters.AllowUserToResizeRows = false;
            this.grdFilters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFilters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdFilters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdFilters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFilters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.grdFilters.ColumnHeadersHeight = 35;
            this.grdFilters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilterCol,
            this.colLogicalOperator,
            this.colComparisonOperator,
            this.colValue});
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdFilters.DefaultCellStyle = dataGridViewCellStyle32;
            this.grdFilters.EnableHeadersVisualStyles = false;
            this.grdFilters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdFilters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdFilters.Location = new System.Drawing.Point(1, 4);
            this.grdFilters.Name = "grdFilters";
            this.grdFilters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle33.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle33.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdFilters.RowHeadersDefaultCellStyle = dataGridViewCellStyle33;
            this.grdFilters.RowHeadersVisible = false;
            this.grdFilters.RowHeadersWidth = 50;
            this.grdFilters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdFilters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdFilters.Size = new System.Drawing.Size(662, 330);
            this.grdFilters.TabIndex = 4;
            // 
            // colFilterCol
            // 
            this.colFilterCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFilterCol.HeaderText = "Column";
            this.colFilterCol.MinimumWidth = 100;
            this.colFilterCol.Name = "colFilterCol";
            this.colFilterCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colFilterCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colFilterCol.Width = 200;
            // 
            // colLogicalOperator
            // 
            this.colLogicalOperator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colLogicalOperator.HeaderText = "Logical Operator";
            this.colLogicalOperator.Items.AddRange(new object[] {
            "And",
            "Or"});
            this.colLogicalOperator.Name = "colLogicalOperator";
            this.colLogicalOperator.Width = 115;
            // 
            // colComparisonOperator
            // 
            this.colComparisonOperator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colComparisonOperator.HeaderText = "Comparison Operator";
            this.colComparisonOperator.Items.AddRange(new object[] {
            "Equal",
            "NotEqual",
            "GreaterThan",
            "LessThan",
            "GreaterThanOrEqual ",
            "LessThanOrEqual",
            "Like",
            "NotLike"});
            this.colComparisonOperator.Name = "colComparisonOperator";
            this.colComparisonOperator.Width = 147;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "Value";
            this.colValue.MinimumWidth = 100;
            this.colValue.Name = "colValue";
            this.colValue.Width = 200;
            // 
            // mtpEmailSettings
            // 
            this.mtpEmailSettings.Controls.Add(this.grdEmailReceipients);
            this.mtpEmailSettings.Controls.Add(this.metroLabel5);
            this.mtpEmailSettings.Controls.Add(this.txtEmailAddress);
            this.mtpEmailSettings.Controls.Add(this.cbEmailUseSSL);
            this.mtpEmailSettings.Controls.Add(this.cbEmailEnabled);
            this.mtpEmailSettings.Controls.Add(this.metroLabel4);
            this.mtpEmailSettings.Controls.Add(this.txtEmailPassword);
            this.mtpEmailSettings.Controls.Add(this.metroLabel3);
            this.mtpEmailSettings.Controls.Add(this.txtEmailUsername);
            this.mtpEmailSettings.Controls.Add(this.metroLabel2);
            this.mtpEmailSettings.Controls.Add(this.txtEmailPort);
            this.mtpEmailSettings.Controls.Add(this.metroLabel1);
            this.mtpEmailSettings.Controls.Add(this.txtEmailServer);
            this.mtpEmailSettings.HorizontalScrollbarBarColor = true;
            this.mtpEmailSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpEmailSettings.HorizontalScrollbarSize = 10;
            this.mtpEmailSettings.Location = new System.Drawing.Point(4, 38);
            this.mtpEmailSettings.Name = "mtpEmailSettings";
            this.mtpEmailSettings.Size = new System.Drawing.Size(665, 339);
            this.mtpEmailSettings.TabIndex = 4;
            this.mtpEmailSettings.Text = "Email Settings";
            this.mtpEmailSettings.VerticalScrollbarBarColor = true;
            this.mtpEmailSettings.VerticalScrollbarHighlightOnWheel = false;
            this.mtpEmailSettings.VerticalScrollbarSize = 10;
            // 
            // grdEmailReceipients
            // 
            this.grdEmailReceipients.AllowUserToDeleteRows = false;
            this.grdEmailReceipients.AllowUserToResizeRows = false;
            this.grdEmailReceipients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEmailReceipients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEmailReceipients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdEmailReceipients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEmailReceipients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.grdEmailReceipients.ColumnHeadersHeight = 35;
            this.grdEmailReceipients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colReceipient});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdEmailReceipients.DefaultCellStyle = dataGridViewCellStyle35;
            this.grdEmailReceipients.EnableHeadersVisualStyles = false;
            this.grdEmailReceipients.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdEmailReceipients.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdEmailReceipients.Location = new System.Drawing.Point(357, 98);
            this.grdEmailReceipients.Name = "grdEmailReceipients";
            this.grdEmailReceipients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdEmailReceipients.RowHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.grdEmailReceipients.RowHeadersVisible = false;
            this.grdEmailReceipients.RowHeadersWidth = 50;
            this.grdEmailReceipients.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdEmailReceipients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEmailReceipients.Size = new System.Drawing.Size(308, 193);
            this.grdEmailReceipients.TabIndex = 17;
            this.grdEmailReceipients.UseCustomBackColor = true;
            this.grdEmailReceipients.UseCustomForeColor = true;
            this.grdEmailReceipients.UseStyleColors = true;
            // 
            // colReceipient
            // 
            this.colReceipient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colReceipient.HeaderText = "Receipients";
            this.colReceipient.MinimumWidth = 100;
            this.colReceipient.Name = "colReceipient";
            this.colReceipient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(357, 40);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(41, 19);
            this.metroLabel5.TabIndex = 15;
            this.metroLabel5.Text = "From";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Lines = new string[0];
            this.txtEmailAddress.Location = new System.Drawing.Point(357, 62);
            this.txtEmailAddress.MaxLength = 32767;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.PasswordChar = '\0';
            this.txtEmailAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailAddress.SelectedText = "";
            this.txtEmailAddress.Size = new System.Drawing.Size(308, 23);
            this.txtEmailAddress.TabIndex = 16;
            this.txtEmailAddress.UseSelectable = true;
            // 
            // cbEmailUseSSL
            // 
            this.cbEmailUseSSL.AutoSize = true;
            this.cbEmailUseSSL.Location = new System.Drawing.Point(16, 219);
            this.cbEmailUseSSL.Name = "cbEmailUseSSL";
            this.cbEmailUseSSL.Size = new System.Drawing.Size(63, 15);
            this.cbEmailUseSSL.TabIndex = 14;
            this.cbEmailUseSSL.Text = "Use SSL";
            this.cbEmailUseSSL.UseSelectable = true;
            // 
            // cbEmailEnabled
            // 
            this.cbEmailEnabled.AutoSize = true;
            this.cbEmailEnabled.Location = new System.Drawing.Point(16, 13);
            this.cbEmailEnabled.Name = "cbEmailEnabled";
            this.cbEmailEnabled.Size = new System.Drawing.Size(156, 15);
            this.cbEmailEnabled.TabIndex = 13;
            this.cbEmailEnabled.Text = "Enable Email Notification";
            this.cbEmailEnabled.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(16, 155);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Password";
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Lines = new string[0];
            this.txtEmailPassword.Location = new System.Drawing.Point(16, 177);
            this.txtEmailPassword.MaxLength = 32767;
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.PasswordChar = '\0';
            this.txtEmailPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailPassword.SelectedText = "";
            this.txtEmailPassword.Size = new System.Drawing.Size(230, 23);
            this.txtEmailPassword.TabIndex = 12;
            this.txtEmailPassword.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(16, 98);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Username";
            // 
            // txtEmailUsername
            // 
            this.txtEmailUsername.Lines = new string[0];
            this.txtEmailUsername.Location = new System.Drawing.Point(16, 120);
            this.txtEmailUsername.MaxLength = 32767;
            this.txtEmailUsername.Name = "txtEmailUsername";
            this.txtEmailUsername.PasswordChar = '\0';
            this.txtEmailUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailUsername.SelectedText = "";
            this.txtEmailUsername.Size = new System.Drawing.Size(230, 23);
            this.txtEmailUsername.TabIndex = 10;
            this.txtEmailUsername.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(252, 40);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(34, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Port";
            // 
            // txtEmailPort
            // 
            this.txtEmailPort.Lines = new string[0];
            this.txtEmailPort.Location = new System.Drawing.Point(252, 62);
            this.txtEmailPort.MaxLength = 32767;
            this.txtEmailPort.Name = "txtEmailPort";
            this.txtEmailPort.PasswordChar = '\0';
            this.txtEmailPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailPort.SelectedText = "";
            this.txtEmailPort.Size = new System.Drawing.Size(34, 23);
            this.txtEmailPort.TabIndex = 8;
            this.txtEmailPort.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(16, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Host";
            // 
            // txtEmailServer
            // 
            this.txtEmailServer.Lines = new string[0];
            this.txtEmailServer.Location = new System.Drawing.Point(16, 62);
            this.txtEmailServer.MaxLength = 32767;
            this.txtEmailServer.Name = "txtEmailServer";
            this.txtEmailServer.PasswordChar = '\0';
            this.txtEmailServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailServer.SelectedText = "";
            this.txtEmailServer.Size = new System.Drawing.Size(230, 23);
            this.txtEmailServer.TabIndex = 6;
            this.txtEmailServer.UseSelectable = true;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTitle.Location = new System.Drawing.Point(7, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(91, 25);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Instance - ";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(597, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnSave.TabIndex = 100;
            this.btnSave.Text = "OK";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(516, 425);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 101;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 461);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.mtcSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Resizable = false;
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.mtcSettings.ResumeLayout(false);
            this.mtpInstanceConfig.ResumeLayout(false);
            this.mtpInstanceConfig.PerformLayout();
            this.mtpEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdEvents)).EndInit();
            this.mtpColumns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdColumns)).EndInit();
            this.mtpFilters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdFilters)).EndInit();
            this.mtpEmailSettings.ResumeLayout(false);
            this.mtpEmailSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmailReceipients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mtcSettings;
        private MetroFramework.Controls.MetroTabPage mtpInstanceConfig;
        private MetroFramework.Controls.MetroTabPage mtpEvents;
        private MetroFramework.Controls.MetroTabPage mtpColumns;
        private MetroFramework.Controls.MetroTabPage mtpFilters;
        private MetroFramework.Controls.MetroTabPage mtpEmailSettings;
        private MetroFramework.Controls.MetroTextBox txtDataSource;
        private MetroFramework.Controls.MetroButton btnCheckConnection;
        private MetroFramework.Controls.MetroLabel lblAuditDatabase;
        private MetroFramework.Controls.MetroTextBox txtAuditDatabase;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel lblUserId;
        private MetroFramework.Controls.MetroTextBox txtUserId;
        private MetroFramework.Controls.MetroLabel lblTitle;
        private MetroFramework.Controls.MetroCheckBox cbIntegratedSecurity;
        private MetroFramework.Controls.MetroLabel lblInstance;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroGrid grdEvents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEvent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEnable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEmail;
        private MetroFramework.Controls.MetroGrid grdColumns;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colColumnEnable;
        private MetroFramework.Controls.MetroCheckBox cbEmailEnabled;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtEmailPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEmailUsername;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtEmailPort;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtEmailServer;
        private MetroFramework.Controls.MetroGrid grdEmailReceipients;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtEmailAddress;
        private MetroFramework.Controls.MetroCheckBox cbEmailUseSSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReceipient;
        private MetroFramework.Controls.MetroGrid grdFilters;
        private System.Windows.Forms.DataGridViewComboBoxColumn colFilterCol;
        private System.Windows.Forms.DataGridViewComboBoxColumn colLogicalOperator;
        private System.Windows.Forms.DataGridViewComboBoxColumn colComparisonOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;

    }
}
