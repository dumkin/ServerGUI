namespace ServerGUI
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.TabControl_Main = new System.Windows.Forms.TabControl();
            this.TabPage_Main = new System.Windows.Forms.TabPage();
            this.Main_Label_Ram = new System.Windows.Forms.GroupBox();
            this.RamTotalProgress = new System.Windows.Forms.ProgressBar();
            this.RamServerProgress = new System.Windows.Forms.ProgressBar();
            this.RamGuiProgress = new System.Windows.Forms.ProgressBar();
            this.RamTotal = new System.Windows.Forms.Label();
            this.RamServer = new System.Windows.Forms.Label();
            this.RamGui = new System.Windows.Forms.Label();
            this.Main_Label_RamTotal = new System.Windows.Forms.Label();
            this.Main_Label_RamServer = new System.Windows.Forms.Label();
            this.Main_Label_RamGui = new System.Windows.Forms.Label();
            this.Main_Label_Cpu = new System.Windows.Forms.GroupBox();
            this.CpuTotalProgress = new System.Windows.Forms.ProgressBar();
            this.CpuServerProgress = new System.Windows.Forms.ProgressBar();
            this.CpuGuiProgress = new System.Windows.Forms.ProgressBar();
            this.CpuTotal = new System.Windows.Forms.Label();
            this.CpuServer = new System.Windows.Forms.Label();
            this.CpuGui = new System.Windows.Forms.Label();
            this.Main_Label_CpuTotal = new System.Windows.Forms.Label();
            this.Main_Label_CpuServer = new System.Windows.Forms.Label();
            this.Main_Label_CpuGui = new System.Windows.Forms.Label();
            this.Main_Label_Backup = new System.Windows.Forms.GroupBox();
            this.Main_Autobackup = new System.Windows.Forms.CheckBox();
            this.Main_BackupNow = new System.Windows.Forms.Button();
            this.Main_Command = new System.Windows.Forms.TextBox();
            this.Main_Label_Server = new System.Windows.Forms.GroupBox();
            this.Main_Autorestart = new System.Windows.Forms.CheckBox();
            this.Main_Switch = new System.Windows.Forms.Button();
            this.Main_Log = new System.Windows.Forms.RichTextBox();
            this.TabPage_Core = new System.Windows.Forms.TabPage();
            this.Core_CoreArguments = new System.Windows.Forms.TextBox();
            this.Core_Label_CoreArguments = new System.Windows.Forms.Label();
            this.Core_ChangeCoreFilename = new System.Windows.Forms.Button();
            this.Core_CoreFilename = new System.Windows.Forms.TextBox();
            this.Core_Label_CoreFilename = new System.Windows.Forms.Label();
            this.Core_JavaArguments = new System.Windows.Forms.TextBox();
            this.Core_Label_JavaArguments = new System.Windows.Forms.Label();
            this.Core_ChangeJavaFilename = new System.Windows.Forms.Button();
            this.Core_JavaFilename = new System.Windows.Forms.TextBox();
            this.Core_Label_JavaFilename = new System.Windows.Forms.Label();
            this.TabPage_Backup = new System.Windows.Forms.TabPage();
            this.Backup_Interval = new System.Windows.Forms.NumericUpDown();
            this.Backup_Label_Interval = new System.Windows.Forms.Label();
            this.Backup_Label_Folder = new System.Windows.Forms.Label();
            this.Backup_Folder = new System.Windows.Forms.TextBox();
            this.Backup_Tree = new System.Windows.Forms.TreeView();
            this.TabPage_Task = new System.Windows.Forms.TabPage();
            this.TabPage_Settings = new System.Windows.Forms.TabPage();
            this.Main_Timer_Autobackup = new System.Windows.Forms.Timer(this.components);
            this.Main_Timer_Counter = new System.Windows.Forms.Timer(this.components);
            this.TabControl_Main.SuspendLayout();
            this.TabPage_Main.SuspendLayout();
            this.Main_Label_Ram.SuspendLayout();
            this.Main_Label_Cpu.SuspendLayout();
            this.Main_Label_Backup.SuspendLayout();
            this.Main_Label_Server.SuspendLayout();
            this.TabPage_Core.SuspendLayout();
            this.TabPage_Backup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Backup_Interval)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl_Main
            // 
            this.TabControl_Main.Controls.Add(this.TabPage_Main);
            this.TabControl_Main.Controls.Add(this.TabPage_Core);
            this.TabControl_Main.Controls.Add(this.TabPage_Backup);
            this.TabControl_Main.Controls.Add(this.TabPage_Task);
            this.TabControl_Main.Controls.Add(this.TabPage_Settings);
            this.TabControl_Main.ItemSize = new System.Drawing.Size(54, 22);
            this.TabControl_Main.Location = new System.Drawing.Point(-4, 0);
            this.TabControl_Main.Margin = new System.Windows.Forms.Padding(0);
            this.TabControl_Main.Name = "TabControl_Main";
            this.TabControl_Main.SelectedIndex = 0;
            this.TabControl_Main.Size = new System.Drawing.Size(1272, 685);
            this.TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Main
            // 
            this.TabPage_Main.Controls.Add(this.Main_Label_Ram);
            this.TabPage_Main.Controls.Add(this.Main_Label_Cpu);
            this.TabPage_Main.Controls.Add(this.Main_Label_Backup);
            this.TabPage_Main.Controls.Add(this.Main_Command);
            this.TabPage_Main.Controls.Add(this.Main_Label_Server);
            this.TabPage_Main.Controls.Add(this.Main_Log);
            this.TabPage_Main.Location = new System.Drawing.Point(4, 26);
            this.TabPage_Main.Margin = new System.Windows.Forms.Padding(0);
            this.TabPage_Main.Name = "TabPage_Main";
            this.TabPage_Main.Size = new System.Drawing.Size(1264, 655);
            this.TabPage_Main.TabIndex = 1;
            this.TabPage_Main.Text = "Main";
            this.TabPage_Main.UseVisualStyleBackColor = true;
            // 
            // Main_Label_Ram
            // 
            this.Main_Label_Ram.Controls.Add(this.RamTotalProgress);
            this.Main_Label_Ram.Controls.Add(this.RamServerProgress);
            this.Main_Label_Ram.Controls.Add(this.RamGuiProgress);
            this.Main_Label_Ram.Controls.Add(this.RamTotal);
            this.Main_Label_Ram.Controls.Add(this.RamServer);
            this.Main_Label_Ram.Controls.Add(this.RamGui);
            this.Main_Label_Ram.Controls.Add(this.Main_Label_RamTotal);
            this.Main_Label_Ram.Controls.Add(this.Main_Label_RamServer);
            this.Main_Label_Ram.Controls.Add(this.Main_Label_RamGui);
            this.Main_Label_Ram.Location = new System.Drawing.Point(500, 550);
            this.Main_Label_Ram.Name = "Main_Label_Ram";
            this.Main_Label_Ram.Size = new System.Drawing.Size(320, 100);
            this.Main_Label_Ram.TabIndex = 9;
            this.Main_Label_Ram.TabStop = false;
            this.Main_Label_Ram.Text = "RAM";
            // 
            // RamTotalProgress
            // 
            this.RamTotalProgress.Location = new System.Drawing.Point(186, 70);
            this.RamTotalProgress.Name = "RamTotalProgress";
            this.RamTotalProgress.Size = new System.Drawing.Size(128, 20);
            this.RamTotalProgress.TabIndex = 8;
            // 
            // RamServerProgress
            // 
            this.RamServerProgress.Location = new System.Drawing.Point(186, 45);
            this.RamServerProgress.Name = "RamServerProgress";
            this.RamServerProgress.Size = new System.Drawing.Size(128, 20);
            this.RamServerProgress.TabIndex = 7;
            // 
            // RamGuiProgress
            // 
            this.RamGuiProgress.Location = new System.Drawing.Point(186, 20);
            this.RamGuiProgress.Name = "RamGuiProgress";
            this.RamGuiProgress.Size = new System.Drawing.Size(128, 20);
            this.RamGuiProgress.TabIndex = 6;
            // 
            // RamTotal
            // 
            this.RamTotal.Location = new System.Drawing.Point(61, 70);
            this.RamTotal.Name = "RamTotal";
            this.RamTotal.Size = new System.Drawing.Size(119, 20);
            this.RamTotal.TabIndex = 5;
            this.RamTotal.Text = "0 MB (0%)";
            this.RamTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RamServer
            // 
            this.RamServer.Location = new System.Drawing.Point(61, 45);
            this.RamServer.Name = "RamServer";
            this.RamServer.Size = new System.Drawing.Size(119, 20);
            this.RamServer.TabIndex = 4;
            this.RamServer.Text = "0 MB (0%)";
            this.RamServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // RamGui
            // 
            this.RamGui.Location = new System.Drawing.Point(61, 20);
            this.RamGui.Name = "RamGui";
            this.RamGui.Size = new System.Drawing.Size(119, 20);
            this.RamGui.TabIndex = 3;
            this.RamGui.Text = "0 MB (0%)";
            this.RamGui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_RamTotal
            // 
            this.Main_Label_RamTotal.Location = new System.Drawing.Point(5, 70);
            this.Main_Label_RamTotal.Name = "Main_Label_RamTotal";
            this.Main_Label_RamTotal.Size = new System.Drawing.Size(50, 20);
            this.Main_Label_RamTotal.TabIndex = 2;
            this.Main_Label_RamTotal.Text = "Total";
            this.Main_Label_RamTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_RamServer
            // 
            this.Main_Label_RamServer.Location = new System.Drawing.Point(5, 45);
            this.Main_Label_RamServer.Name = "Main_Label_RamServer";
            this.Main_Label_RamServer.Size = new System.Drawing.Size(50, 20);
            this.Main_Label_RamServer.TabIndex = 1;
            this.Main_Label_RamServer.Text = "Server";
            this.Main_Label_RamServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_RamGui
            // 
            this.Main_Label_RamGui.Location = new System.Drawing.Point(5, 20);
            this.Main_Label_RamGui.Name = "Main_Label_RamGui";
            this.Main_Label_RamGui.Size = new System.Drawing.Size(50, 20);
            this.Main_Label_RamGui.TabIndex = 0;
            this.Main_Label_RamGui.Text = "GUI";
            this.Main_Label_RamGui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_Cpu
            // 
            this.Main_Label_Cpu.Controls.Add(this.CpuTotalProgress);
            this.Main_Label_Cpu.Controls.Add(this.CpuServerProgress);
            this.Main_Label_Cpu.Controls.Add(this.CpuGuiProgress);
            this.Main_Label_Cpu.Controls.Add(this.CpuTotal);
            this.Main_Label_Cpu.Controls.Add(this.CpuServer);
            this.Main_Label_Cpu.Controls.Add(this.CpuGui);
            this.Main_Label_Cpu.Controls.Add(this.Main_Label_CpuTotal);
            this.Main_Label_Cpu.Controls.Add(this.Main_Label_CpuServer);
            this.Main_Label_Cpu.Controls.Add(this.Main_Label_CpuGui);
            this.Main_Label_Cpu.Location = new System.Drawing.Point(254, 550);
            this.Main_Label_Cpu.Name = "Main_Label_Cpu";
            this.Main_Label_Cpu.Size = new System.Drawing.Size(240, 100);
            this.Main_Label_Cpu.TabIndex = 6;
            this.Main_Label_Cpu.TabStop = false;
            this.Main_Label_Cpu.Text = "CPU";
            // 
            // CpuTotalProgress
            // 
            this.CpuTotalProgress.Location = new System.Drawing.Point(106, 71);
            this.CpuTotalProgress.Name = "CpuTotalProgress";
            this.CpuTotalProgress.Size = new System.Drawing.Size(128, 20);
            this.CpuTotalProgress.TabIndex = 8;
            // 
            // CpuServerProgress
            // 
            this.CpuServerProgress.Location = new System.Drawing.Point(106, 45);
            this.CpuServerProgress.Name = "CpuServerProgress";
            this.CpuServerProgress.Size = new System.Drawing.Size(128, 20);
            this.CpuServerProgress.TabIndex = 7;
            // 
            // CpuGuiProgress
            // 
            this.CpuGuiProgress.Location = new System.Drawing.Point(106, 20);
            this.CpuGuiProgress.Name = "CpuGuiProgress";
            this.CpuGuiProgress.Size = new System.Drawing.Size(128, 20);
            this.CpuGuiProgress.TabIndex = 6;
            // 
            // CpuTotal
            // 
            this.CpuTotal.Location = new System.Drawing.Point(60, 70);
            this.CpuTotal.Name = "CpuTotal";
            this.CpuTotal.Size = new System.Drawing.Size(40, 20);
            this.CpuTotal.TabIndex = 5;
            this.CpuTotal.Text = "0%";
            this.CpuTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuServer
            // 
            this.CpuServer.Location = new System.Drawing.Point(60, 45);
            this.CpuServer.Name = "CpuServer";
            this.CpuServer.Size = new System.Drawing.Size(40, 20);
            this.CpuServer.TabIndex = 4;
            this.CpuServer.Text = "0%";
            this.CpuServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CpuGui
            // 
            this.CpuGui.Location = new System.Drawing.Point(60, 20);
            this.CpuGui.Name = "CpuGui";
            this.CpuGui.Size = new System.Drawing.Size(40, 20);
            this.CpuGui.TabIndex = 3;
            this.CpuGui.Text = "0%";
            this.CpuGui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_CpuTotal
            // 
            this.Main_Label_CpuTotal.Location = new System.Drawing.Point(5, 70);
            this.Main_Label_CpuTotal.Name = "Main_Label_CpuTotal";
            this.Main_Label_CpuTotal.Size = new System.Drawing.Size(50, 20);
            this.Main_Label_CpuTotal.TabIndex = 2;
            this.Main_Label_CpuTotal.Text = "Total";
            this.Main_Label_CpuTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_CpuServer
            // 
            this.Main_Label_CpuServer.Location = new System.Drawing.Point(5, 45);
            this.Main_Label_CpuServer.Name = "Main_Label_CpuServer";
            this.Main_Label_CpuServer.Size = new System.Drawing.Size(50, 20);
            this.Main_Label_CpuServer.TabIndex = 1;
            this.Main_Label_CpuServer.Text = "Server";
            this.Main_Label_CpuServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_CpuGui
            // 
            this.Main_Label_CpuGui.Location = new System.Drawing.Point(5, 20);
            this.Main_Label_CpuGui.Name = "Main_Label_CpuGui";
            this.Main_Label_CpuGui.Size = new System.Drawing.Size(50, 20);
            this.Main_Label_CpuGui.TabIndex = 0;
            this.Main_Label_CpuGui.Text = "GUI";
            this.Main_Label_CpuGui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Main_Label_Backup
            // 
            this.Main_Label_Backup.Controls.Add(this.Main_Autobackup);
            this.Main_Label_Backup.Controls.Add(this.Main_BackupNow);
            this.Main_Label_Backup.Location = new System.Drawing.Point(128, 550);
            this.Main_Label_Backup.Name = "Main_Label_Backup";
            this.Main_Label_Backup.Size = new System.Drawing.Size(120, 100);
            this.Main_Label_Backup.TabIndex = 3;
            this.Main_Label_Backup.TabStop = false;
            this.Main_Label_Backup.Text = "Buckup";
            // 
            // Main_Autobackup
            // 
            this.Main_Autobackup.Location = new System.Drawing.Point(10, 60);
            this.Main_Autobackup.Name = "Main_Autobackup";
            this.Main_Autobackup.Size = new System.Drawing.Size(100, 30);
            this.Main_Autobackup.TabIndex = 2;
            this.Main_Autobackup.Text = "Autobackup";
            this.Main_Autobackup.UseVisualStyleBackColor = true;
            this.Main_Autobackup.CheckedChanged += new System.EventHandler(this.Main_Autobackup_CheckedChanged);
            // 
            // Main_BackupNow
            // 
            this.Main_BackupNow.Location = new System.Drawing.Point(10, 20);
            this.Main_BackupNow.Margin = new System.Windows.Forms.Padding(0);
            this.Main_BackupNow.Name = "Main_BackupNow";
            this.Main_BackupNow.Size = new System.Drawing.Size(100, 30);
            this.Main_BackupNow.TabIndex = 1;
            this.Main_BackupNow.Text = "Backup now";
            this.Main_BackupNow.UseVisualStyleBackColor = true;
            this.Main_BackupNow.Click += new System.EventHandler(this.Main_BackupNow_Click);
            // 
            // Main_Command
            // 
            this.Main_Command.Location = new System.Drawing.Point(0, 519);
            this.Main_Command.Multiline = true;
            this.Main_Command.Name = "Main_Command";
            this.Main_Command.Size = new System.Drawing.Size(1264, 25);
            this.Main_Command.TabIndex = 2;
            this.Main_Command.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Main_Command_KeyPress);
            // 
            // Main_Label_Server
            // 
            this.Main_Label_Server.Controls.Add(this.Main_Autorestart);
            this.Main_Label_Server.Controls.Add(this.Main_Switch);
            this.Main_Label_Server.Location = new System.Drawing.Point(5, 550);
            this.Main_Label_Server.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Label_Server.Name = "Main_Label_Server";
            this.Main_Label_Server.Padding = new System.Windows.Forms.Padding(0);
            this.Main_Label_Server.Size = new System.Drawing.Size(120, 100);
            this.Main_Label_Server.TabIndex = 1;
            this.Main_Label_Server.TabStop = false;
            this.Main_Label_Server.Text = "Server";
            // 
            // Main_Autorestart
            // 
            this.Main_Autorestart.Location = new System.Drawing.Point(10, 60);
            this.Main_Autorestart.Name = "Main_Autorestart";
            this.Main_Autorestart.Size = new System.Drawing.Size(100, 30);
            this.Main_Autorestart.TabIndex = 1;
            this.Main_Autorestart.Text = "Autorestart";
            this.Main_Autorestart.UseVisualStyleBackColor = true;
            this.Main_Autorestart.CheckedChanged += new System.EventHandler(this.Main_Autorestart_CheckedChanged);
            // 
            // Main_Switch
            // 
            this.Main_Switch.Location = new System.Drawing.Point(10, 20);
            this.Main_Switch.Margin = new System.Windows.Forms.Padding(0);
            this.Main_Switch.Name = "Main_Switch";
            this.Main_Switch.Size = new System.Drawing.Size(100, 30);
            this.Main_Switch.TabIndex = 0;
            this.Main_Switch.Text = "Start";
            this.Main_Switch.UseVisualStyleBackColor = true;
            this.Main_Switch.Click += new System.EventHandler(this.Main_Switch_Click);
            // 
            // Main_Log
            // 
            this.Main_Log.BackColor = System.Drawing.Color.White;
            this.Main_Log.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_Log.HideSelection = false;
            this.Main_Log.Location = new System.Drawing.Point(0, 3);
            this.Main_Log.Name = "Main_Log";
            this.Main_Log.ReadOnly = true;
            this.Main_Log.Size = new System.Drawing.Size(1264, 517);
            this.Main_Log.TabIndex = 0;
            this.Main_Log.Text = "";
            // 
            // TabPage_Core
            // 
            this.TabPage_Core.Controls.Add(this.Core_CoreArguments);
            this.TabPage_Core.Controls.Add(this.Core_Label_CoreArguments);
            this.TabPage_Core.Controls.Add(this.Core_ChangeCoreFilename);
            this.TabPage_Core.Controls.Add(this.Core_CoreFilename);
            this.TabPage_Core.Controls.Add(this.Core_Label_CoreFilename);
            this.TabPage_Core.Controls.Add(this.Core_JavaArguments);
            this.TabPage_Core.Controls.Add(this.Core_Label_JavaArguments);
            this.TabPage_Core.Controls.Add(this.Core_ChangeJavaFilename);
            this.TabPage_Core.Controls.Add(this.Core_JavaFilename);
            this.TabPage_Core.Controls.Add(this.Core_Label_JavaFilename);
            this.TabPage_Core.Location = new System.Drawing.Point(4, 26);
            this.TabPage_Core.Name = "TabPage_Core";
            this.TabPage_Core.Size = new System.Drawing.Size(1264, 655);
            this.TabPage_Core.TabIndex = 2;
            this.TabPage_Core.Text = "Core";
            this.TabPage_Core.UseVisualStyleBackColor = true;
            // 
            // Core_CoreArguments
            // 
            this.Core_CoreArguments.Location = new System.Drawing.Point(136, 109);
            this.Core_CoreArguments.Name = "Core_CoreArguments";
            this.Core_CoreArguments.Size = new System.Drawing.Size(552, 25);
            this.Core_CoreArguments.TabIndex = 9;
            this.Core_CoreArguments.TextChanged += new System.EventHandler(this.Core_CoreArguments_TextChanged);
            // 
            // Core_Label_CoreArguments
            // 
            this.Core_Label_CoreArguments.AutoSize = true;
            this.Core_Label_CoreArguments.Location = new System.Drawing.Point(32, 112);
            this.Core_Label_CoreArguments.Name = "Core_Label_CoreArguments";
            this.Core_Label_CoreArguments.Size = new System.Drawing.Size(102, 17);
            this.Core_Label_CoreArguments.TabIndex = 8;
            this.Core_Label_CoreArguments.Text = "Core arguments";
            // 
            // Core_ChangeCoreFilename
            // 
            this.Core_ChangeCoreFilename.Location = new System.Drawing.Point(694, 78);
            this.Core_ChangeCoreFilename.Name = "Core_ChangeCoreFilename";
            this.Core_ChangeCoreFilename.Size = new System.Drawing.Size(75, 25);
            this.Core_ChangeCoreFilename.TabIndex = 7;
            this.Core_ChangeCoreFilename.Text = "Change";
            this.Core_ChangeCoreFilename.UseVisualStyleBackColor = true;
            this.Core_ChangeCoreFilename.Click += new System.EventHandler(this.Core_ChangeCoreFilename_Click);
            // 
            // Core_CoreFilename
            // 
            this.Core_CoreFilename.Location = new System.Drawing.Point(136, 78);
            this.Core_CoreFilename.Name = "Core_CoreFilename";
            this.Core_CoreFilename.Size = new System.Drawing.Size(552, 25);
            this.Core_CoreFilename.TabIndex = 6;
            this.Core_CoreFilename.TextChanged += new System.EventHandler(this.Core_CoreFilename_TextChanged);
            // 
            // Core_Label_CoreFilename
            // 
            this.Core_Label_CoreFilename.AutoSize = true;
            this.Core_Label_CoreFilename.Location = new System.Drawing.Point(44, 81);
            this.Core_Label_CoreFilename.Name = "Core_Label_CoreFilename";
            this.Core_Label_CoreFilename.Size = new System.Drawing.Size(89, 17);
            this.Core_Label_CoreFilename.TabIndex = 5;
            this.Core_Label_CoreFilename.Text = "Core filename";
            // 
            // Core_JavaArguments
            // 
            this.Core_JavaArguments.Location = new System.Drawing.Point(136, 47);
            this.Core_JavaArguments.Name = "Core_JavaArguments";
            this.Core_JavaArguments.Size = new System.Drawing.Size(552, 25);
            this.Core_JavaArguments.TabIndex = 4;
            this.Core_JavaArguments.TextChanged += new System.EventHandler(this.Core_JavaArguments_TextChanged);
            // 
            // Core_Label_JavaArguments
            // 
            this.Core_Label_JavaArguments.AutoSize = true;
            this.Core_Label_JavaArguments.Location = new System.Drawing.Point(31, 50);
            this.Core_Label_JavaArguments.Name = "Core_Label_JavaArguments";
            this.Core_Label_JavaArguments.Size = new System.Drawing.Size(99, 17);
            this.Core_Label_JavaArguments.TabIndex = 3;
            this.Core_Label_JavaArguments.Text = "Java arguments";
            // 
            // Core_ChangeJavaFilename
            // 
            this.Core_ChangeJavaFilename.Location = new System.Drawing.Point(694, 16);
            this.Core_ChangeJavaFilename.Name = "Core_ChangeJavaFilename";
            this.Core_ChangeJavaFilename.Size = new System.Drawing.Size(75, 25);
            this.Core_ChangeJavaFilename.TabIndex = 2;
            this.Core_ChangeJavaFilename.Text = "Change";
            this.Core_ChangeJavaFilename.UseVisualStyleBackColor = true;
            this.Core_ChangeJavaFilename.Click += new System.EventHandler(this.Core_ChangeJavaFilename_Click);
            // 
            // Core_JavaFilename
            // 
            this.Core_JavaFilename.Location = new System.Drawing.Point(136, 16);
            this.Core_JavaFilename.Name = "Core_JavaFilename";
            this.Core_JavaFilename.Size = new System.Drawing.Size(552, 25);
            this.Core_JavaFilename.TabIndex = 1;
            this.Core_JavaFilename.TextChanged += new System.EventHandler(this.Core_JavaFilename_TextChanged);
            // 
            // Core_Label_JavaFilename
            // 
            this.Core_Label_JavaFilename.AutoSize = true;
            this.Core_Label_JavaFilename.Location = new System.Drawing.Point(44, 19);
            this.Core_Label_JavaFilename.Name = "Core_Label_JavaFilename";
            this.Core_Label_JavaFilename.Size = new System.Drawing.Size(86, 17);
            this.Core_Label_JavaFilename.TabIndex = 0;
            this.Core_Label_JavaFilename.Text = "Java filename";
            // 
            // TabPage_Backup
            // 
            this.TabPage_Backup.Controls.Add(this.Backup_Interval);
            this.TabPage_Backup.Controls.Add(this.Backup_Label_Interval);
            this.TabPage_Backup.Controls.Add(this.Backup_Label_Folder);
            this.TabPage_Backup.Controls.Add(this.Backup_Folder);
            this.TabPage_Backup.Controls.Add(this.Backup_Tree);
            this.TabPage_Backup.Location = new System.Drawing.Point(4, 26);
            this.TabPage_Backup.Name = "TabPage_Backup";
            this.TabPage_Backup.Size = new System.Drawing.Size(1264, 655);
            this.TabPage_Backup.TabIndex = 3;
            this.TabPage_Backup.Text = "Backup";
            this.TabPage_Backup.UseVisualStyleBackColor = true;
            // 
            // Backup_Interval
            // 
            this.Backup_Interval.Location = new System.Drawing.Point(200, 44);
            this.Backup_Interval.Maximum = new decimal(new int[] {
            35000,
            0,
            0,
            0});
            this.Backup_Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Backup_Interval.Name = "Backup_Interval";
            this.Backup_Interval.Size = new System.Drawing.Size(200, 25);
            this.Backup_Interval.TabIndex = 5;
            this.Backup_Interval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Backup_Interval.ValueChanged += new System.EventHandler(this.Backup_Interval_ValueChanged);
            // 
            // Backup_Label_Interval
            // 
            this.Backup_Label_Interval.AutoSize = true;
            this.Backup_Label_Interval.Location = new System.Drawing.Point(42, 46);
            this.Backup_Label_Interval.Name = "Backup_Label_Interval";
            this.Backup_Label_Interval.Size = new System.Drawing.Size(152, 17);
            this.Backup_Label_Interval.TabIndex = 4;
            this.Backup_Label_Interval.Text = "Backup Interval (minutes)";
            // 
            // Backup_Label_Folder
            // 
            this.Backup_Label_Folder.AutoSize = true;
            this.Backup_Label_Folder.Location = new System.Drawing.Point(106, 15);
            this.Backup_Label_Folder.Name = "Backup_Label_Folder";
            this.Backup_Label_Folder.Size = new System.Drawing.Size(88, 17);
            this.Backup_Label_Folder.TabIndex = 2;
            this.Backup_Label_Folder.Text = "Backup folder";
            // 
            // Backup_Folder
            // 
            this.Backup_Folder.Location = new System.Drawing.Point(200, 12);
            this.Backup_Folder.Name = "Backup_Folder";
            this.Backup_Folder.Size = new System.Drawing.Size(200, 25);
            this.Backup_Folder.TabIndex = 1;
            this.Backup_Folder.TextChanged += new System.EventHandler(this.Backup_Folder_TextChanged);
            // 
            // Backup_Tree
            // 
            this.Backup_Tree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Backup_Tree.CheckBoxes = true;
            this.Backup_Tree.Location = new System.Drawing.Point(630, 0);
            this.Backup_Tree.Name = "Backup_Tree";
            this.Backup_Tree.Size = new System.Drawing.Size(632, 655);
            this.Backup_Tree.TabIndex = 0;
            this.Backup_Tree.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.Backup_Tree_AfterCheck);
            // 
            // TabPage_Task
            // 
            this.TabPage_Task.Location = new System.Drawing.Point(4, 26);
            this.TabPage_Task.Name = "TabPage_Task";
            this.TabPage_Task.Size = new System.Drawing.Size(1264, 655);
            this.TabPage_Task.TabIndex = 5;
            this.TabPage_Task.Text = "Task";
            this.TabPage_Task.UseVisualStyleBackColor = true;
            // 
            // TabPage_Settings
            // 
            this.TabPage_Settings.Location = new System.Drawing.Point(4, 26);
            this.TabPage_Settings.Name = "TabPage_Settings";
            this.TabPage_Settings.Size = new System.Drawing.Size(1264, 655);
            this.TabPage_Settings.TabIndex = 4;
            this.TabPage_Settings.Text = "Settings";
            this.TabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // Main_Timer_Autobackup
            // 
            this.Main_Timer_Autobackup.Interval = 300000;
            this.Main_Timer_Autobackup.Tick += new System.EventHandler(this.Main_Timer_Autobackup_Tick);
            // 
            // Main_Timer_Counter
            // 
            this.Main_Timer_Counter.Enabled = true;
            this.Main_Timer_Counter.Interval = 1500;
            this.Main_Timer_Counter.Tick += new System.EventHandler(this.Main_Timer_Counter_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.TabControl_Main);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ServerGUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.TabControl_Main.ResumeLayout(false);
            this.TabPage_Main.ResumeLayout(false);
            this.TabPage_Main.PerformLayout();
            this.Main_Label_Ram.ResumeLayout(false);
            this.Main_Label_Cpu.ResumeLayout(false);
            this.Main_Label_Backup.ResumeLayout(false);
            this.Main_Label_Server.ResumeLayout(false);
            this.TabPage_Core.ResumeLayout(false);
            this.TabPage_Core.PerformLayout();
            this.TabPage_Backup.ResumeLayout(false);
            this.TabPage_Backup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Backup_Interval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl_Main;
        private System.Windows.Forms.TabPage TabPage_Main;
        private System.Windows.Forms.RichTextBox Main_Log;
        private System.Windows.Forms.GroupBox Main_Label_Server;
        private System.Windows.Forms.CheckBox Main_Autorestart;
        private System.Windows.Forms.Button Main_Switch;
        private System.Windows.Forms.TextBox Main_Command;
        private System.Windows.Forms.GroupBox Main_Label_Backup;
        private System.Windows.Forms.Button Main_BackupNow;
        private System.Windows.Forms.TabPage TabPage_Core;
        private System.Windows.Forms.TabPage TabPage_Backup;
        private System.Windows.Forms.TabPage TabPage_Settings;
        private System.Windows.Forms.TreeView Backup_Tree;
        private System.Windows.Forms.Label Backup_Label_Folder;
        private System.Windows.Forms.TextBox Backup_Folder;
        private System.Windows.Forms.Label Core_Label_JavaFilename;
        private System.Windows.Forms.Button Core_ChangeJavaFilename;
        private System.Windows.Forms.TextBox Core_JavaFilename;
        private System.Windows.Forms.TextBox Core_JavaArguments;
        private System.Windows.Forms.Label Core_Label_JavaArguments;
        private System.Windows.Forms.TextBox Core_CoreArguments;
        private System.Windows.Forms.Label Core_Label_CoreArguments;
        private System.Windows.Forms.Button Core_ChangeCoreFilename;
        private System.Windows.Forms.TextBox Core_CoreFilename;
        private System.Windows.Forms.Label Core_Label_CoreFilename;
        private System.Windows.Forms.CheckBox Main_Autobackup;
        private System.Windows.Forms.Timer Main_Timer_Autobackup;
        private System.Windows.Forms.NumericUpDown Backup_Interval;
        private System.Windows.Forms.Label Backup_Label_Interval;
        private System.Windows.Forms.TabPage TabPage_Task;
        private System.Windows.Forms.Timer Main_Timer_Counter;
        private System.Windows.Forms.GroupBox Main_Label_Ram;
        private System.Windows.Forms.ProgressBar RamTotalProgress;
        private System.Windows.Forms.ProgressBar RamServerProgress;
        private System.Windows.Forms.ProgressBar RamGuiProgress;
        private System.Windows.Forms.Label RamTotal;
        private System.Windows.Forms.Label RamServer;
        private System.Windows.Forms.Label RamGui;
        private System.Windows.Forms.Label Main_Label_RamTotal;
        private System.Windows.Forms.Label Main_Label_RamServer;
        private System.Windows.Forms.Label Main_Label_RamGui;
        private System.Windows.Forms.GroupBox Main_Label_Cpu;
        private System.Windows.Forms.ProgressBar CpuTotalProgress;
        private System.Windows.Forms.ProgressBar CpuServerProgress;
        private System.Windows.Forms.ProgressBar CpuGuiProgress;
        private System.Windows.Forms.Label CpuTotal;
        private System.Windows.Forms.Label CpuServer;
        private System.Windows.Forms.Label CpuGui;
        private System.Windows.Forms.Label Main_Label_CpuTotal;
        private System.Windows.Forms.Label Main_Label_CpuServer;
        private System.Windows.Forms.Label Main_Label_CpuGui;
    }
}

