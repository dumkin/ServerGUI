using Microsoft.Win32;

namespace ServerGUI.Utilities.Project;

public class Project
{
    public bool AutoBackup = false;
    public bool AutoRestart = false;
    public string BackupFolder = "backups";

    public int BackupInterval = 5;
    public List<string> BackupList = new();
    public string CoreArguments;

    public string CoreFileName;
    public string JavaArguments;

    public string JavaFileName = JavaPath() + "\\bin\\java.exe";

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