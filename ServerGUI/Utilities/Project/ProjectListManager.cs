using System.Text.Json;

namespace ServerGUI.Utilities.Project;

public class ProjectListManager
{
    private readonly string _projectsFilePath;
    private ProjectListModel _projectList = new();

    public ProjectListManager(string projectsFilePath)
    {
        _projectsFilePath = projectsFilePath;
    }

    public void Load()
    {
        if (File.Exists(_projectsFilePath))
            _projectList = LoadFromFile<ProjectListModel>(_projectsFilePath) ?? new ProjectListModel();

        Repair();

        SaveToFile(_projectList, _projectsFilePath);
    }

    public void Create(string path)
    {
        var projectPath = GetProjectDirectory(path);
        if (!Directory.Exists(projectPath)) Directory.CreateDirectory(projectPath);

        _projectList.Paths.Add(path);

        Repair();

        SaveToFile(_projectList, _projectsFilePath);
    }

    public string Get(string path)
    {
        return GetProjectDirectory(path);
    }

    public void Delete(string path)
    {
        _projectList.Paths.Remove(path);

        SaveToFile(_projectList, _projectsFilePath);
    }

    public HashSet<string> GetAll()
    {
        return _projectList.Paths;
    }

    private void Repair()
    {
        bool ProjectExists(string projectPath)
        {
            return Directory.Exists(GetProjectDirectory(projectPath));
        }

        var validProjects = new ProjectListModel();

        foreach (var projectPath in _projectList.Paths.Where(ProjectExists)) validProjects.Paths.Add(projectPath);

        _projectList = validProjects;
    }

    private static string GetProjectDirectory(string path)
    {
        return Path.Join(path, ".manager");
    }

    private static void SaveToFile<T>(T data, string filePath)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });
        File.WriteAllText(filePath, json);
    }

    private static T? LoadFromFile<T>(string filePath)
    {
        var json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(json);
    }
}