using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace ServerGUI.Utilities.Project
{
    public class Project
    {
        public bool AutoRestart = false;
        public bool AutoBackup = false;

        public string JavaFileName = JavaPath() + "\\bin\\java.exe";
        public string JavaArguments;

        public string CoreFileName;
        public string CoreArguments;

        public int BackupInterval = 5;
        public string BackupFolder = "backups";
        public List<string> BackupList = new List<string>();

        private static string JavaPath()
        {
            try
            {
                string javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment";
                var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey);

                string currentVersion = baseKey.GetValue("CurrentVersion").ToString();
                var homeKey = baseKey.OpenSubKey(currentVersion);
                return homeKey.GetValue("JavaHome").ToString();
            }
            catch (Exception)
            {
                return "[PASTE_HERE_PATH_TO_JAVA]";
            }
        }
    }
}