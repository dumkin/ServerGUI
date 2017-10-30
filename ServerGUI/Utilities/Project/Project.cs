using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace ServerGUI.Utilities.Project
{
    public class Project
    {
        public bool AutoRestart = false;
        public bool AutoBackup = false;

        public String JavaFilename;
        public String JavaArguments;

        public String CoreFilename;
        public String CoreArguments;

        public String BackupFolder = "backups";
        public int BackupInterval = 5;

        public List<String> BackupList = new List<String>();

        public Project()
        {
            JavaFilename = GetJavaInstallationPath() + "\\bin\\java.exe";
        }

        private String GetJavaInstallationPath()
        {
            String javaKey = "SOFTWARE\\JavaSoft\\Java Runtime Environment";
            using (var baseKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(javaKey))
            {
                String currentVersion = baseKey.GetValue("CurrentVersion").ToString();
                using (var homeKey = baseKey.OpenSubKey(currentVersion))
                {
                    return homeKey.GetValue("JavaHome").ToString();
                }
            }
        }
    }
}
