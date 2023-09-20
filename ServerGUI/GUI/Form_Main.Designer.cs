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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            TabControl_Main = new TabControl();
            TabPage_Main = new TabPage();
            Main_Label_Ram = new GroupBox();
            RamTotalProgress = new ProgressBar();
            RamServerProgress = new ProgressBar();
            RamGuiProgress = new ProgressBar();
            RamTotal = new Label();
            RamServer = new Label();
            RamGui = new Label();
            Main_Label_RamTotal = new Label();
            Main_Label_RamServer = new Label();
            Main_Label_RamGui = new Label();
            Main_Label_Cpu = new GroupBox();
            CpuTotalProgress = new ProgressBar();
            CpuServerProgress = new ProgressBar();
            CpuGuiProgress = new ProgressBar();
            CpuTotal = new Label();
            CpuServer = new Label();
            CpuGui = new Label();
            Main_Label_CpuTotal = new Label();
            Main_Label_CpuServer = new Label();
            Main_Label_CpuGui = new Label();
            Main_Label_Backup = new GroupBox();
            Main_Autobackup = new CheckBox();
            Main_BackupNow = new Button();
            Main_Command = new TextBox();
            Main_Label_Server = new GroupBox();
            Main_Autorestart = new CheckBox();
            Main_Switch = new Button();
            Main_Log = new RichTextBox();
            TabPage_Core = new TabPage();
            Core_CoreArguments = new TextBox();
            Core_Label_CoreArguments = new Label();
            Core_ChangeCoreFilename = new Button();
            Core_CoreFilename = new TextBox();
            Core_Label_CoreFilename = new Label();
            Core_JavaArguments = new TextBox();
            Core_Label_JavaArguments = new Label();
            Core_ChangeJavaFilename = new Button();
            Core_JavaFilename = new TextBox();
            Core_Label_JavaFilename = new Label();
            TabPage_Backup = new TabPage();
            Backup_Interval = new NumericUpDown();
            Backup_Label_Interval = new Label();
            Backup_Label_Folder = new Label();
            Backup_Folder = new TextBox();
            Backup_Tree = new TreeView();
            TabPage_Task = new TabPage();
            TabPage_Settings = new TabPage();
            Main_Timer_Autobackup = new System.Windows.Forms.Timer(components);
            Main_Timer_Counter = new System.Windows.Forms.Timer(components);
            TabControl_Main.SuspendLayout();
            TabPage_Main.SuspendLayout();
            Main_Label_Ram.SuspendLayout();
            Main_Label_Cpu.SuspendLayout();
            Main_Label_Backup.SuspendLayout();
            Main_Label_Server.SuspendLayout();
            TabPage_Core.SuspendLayout();
            TabPage_Backup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Backup_Interval).BeginInit();
            SuspendLayout();
            // 
            // TabControl_Main
            // 
            TabControl_Main.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl_Main.Controls.Add(TabPage_Main);
            TabControl_Main.Controls.Add(TabPage_Core);
            TabControl_Main.Controls.Add(TabPage_Backup);
            TabControl_Main.Controls.Add(TabPage_Task);
            TabControl_Main.Controls.Add(TabPage_Settings);
            TabControl_Main.ItemSize = new Size(54, 22);
            TabControl_Main.Location = new Point(-4, 0);
            TabControl_Main.Margin = new Padding(0);
            TabControl_Main.Name = "TabControl_Main";
            TabControl_Main.SelectedIndex = 0;
            TabControl_Main.Size = new Size(1272, 685);
            TabControl_Main.TabIndex = 0;
            // 
            // TabPage_Main
            // 
            TabPage_Main.Controls.Add(Main_Label_Ram);
            TabPage_Main.Controls.Add(Main_Label_Cpu);
            TabPage_Main.Controls.Add(Main_Label_Backup);
            TabPage_Main.Controls.Add(Main_Command);
            TabPage_Main.Controls.Add(Main_Label_Server);
            TabPage_Main.Controls.Add(Main_Log);
            TabPage_Main.Location = new Point(4, 26);
            TabPage_Main.Margin = new Padding(0);
            TabPage_Main.Name = "TabPage_Main";
            TabPage_Main.Size = new Size(1264, 655);
            TabPage_Main.TabIndex = 1;
            TabPage_Main.Text = "Main";
            TabPage_Main.UseVisualStyleBackColor = true;
            // 
            // Main_Label_Ram
            // 
            Main_Label_Ram.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Label_Ram.Controls.Add(RamTotalProgress);
            Main_Label_Ram.Controls.Add(RamServerProgress);
            Main_Label_Ram.Controls.Add(RamGuiProgress);
            Main_Label_Ram.Controls.Add(RamTotal);
            Main_Label_Ram.Controls.Add(RamServer);
            Main_Label_Ram.Controls.Add(RamGui);
            Main_Label_Ram.Controls.Add(Main_Label_RamTotal);
            Main_Label_Ram.Controls.Add(Main_Label_RamServer);
            Main_Label_Ram.Controls.Add(Main_Label_RamGui);
            Main_Label_Ram.Location = new Point(500, 550);
            Main_Label_Ram.Name = "Main_Label_Ram";
            Main_Label_Ram.Size = new Size(320, 100);
            Main_Label_Ram.TabIndex = 9;
            Main_Label_Ram.TabStop = false;
            Main_Label_Ram.Text = "RAM";
            // 
            // RamTotalProgress
            // 
            RamTotalProgress.Location = new Point(186, 70);
            RamTotalProgress.Name = "RamTotalProgress";
            RamTotalProgress.Size = new Size(128, 20);
            RamTotalProgress.TabIndex = 8;
            // 
            // RamServerProgress
            // 
            RamServerProgress.Location = new Point(186, 45);
            RamServerProgress.Name = "RamServerProgress";
            RamServerProgress.Size = new Size(128, 20);
            RamServerProgress.TabIndex = 7;
            // 
            // RamGuiProgress
            // 
            RamGuiProgress.Location = new Point(186, 20);
            RamGuiProgress.Name = "RamGuiProgress";
            RamGuiProgress.Size = new Size(128, 20);
            RamGuiProgress.TabIndex = 6;
            // 
            // RamTotal
            // 
            RamTotal.Location = new Point(61, 70);
            RamTotal.Name = "RamTotal";
            RamTotal.Size = new Size(119, 20);
            RamTotal.TabIndex = 5;
            RamTotal.Text = "0 MB (0%)";
            RamTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RamServer
            // 
            RamServer.Location = new Point(61, 45);
            RamServer.Name = "RamServer";
            RamServer.Size = new Size(119, 20);
            RamServer.TabIndex = 4;
            RamServer.Text = "0 MB (0%)";
            RamServer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RamGui
            // 
            RamGui.Location = new Point(61, 20);
            RamGui.Name = "RamGui";
            RamGui.Size = new Size(119, 20);
            RamGui.TabIndex = 3;
            RamGui.Text = "0 MB (0%)";
            RamGui.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_RamTotal
            // 
            Main_Label_RamTotal.Location = new Point(5, 70);
            Main_Label_RamTotal.Name = "Main_Label_RamTotal";
            Main_Label_RamTotal.Size = new Size(50, 20);
            Main_Label_RamTotal.TabIndex = 2;
            Main_Label_RamTotal.Text = "Total";
            Main_Label_RamTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_RamServer
            // 
            Main_Label_RamServer.Location = new Point(5, 45);
            Main_Label_RamServer.Name = "Main_Label_RamServer";
            Main_Label_RamServer.Size = new Size(50, 20);
            Main_Label_RamServer.TabIndex = 1;
            Main_Label_RamServer.Text = "Server";
            Main_Label_RamServer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_RamGui
            // 
            Main_Label_RamGui.Location = new Point(5, 20);
            Main_Label_RamGui.Name = "Main_Label_RamGui";
            Main_Label_RamGui.Size = new Size(50, 20);
            Main_Label_RamGui.TabIndex = 0;
            Main_Label_RamGui.Text = "GUI";
            Main_Label_RamGui.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_Cpu
            // 
            Main_Label_Cpu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Label_Cpu.Controls.Add(CpuTotalProgress);
            Main_Label_Cpu.Controls.Add(CpuServerProgress);
            Main_Label_Cpu.Controls.Add(CpuGuiProgress);
            Main_Label_Cpu.Controls.Add(CpuTotal);
            Main_Label_Cpu.Controls.Add(CpuServer);
            Main_Label_Cpu.Controls.Add(CpuGui);
            Main_Label_Cpu.Controls.Add(Main_Label_CpuTotal);
            Main_Label_Cpu.Controls.Add(Main_Label_CpuServer);
            Main_Label_Cpu.Controls.Add(Main_Label_CpuGui);
            Main_Label_Cpu.Location = new Point(254, 550);
            Main_Label_Cpu.Name = "Main_Label_Cpu";
            Main_Label_Cpu.Size = new Size(240, 100);
            Main_Label_Cpu.TabIndex = 6;
            Main_Label_Cpu.TabStop = false;
            Main_Label_Cpu.Text = "CPU";
            // 
            // CpuTotalProgress
            // 
            CpuTotalProgress.Location = new Point(106, 71);
            CpuTotalProgress.Name = "CpuTotalProgress";
            CpuTotalProgress.Size = new Size(128, 20);
            CpuTotalProgress.TabIndex = 8;
            // 
            // CpuServerProgress
            // 
            CpuServerProgress.Location = new Point(106, 45);
            CpuServerProgress.Name = "CpuServerProgress";
            CpuServerProgress.Size = new Size(128, 20);
            CpuServerProgress.TabIndex = 7;
            // 
            // CpuGuiProgress
            // 
            CpuGuiProgress.Location = new Point(106, 20);
            CpuGuiProgress.Name = "CpuGuiProgress";
            CpuGuiProgress.Size = new Size(128, 20);
            CpuGuiProgress.TabIndex = 6;
            // 
            // CpuTotal
            // 
            CpuTotal.Location = new Point(60, 70);
            CpuTotal.Name = "CpuTotal";
            CpuTotal.Size = new Size(40, 20);
            CpuTotal.TabIndex = 5;
            CpuTotal.Text = "0%";
            CpuTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CpuServer
            // 
            CpuServer.Location = new Point(60, 45);
            CpuServer.Name = "CpuServer";
            CpuServer.Size = new Size(40, 20);
            CpuServer.TabIndex = 4;
            CpuServer.Text = "0%";
            CpuServer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CpuGui
            // 
            CpuGui.Location = new Point(60, 20);
            CpuGui.Name = "CpuGui";
            CpuGui.Size = new Size(40, 20);
            CpuGui.TabIndex = 3;
            CpuGui.Text = "0%";
            CpuGui.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_CpuTotal
            // 
            Main_Label_CpuTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Label_CpuTotal.Location = new Point(5, 70);
            Main_Label_CpuTotal.Name = "Main_Label_CpuTotal";
            Main_Label_CpuTotal.Size = new Size(50, 20);
            Main_Label_CpuTotal.TabIndex = 2;
            Main_Label_CpuTotal.Text = "Total";
            Main_Label_CpuTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_CpuServer
            // 
            Main_Label_CpuServer.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Label_CpuServer.Location = new Point(5, 45);
            Main_Label_CpuServer.Name = "Main_Label_CpuServer";
            Main_Label_CpuServer.Size = new Size(50, 20);
            Main_Label_CpuServer.TabIndex = 1;
            Main_Label_CpuServer.Text = "Server";
            Main_Label_CpuServer.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_CpuGui
            // 
            Main_Label_CpuGui.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Label_CpuGui.Location = new Point(5, 20);
            Main_Label_CpuGui.Name = "Main_Label_CpuGui";
            Main_Label_CpuGui.Size = new Size(50, 20);
            Main_Label_CpuGui.TabIndex = 0;
            Main_Label_CpuGui.Text = "GUI";
            Main_Label_CpuGui.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Main_Label_Backup
            // 
            Main_Label_Backup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Label_Backup.Controls.Add(Main_Autobackup);
            Main_Label_Backup.Controls.Add(Main_BackupNow);
            Main_Label_Backup.Location = new Point(128, 550);
            Main_Label_Backup.Name = "Main_Label_Backup";
            Main_Label_Backup.Size = new Size(120, 100);
            Main_Label_Backup.TabIndex = 3;
            Main_Label_Backup.TabStop = false;
            Main_Label_Backup.Text = "Buckup";
            // 
            // Main_Autobackup
            // 
            Main_Autobackup.Location = new Point(10, 60);
            Main_Autobackup.Name = "Main_Autobackup";
            Main_Autobackup.Size = new Size(100, 30);
            Main_Autobackup.TabIndex = 2;
            Main_Autobackup.Text = "Autobackup";
            Main_Autobackup.UseVisualStyleBackColor = true;
            Main_Autobackup.CheckedChanged += Main_Autobackup_CheckedChanged;
            // 
            // Main_BackupNow
            // 
            Main_BackupNow.Location = new Point(10, 20);
            Main_BackupNow.Margin = new Padding(0);
            Main_BackupNow.Name = "Main_BackupNow";
            Main_BackupNow.Size = new Size(100, 30);
            Main_BackupNow.TabIndex = 1;
            Main_BackupNow.Text = "Backup now";
            Main_BackupNow.UseVisualStyleBackColor = true;
            Main_BackupNow.Click += Main_BackupNow_Click;
            // 
            // Main_Command
            // 
            Main_Command.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Main_Command.Location = new Point(0, 519);
            Main_Command.Multiline = true;
            Main_Command.Name = "Main_Command";
            Main_Command.Size = new Size(1264, 25);
            Main_Command.TabIndex = 2;
            Main_Command.KeyPress += Main_Command_KeyPress;
            // 
            // Main_Label_Server
            // 
            Main_Label_Server.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Main_Label_Server.Controls.Add(Main_Autorestart);
            Main_Label_Server.Controls.Add(Main_Switch);
            Main_Label_Server.Location = new Point(5, 550);
            Main_Label_Server.Margin = new Padding(0);
            Main_Label_Server.Name = "Main_Label_Server";
            Main_Label_Server.Padding = new Padding(0);
            Main_Label_Server.Size = new Size(120, 100);
            Main_Label_Server.TabIndex = 1;
            Main_Label_Server.TabStop = false;
            Main_Label_Server.Text = "Server";
            // 
            // Main_Autorestart
            // 
            Main_Autorestart.Location = new Point(10, 60);
            Main_Autorestart.Name = "Main_Autorestart";
            Main_Autorestart.Size = new Size(100, 30);
            Main_Autorestart.TabIndex = 1;
            Main_Autorestart.Text = "Autorestart";
            Main_Autorestart.UseVisualStyleBackColor = true;
            Main_Autorestart.CheckedChanged += Main_Autorestart_CheckedChanged;
            // 
            // Main_Switch
            // 
            Main_Switch.Location = new Point(10, 20);
            Main_Switch.Margin = new Padding(0);
            Main_Switch.Name = "Main_Switch";
            Main_Switch.Size = new Size(100, 30);
            Main_Switch.TabIndex = 0;
            Main_Switch.Text = "Start";
            Main_Switch.UseVisualStyleBackColor = true;
            Main_Switch.Click += Main_Switch_Click;
            // 
            // Main_Log
            // 
            Main_Log.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Main_Log.BackColor = Color.White;
            Main_Log.BorderStyle = BorderStyle.None;
            Main_Log.HideSelection = false;
            Main_Log.Location = new Point(0, 3);
            Main_Log.Name = "Main_Log";
            Main_Log.ReadOnly = true;
            Main_Log.Size = new Size(1264, 517);
            Main_Log.TabIndex = 0;
            Main_Log.Text = "";
            // 
            // TabPage_Core
            // 
            TabPage_Core.Controls.Add(Core_CoreArguments);
            TabPage_Core.Controls.Add(Core_Label_CoreArguments);
            TabPage_Core.Controls.Add(Core_ChangeCoreFilename);
            TabPage_Core.Controls.Add(Core_CoreFilename);
            TabPage_Core.Controls.Add(Core_Label_CoreFilename);
            TabPage_Core.Controls.Add(Core_JavaArguments);
            TabPage_Core.Controls.Add(Core_Label_JavaArguments);
            TabPage_Core.Controls.Add(Core_ChangeJavaFilename);
            TabPage_Core.Controls.Add(Core_JavaFilename);
            TabPage_Core.Controls.Add(Core_Label_JavaFilename);
            TabPage_Core.Location = new Point(4, 26);
            TabPage_Core.Name = "TabPage_Core";
            TabPage_Core.Size = new Size(1264, 655);
            TabPage_Core.TabIndex = 2;
            TabPage_Core.Text = "Core";
            TabPage_Core.UseVisualStyleBackColor = true;
            // 
            // Core_CoreArguments
            // 
            Core_CoreArguments.Location = new Point(136, 109);
            Core_CoreArguments.Name = "Core_CoreArguments";
            Core_CoreArguments.Size = new Size(552, 25);
            Core_CoreArguments.TabIndex = 9;
            Core_CoreArguments.TextChanged += Core_CoreArguments_TextChanged;
            // 
            // Core_Label_CoreArguments
            // 
            Core_Label_CoreArguments.AutoSize = true;
            Core_Label_CoreArguments.Location = new Point(32, 112);
            Core_Label_CoreArguments.Name = "Core_Label_CoreArguments";
            Core_Label_CoreArguments.Size = new Size(102, 17);
            Core_Label_CoreArguments.TabIndex = 8;
            Core_Label_CoreArguments.Text = "Core arguments";
            // 
            // Core_ChangeCoreFilename
            // 
            Core_ChangeCoreFilename.Location = new Point(694, 78);
            Core_ChangeCoreFilename.Name = "Core_ChangeCoreFilename";
            Core_ChangeCoreFilename.Size = new Size(75, 25);
            Core_ChangeCoreFilename.TabIndex = 7;
            Core_ChangeCoreFilename.Text = "Change";
            Core_ChangeCoreFilename.UseVisualStyleBackColor = true;
            Core_ChangeCoreFilename.Click += Core_ChangeCoreFilename_Click;
            // 
            // Core_CoreFilename
            // 
            Core_CoreFilename.Location = new Point(136, 78);
            Core_CoreFilename.Name = "Core_CoreFilename";
            Core_CoreFilename.Size = new Size(552, 25);
            Core_CoreFilename.TabIndex = 6;
            Core_CoreFilename.TextChanged += Core_CoreFilename_TextChanged;
            // 
            // Core_Label_CoreFilename
            // 
            Core_Label_CoreFilename.AutoSize = true;
            Core_Label_CoreFilename.Location = new Point(44, 81);
            Core_Label_CoreFilename.Name = "Core_Label_CoreFilename";
            Core_Label_CoreFilename.Size = new Size(89, 17);
            Core_Label_CoreFilename.TabIndex = 5;
            Core_Label_CoreFilename.Text = "Core filename";
            // 
            // Core_JavaArguments
            // 
            Core_JavaArguments.Location = new Point(136, 47);
            Core_JavaArguments.Name = "Core_JavaArguments";
            Core_JavaArguments.Size = new Size(552, 25);
            Core_JavaArguments.TabIndex = 4;
            Core_JavaArguments.TextChanged += Core_JavaArguments_TextChanged;
            // 
            // Core_Label_JavaArguments
            // 
            Core_Label_JavaArguments.AutoSize = true;
            Core_Label_JavaArguments.Location = new Point(31, 50);
            Core_Label_JavaArguments.Name = "Core_Label_JavaArguments";
            Core_Label_JavaArguments.Size = new Size(99, 17);
            Core_Label_JavaArguments.TabIndex = 3;
            Core_Label_JavaArguments.Text = "Java arguments";
            // 
            // Core_ChangeJavaFilename
            // 
            Core_ChangeJavaFilename.Location = new Point(694, 16);
            Core_ChangeJavaFilename.Name = "Core_ChangeJavaFilename";
            Core_ChangeJavaFilename.Size = new Size(75, 25);
            Core_ChangeJavaFilename.TabIndex = 2;
            Core_ChangeJavaFilename.Text = "Change";
            Core_ChangeJavaFilename.UseVisualStyleBackColor = true;
            Core_ChangeJavaFilename.Click += Core_ChangeJavaFilename_Click;
            // 
            // Core_JavaFilename
            // 
            Core_JavaFilename.Location = new Point(136, 16);
            Core_JavaFilename.Name = "Core_JavaFilename";
            Core_JavaFilename.Size = new Size(552, 25);
            Core_JavaFilename.TabIndex = 1;
            Core_JavaFilename.TextChanged += Core_JavaFilename_TextChanged;
            // 
            // Core_Label_JavaFilename
            // 
            Core_Label_JavaFilename.AutoSize = true;
            Core_Label_JavaFilename.Location = new Point(44, 19);
            Core_Label_JavaFilename.Name = "Core_Label_JavaFilename";
            Core_Label_JavaFilename.Size = new Size(86, 17);
            Core_Label_JavaFilename.TabIndex = 0;
            Core_Label_JavaFilename.Text = "Java filename";
            // 
            // TabPage_Backup
            // 
            TabPage_Backup.Controls.Add(Backup_Interval);
            TabPage_Backup.Controls.Add(Backup_Label_Interval);
            TabPage_Backup.Controls.Add(Backup_Label_Folder);
            TabPage_Backup.Controls.Add(Backup_Folder);
            TabPage_Backup.Controls.Add(Backup_Tree);
            TabPage_Backup.Location = new Point(4, 26);
            TabPage_Backup.Name = "TabPage_Backup";
            TabPage_Backup.Size = new Size(1264, 655);
            TabPage_Backup.TabIndex = 3;
            TabPage_Backup.Text = "Backup";
            TabPage_Backup.UseVisualStyleBackColor = true;
            // 
            // Backup_Interval
            // 
            Backup_Interval.Location = new Point(200, 44);
            Backup_Interval.Maximum = new decimal(new int[] { 35000, 0, 0, 0 });
            Backup_Interval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Backup_Interval.Name = "Backup_Interval";
            Backup_Interval.Size = new Size(200, 25);
            Backup_Interval.TabIndex = 5;
            Backup_Interval.Value = new decimal(new int[] { 5, 0, 0, 0 });
            Backup_Interval.ValueChanged += Backup_Interval_ValueChanged;
            // 
            // Backup_Label_Interval
            // 
            Backup_Label_Interval.AutoSize = true;
            Backup_Label_Interval.Location = new Point(42, 46);
            Backup_Label_Interval.Name = "Backup_Label_Interval";
            Backup_Label_Interval.Size = new Size(152, 17);
            Backup_Label_Interval.TabIndex = 4;
            Backup_Label_Interval.Text = "Backup Interval (minutes)";
            // 
            // Backup_Label_Folder
            // 
            Backup_Label_Folder.AutoSize = true;
            Backup_Label_Folder.Location = new Point(106, 15);
            Backup_Label_Folder.Name = "Backup_Label_Folder";
            Backup_Label_Folder.Size = new Size(88, 17);
            Backup_Label_Folder.TabIndex = 2;
            Backup_Label_Folder.Text = "Backup folder";
            // 
            // Backup_Folder
            // 
            Backup_Folder.Location = new Point(200, 12);
            Backup_Folder.Name = "Backup_Folder";
            Backup_Folder.Size = new Size(200, 25);
            Backup_Folder.TabIndex = 1;
            Backup_Folder.TextChanged += Backup_Folder_TextChanged;
            // 
            // Backup_Tree
            // 
            Backup_Tree.BorderStyle = BorderStyle.None;
            Backup_Tree.CheckBoxes = true;
            Backup_Tree.Location = new Point(630, 0);
            Backup_Tree.Name = "Backup_Tree";
            Backup_Tree.Size = new Size(632, 655);
            Backup_Tree.TabIndex = 0;
            Backup_Tree.AfterCheck += Backup_Tree_AfterCheck;
            // 
            // TabPage_Task
            // 
            TabPage_Task.Location = new Point(4, 26);
            TabPage_Task.Name = "TabPage_Task";
            TabPage_Task.Size = new Size(1264, 655);
            TabPage_Task.TabIndex = 5;
            TabPage_Task.Text = "Task";
            TabPage_Task.UseVisualStyleBackColor = true;
            // 
            // TabPage_Settings
            // 
            TabPage_Settings.Location = new Point(4, 26);
            TabPage_Settings.Name = "TabPage_Settings";
            TabPage_Settings.Size = new Size(1264, 655);
            TabPage_Settings.TabIndex = 4;
            TabPage_Settings.Text = "Settings";
            TabPage_Settings.UseVisualStyleBackColor = true;
            // 
            // Main_Timer_Autobackup
            // 
            Main_Timer_Autobackup.Interval = 300000;
            Main_Timer_Autobackup.Tick += Main_Timer_Autobackup_Tick;
            // 
            // Main_Timer_Counter
            // 
            Main_Timer_Counter.Enabled = true;
            Main_Timer_Counter.Interval = 1500;
            Main_Timer_Counter.Tick += Main_Timer_Counter_Tick;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1264, 681);
            Controls.Add(TabControl_Main);
            Enabled = false;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 4, 2, 4);
            Name = "Form_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ServerGUI";
            FormClosed += Form_Main_FormClosed;
            Load += Form_Main_FormLoad;
            TabControl_Main.ResumeLayout(false);
            TabPage_Main.ResumeLayout(false);
            TabPage_Main.PerformLayout();
            Main_Label_Ram.ResumeLayout(false);
            Main_Label_Cpu.ResumeLayout(false);
            Main_Label_Backup.ResumeLayout(false);
            Main_Label_Server.ResumeLayout(false);
            TabPage_Core.ResumeLayout(false);
            TabPage_Core.PerformLayout();
            TabPage_Backup.ResumeLayout(false);
            TabPage_Backup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Backup_Interval).EndInit();
            ResumeLayout(false);
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

