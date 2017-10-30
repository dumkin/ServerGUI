using System;
using System.IO;
using System.IO.Compression;

namespace ServerGUI.Utilities.Backup
{
    public class Backup
    {
        public string WorkingDirectory { get; set; }
        public string BackupDirectoryName { get; set; }
        public string[] Sources;

        public void Create()
        {
            string DateAndTime = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            string TemporaryDirectory = WorkingDirectory + "\\" + BackupDirectoryName + "\\" + DateAndTime + " temp";
            string BackupDirectory = WorkingDirectory + "\\" + BackupDirectoryName;

            Directory.CreateDirectory(TemporaryDirectory);

            foreach (string Source in Sources)
            {
                if (File.Exists(WorkingDirectory + "\\" + Source))
                {
                    Directory.CreateDirectory(TemporaryDirectory);
                    File.Copy(WorkingDirectory + "\\" + Source, TemporaryDirectory + "\\" + Source, true);
                }
                else
                {
                    CopyContentDirectory(WorkingDirectory + "\\" + Source, TemporaryDirectory + "\\" + Source);
                }
            }

            ZipFile.CreateFromDirectory(TemporaryDirectory, BackupDirectory + "\\" + DateAndTime + ".zip", CompressionLevel.Optimal, false);

            Directory.Delete(TemporaryDirectory, true);
        }

        private void CopyContentDirectory(string SourcePath, string DestinationPath)
        {
            Directory.CreateDirectory(DestinationPath);

            foreach (string dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

            foreach (string newPath in Directory.GetFiles(SourcePath, "*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
        }
    }
}
