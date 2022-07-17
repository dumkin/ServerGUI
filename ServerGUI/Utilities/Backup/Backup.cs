using System.IO.Compression;

namespace ServerGUI.Utilities.Backup;

public class Backup
{
    public string[] Sources;
    public string WorkingDirectory { get; set; }
    public string BackupDirectoryName { get; set; }

    public void Create()
    {
        var DateAndTime = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
        var TemporaryDirectory = WorkingDirectory + "\\" + BackupDirectoryName + "\\" + DateAndTime + " temp";
        var BackupDirectory = WorkingDirectory + "\\" + BackupDirectoryName;

        Directory.CreateDirectory(TemporaryDirectory);

        foreach (var Source in Sources)
            if (File.Exists(WorkingDirectory + "\\" + Source))
            {
                Directory.CreateDirectory(TemporaryDirectory);
                File.Copy(WorkingDirectory + "\\" + Source, TemporaryDirectory + "\\" + Source, true);
            }
            else
            {
                CopyContentDirectory(WorkingDirectory + "\\" + Source, TemporaryDirectory + "\\" + Source);
            }

        ZipFile.CreateFromDirectory(TemporaryDirectory, BackupDirectory + "\\" + DateAndTime + ".zip",
            CompressionLevel.Optimal, false);

        Directory.Delete(TemporaryDirectory, true);
    }

    private void CopyContentDirectory(string SourcePath, string DestinationPath)
    {
        Directory.CreateDirectory(DestinationPath);

        foreach (var dirPath in Directory.GetDirectories(SourcePath, "*", SearchOption.AllDirectories))
            Directory.CreateDirectory(dirPath.Replace(SourcePath, DestinationPath));

        foreach (var newPath in Directory.GetFiles(SourcePath, "*", SearchOption.AllDirectories))
            File.Copy(newPath, newPath.Replace(SourcePath, DestinationPath), true);
    }
}