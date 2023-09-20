using System.Text.Json;

namespace ServerGUI.Utilities.Project;

public class ProjectManager
{
    private readonly string _projectPath;

    public ProjectManager(string projectPath)
    {
        _projectPath = projectPath;
    }

    public ProjectModel Project { get; private set; } = new();

    public void Load()
    {
        if (File.Exists(GetProjectFilePath()))
            Project = LoadFromFile<ProjectModel>(GetProjectFilePath()) ?? new ProjectModel();

        SaveToFile(Project, GetProjectFilePath());
    }

    public void Save()
    {
        SaveToFile(Project, GetProjectFilePath());
    }

    private string GetProjectFilePath()
    {
        return Path.Join(_projectPath, "project.json");
    }

    private static void SaveToFile<T>(T data, string filePath)
    {
        var json = JsonSerializer.Serialize(data);
        File.WriteAllText(filePath, json);
    }

    private static T? LoadFromFile<T>(string filePath)
    {
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}