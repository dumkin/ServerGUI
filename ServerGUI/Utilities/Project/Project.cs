using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace ServerGUI.Utilities.Project
{
    public class Project
    {
        public bool AutoRestart = false;
        public bool AutoBackup = false;

        public String JavaFileName = JavaPath() + "\\bin\\java.exe";
        public String JavaArguments;

        public String CoreFileName;
        public String CoreArguments;

        public int BackupInterval = 5;
        public String BackupFolder = "backups";
        public List<String> BackupList = new List<String>();

        private static String JavaPath()
        {
            try
            {
                String javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment";
                var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey);

                String currentVersion = baseKey.GetValue("CurrentVersion").ToString();
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