namespace ServerGUI.Utilities.Project;

public record ProjectListModel
{
    public HashSet<string> Paths { get; set; } = new();
}