namespace SqlAuditor.Service
{
    partial class ProjectInstaller
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
            this.SqlAuditorProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.SqlAuditorInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // SqlAuditorProcessInstaller
            // 
            this.SqlAuditorProcessInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.SqlAuditorProcessInstaller.Password = null;
            this.SqlAuditorProcessInstaller.Username = null;
            // 
            // SqlAuditorInstaller
            // 
            this.SqlAuditorInstaller.DelayedAutoStart = true;
            this.SqlAuditorInstaller.Description = "SqlAuditor Service";
            this.SqlAuditorInstaller.DisplayName = "SqlAuditor";
            this.SqlAuditorInstaller.ServiceName = "SqlAuditor";
            this.SqlAuditorInstaller.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            this.SqlAuditorInstaller.AfterInstall += new System.Configuration.Install.InstallEventHandler(this.SqlAuditorInstaller_AfterInstall);
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.SqlAuditorProcessInstaller,
            this.SqlAuditorInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller SqlAuditorProcessInstaller;
        private System.ServiceProcess.ServiceInstaller SqlAuditorInstaller;
    }
}