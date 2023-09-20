using System.Diagnostics;
using System.Text.RegularExpressions;
using ServerGUI.GUI;
using ServerGUI.Server;
using ServerGUI.Server.Vault;
using ServerGUI.Utilities.Backup;
using ServerGUI.Utilities.Counter;
using ServerGUI.Utilities.Project;
using ServerGUI.Utilities.Task;

namespace ServerGUI;

public partial class Form_Main : Form
{
    public static string WorkingDirectory = "";

    private readonly ProjectListManager _projectListManager;
    private readonly Backup Backup = new();
    private readonly CounterCpu CounterCpuCurrent = new(Process.GetCurrentProcess().Id);

    private readonly CounterCpu CounterCpuTotal = new();
    private readonly CounterRam CounterRamCurrent = new(Process.GetCurrentProcess().Id);

    private readonly CounterRam CounterRamTotal = new();
    private readonly ServerHandle Server = new();
    private ProjectManager? _projectManager;
    public List<string> BackupList = new();

    public Form_Main()
    {
        _projectListManager = new ProjectListManager(Path.Join(Directory.GetCurrentDirectory(), "projects.json"));

        InitializeComponent();
    }

    private ProjectModel Project => _projectManager.Project;

    private void Form_Main_FormLoad(object sender, EventArgs e)
    {
        _projectListManager.Load();

        var formProject = new FormProject(_projectListManager);
        formProject.ShowDialog();

        if (string.IsNullOrEmpty(formProject.SelectedPath)) return;

        WorkingDirectory = formProject.SelectedPath;
        _projectManager = new ProjectManager(_projectListManager.Get(formProject.SelectedPath));
        _projectManager.Load();

        Server.Process.SetCallbackOutput(ServerOutput);
        Server.Process.SetCallbackStateChanged(ServerStateChanged);

        LoadConfig();

        Server.Process.WorkingDirectory = WorkingDirectory;
        Backup.WorkingDirectory = WorkingDirectory;
        var DirectoryInfo = new DirectoryInfo(WorkingDirectory);

        if (DirectoryInfo.Exists) Backup_Tree_Build(DirectoryInfo, Backup_Tree.Nodes, true);

        Backup_Tree_Load(Backup_Tree.Nodes);

        Enabled = true;
        SaveConfig();
    }

    private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
    {
        if (Server.Process.Enabled)
        {
            Server.Process.Stop();
            Server.Process.WaitStopProcess();
        }
    }

    private void SaveConfig()
    {
        if (!Enabled) return;

        Project.AutoRestart = Main_Autorestart.Checked;
        Project.AutoBackup = Main_Autobackup.Checked;

        Project.JavaFileName = Core_JavaFilename.Text;
        Project.JavaArguments = Core_JavaArguments.Text;
        Project.CoreFileName = Core_CoreFilename.Text;
        Project.CoreArguments = Core_CoreArguments.Text;

        Project.BackupFolder = Backup_Folder.Text;
        Project.BackupInterval = Convert.ToInt32(Backup_Interval.Value);
        Project.BackupList = BackupList;

        _projectManager?.Save();
        // ConfigSystem.Save(Project, WorkingDirectory + "\\ServerGUI\\config.json");
    }

    private void LoadConfig()
    {
        Main_Autorestart.Checked = Project.AutoRestart;
        Main_Autobackup.Checked = Project.AutoBackup;

        Core_JavaFilename.Text = Project.JavaFileName;
        Core_JavaArguments.Text = Project.JavaArguments;

        Core_CoreFilename.Text = Project.CoreFileName;
        Core_CoreArguments.Text = Project.CoreArguments;

        Backup_Folder.Text = Project.BackupFolder;
        Backup_Interval.Value = Project.BackupInterval;
        BackupList = Project.BackupList;
    }

    private void ServerOutput(string Text)
    {
        BeginInvoke(new MethodInvoker(delegate
        {
            if (!string.IsNullOrEmpty(Text)) Main_Log_Write(Text);
        }));
    }

    private void ServerStateChanged()
    {
        BeginInvoke(new MethodInvoker(delegate
        {
            if (!Server.Process.Enabled && Main_Autorestart.Checked)
            {
                Server.Process.Start();
                return;
            }

            if (Server.Process.Enabled)
            {
                Main_Switch.Text = "Stop";
                Main_Timer_Autobackup.Start();
            }
            else
            {
                Main_Switch.Text = "Start";
                Main_Timer_Autobackup.Stop();
            }

            Main_Switch.Enabled = true;
            Main_Autorestart.Enabled = true;
        }));
    }

    private void Main_Log_Write(string Text)
    {
        VaultLog.Data.Add(Text);

        var IndexLastSymbol = Main_Log.Text.Length;

        var color = Color.Black;

        var regexMainInfo = new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[main/INFO\\]: ", RegexOptions.IgnoreCase);
        var regexMainWarning =
            new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[main/WARN\\]: ", RegexOptions.IgnoreCase);
        var regexInfo = new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[Server thread/INFO\\]: ",
            RegexOptions.IgnoreCase);
        var regexWarning = new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[Server thread/WARN\\]: ",
            RegexOptions.IgnoreCase);
        var regexError = new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[Server thread/ERROR\\]: ",
            RegexOptions.IgnoreCase);
        var regexShutdown = new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[Server Shutdown Thread/INFO\\]: ",
            RegexOptions.IgnoreCase);

        if (regexInfo.IsMatch(Text) || regexMainInfo.IsMatch(Text))
            color = Color.Blue;
        else if (regexWarning.IsMatch(Text) || regexMainWarning.IsMatch(Text))
            color = Color.Orange;
        else if (regexError.IsMatch(Text))
            color = Color.Red;
        else if (regexShutdown.IsMatch(Text)) color = Color.BlueViolet;

        Text += "\n";

        Main_Log.AppendText(Text);
        Main_Log.Select(IndexLastSymbol, Text.Length);
        Main_Log.SelectionColor = color;

        Main_Log.Select(IndexLastSymbol, 0);
    }

    private void Main_Switch_Click(object sender, EventArgs e)
    {
        Main_Autorestart.Enabled = false;
        Main_Switch.Enabled = false;

        if (Server.Process.Enabled)
            Server.Process.Stop();
        else
            Server.Process.Start();
    }

    private void Main_Command_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)13)
        {
            Server.Process.SendCommand(Main_Command.Text);
            Main_Command.Text = "";
        }
    }

    private void Main_BackupNow_Click(object sender, EventArgs e)
    {
        Create_Backup();
    }

    private void Main_Timer_Autobackup_Tick(object sender, EventArgs e)
    {
        if (Main_Autobackup.Checked) Create_Backup();
    }

    private void Create_Backup()
    {
        new Thread(() =>
        {
            if (Server.Process.Enabled)
            {
                var Task = new TaskTriger("TriggerWorldSaved");
                Server.Process.SendCommand("save-all");

                while (!Task.Trigger.Check()) Thread.Sleep(1000);
            }

            BeginInvoke(new MethodInvoker(delegate { Main_Log_Write("Backup creating"); }));

            Backup.Sources = BackupList.ToArray();

            Backup.Create();

            BeginInvoke(new MethodInvoker(delegate { Main_Log_Write("Backup created successfully!"); }));
        }).Start();
    }

    private void Main_Autorestart_CheckedChanged(object sender, EventArgs e)
    {
        SaveConfig();
    }

    private void Main_Autobackup_CheckedChanged(object sender, EventArgs e)
    {
        SaveConfig();
    }

    private void Main_Timer_Counter_Tick(object sender, EventArgs e)
    {
        var CpuGuiValue = CounterCpuCurrent.GetUsage();
        CpuGui.Text = CpuGuiValue + "%";
        CpuGuiProgress.Value = CpuGuiValue;

        var CpuTotalValue = CounterCpuTotal.GetUsage();
        CpuTotal.Text = CpuTotalValue + "%";
        CpuTotalProgress.Value = CpuTotalValue;

        if (Server.Process.Enabled)
        {
            var CpuServerValue = Server.Process.CounterCpu.GetUsage();
            CpuServer.Text = CpuServerValue + "%";
            CpuServerProgress.Value = CpuServerValue;
        }
        else
        {
            CpuServer.Text = "0%";
            CpuServerProgress.Value = 0;
        }

        var RamGuiValue = CounterRamCurrent.GetUsage();
        var RamGuiPercent = CounterRamCurrent.GetUsagePercent();
        RamGui.Text = RamGuiValue + " MB (" + RamGuiPercent + "%)";
        RamGuiProgress.Value = RamGuiPercent;

        var RamTotalValue = CounterRamTotal.GetUsage();
        var RamTotalPercent = CounterRamTotal.GetUsagePercent();
        RamTotal.Text = RamTotalValue + " MB (" + RamTotalPercent + "%)";
        RamTotalProgress.Value = RamTotalPercent;

        if (Server.Process.Enabled)
        {
            var RamServerValue = Server.Process.CounterRam.GetUsage();
            var RamServerPercent = Server.Process.CounterRam.GetUsagePercent();
            RamServer.Text = RamServerValue + " MB (" + RamServerPercent + "%)";
            RamServerProgress.Value = RamServerPercent;
        }
        else
        {
            RamServer.Text = "0 MB (0%)";
            RamServerProgress.Value = 0;
        }
    }

    private void Core_JavaFilename_TextChanged(object sender, EventArgs e)
    {
        SaveConfig();

        Server.Process.JavaFilename = Core_JavaFilename.Text;
    }

    private void Core_ChangeJavaFilename_Click(object sender, EventArgs e)
    {
        var Dialog = new OpenFileDialog
        {
            InitialDirectory = WorkingDirectory,
            Filter = "Java file|java.exe"
        };

        if (Dialog.ShowDialog() == DialogResult.OK) Core_JavaFilename.Text = Dialog.FileName;
    }

    private void Core_JavaArguments_TextChanged(object sender, EventArgs e)
    {
        SaveConfig();

        Server.Process.JavaArguments = Core_JavaArguments.Text;
    }

    private void Core_CoreFilename_TextChanged(object sender, EventArgs e)
    {
        SaveConfig();

        Server.Process.CoreFilename = Core_CoreFilename.Text;
    }

    private void Core_ChangeCoreFilename_Click(object sender, EventArgs e)
    {
        var Dialog = new OpenFileDialog
        {
            InitialDirectory = WorkingDirectory,
            Filter = "Jar file|*.jar"
        };

        if (Dialog.ShowDialog() == DialogResult.OK) Core_CoreFilename.Text = Dialog.FileName;
    }

    private void Core_CoreArguments_TextChanged(object sender, EventArgs e)
    {
        SaveConfig();

        Server.Process.CoreArguments = Core_CoreArguments.Text;
    }

    private void Backup_Tree_AfterCheck(object sender, TreeViewEventArgs e)
    {
        if (!Enabled) return;

        if (e.Node.Checked)
            BackupList.Add(e.Node.FullPath);
        else
            BackupList.Remove(e.Node.FullPath);

        SaveConfig();
    }

    private void Backup_Tree_Build(DirectoryInfo directoryInfo, TreeNodeCollection addInMe, bool FirstExec)
    {
        var Nodes = addInMe;
        if (!FirstExec) Nodes = addInMe.Add(directoryInfo.Name).Nodes;

        foreach (var file in directoryInfo.GetFiles()) Nodes.Add(file.FullName, file.Name);
        foreach (var subdir in directoryInfo.GetDirectories()) Backup_Tree_Build(subdir, Nodes, false);
    }

    private void Backup_Folder_TextChanged(object sender, EventArgs e)
    {
        SaveConfig();

        Backup.BackupDirectoryName = Backup_Folder.Text;
    }

    private void Backup_Interval_ValueChanged(object sender, EventArgs e)
    {
        SaveConfig();

        Main_Timer_Autobackup.Interval = Convert.ToInt32(Backup_Interval.Value) * 60 * 1000;
    }

    private void Backup_Tree_Load(TreeNodeCollection Nodes)
    {
        foreach (TreeNode Item in Nodes)
        {
            if (BackupList.Contains(Item.FullPath)) Item.Checked = true;

            if (Item.Nodes.Count > 0) Backup_Tree_Load(Item.Nodes);
        }
    }
}