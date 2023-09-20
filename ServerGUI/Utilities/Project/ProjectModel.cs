using Microsoft.Win32;

namespace ServerGUI.Utilities.Project;

public class ProjectModel
{
    public bool AutoBackup { get; set; } = false;
    public bool AutoRestart { get; set; } = false;
    public string BackupFolder { get; set; } = "backups";

    public int BackupInterval { get; set; } = 5;
    public List<string> BackupList { get; set; } = new();
    public string CoreArguments { get; set; }

    public string CoreFileName { get; set; }
    public string JavaArguments { get; set; }

    public string JavaFileName { get; set; } = JavaPath() + "\\bin\\java.exe";

    private static string JavaPath()
    {
        try
        {
            var javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment";
            var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
                .OpenSubKey(javaKey);

            var currentVersion = baseKey.GetValue("CurrentVersion").ToString();
            var homeKey = baseKey.OpenSubKey(currentVersion);
            return homeKey.GetValue("JavaHome").ToString();
        }
        catch (Exception)
        {
            return "[PASTE_HERE_PATH_TO_JAVA]";
        }
    }
}