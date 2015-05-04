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
            this.mtcMain = new MetroFramework.Controls.MetroTabControl();
            this.mtpHome = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtpAuditViewe = new MetroFramework.Controls.MetroTabPage();
            this.mtpSettings = new MetroFramework.Controls.MetroTabPage();
            this.flInstances = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ctxmInstance = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ctxItmTest = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItmDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxItmSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mtcMain.SuspendLayout();
            this.mtpHome.SuspendLayout();
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
            this.mtcMain.SelectedIndex = 2;
            this.mtcMain.Size = new System.Drawing.Size(675, 475);
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
            this.mtpHome.Size = new System.Drawing.Size(667, 433);
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
            this.mtpAuditViewe.HorizontalScrollbarBarColor = true;
            this.mtpAuditViewe.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpAuditViewe.HorizontalScrollbarSize = 10;
            this.mtpAuditViewe.Location = new System.Drawing.Point(4, 38);
            this.mtpAuditViewe.Name = "mtpAuditViewe";
            this.mtpAuditViewe.Size = new System.Drawing.Size(667, 433);
            this.mtpAuditViewe.TabIndex = 1;
            this.mtpAuditViewe.Text = "Audit Viewer";
            this.mtpAuditViewe.VerticalScrollbarBarColor = true;
            this.mtpAuditViewe.VerticalScrollbarHighlightOnWheel = false;
            this.mtpAuditViewe.VerticalScrollbarSize = 10;
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
            this.mtpSettings.Size = new System.Drawing.Size(667, 433);
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
            // ctxItmTest
            // 
            this.ctxItmTest.Name = "ctxItmTest";
            this.ctxItmTest.Size = new System.Drawing.Size(107, 22);
            this.ctxItmTest.Text = "Test";
            this.ctxItmTest.Click += new System.EventHandler(this.ctxItmTest_Click);
            // 
            // ctxItmDelete
            // 
            this.ctxItmDelete.Name = "ctxItmDelete";
            this.ctxItmDelete.Size = new System.Drawing.Size(107, 22);
            this.ctxItmDelete.Text = "Delete";
            this.ctxItmDelete.Click += new System.EventHandler(this.ctxItmDelete_Click);
            // 
            // ctxItmEdit
            // 
            this.ctxItmEdit.Name = "ctxItmEdit";
            this.ctxItmEdit.Size = new System.Drawing.Size(107, 22);
            this.ctxItmEdit.Text = "Edit";
            this.ctxItmEdit.Click += new System.EventHandler(this.ctxItmEdit_Click);
            // 
            // ctxItmSep1
            // 
            this.ctxItmSep1.Name = "ctxItmSep1";
            this.ctxItmSep1.Size = new System.Drawing.Size(104, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(715, 555);
            this.Controls.Add(this.mtcMain);
            this.Name = "frmMain";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "SqlAuditor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mtcMain.ResumeLayout(false);
            this.mtpHome.ResumeLayout(false);
            this.mtpHome.PerformLayout();
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
    }
}

