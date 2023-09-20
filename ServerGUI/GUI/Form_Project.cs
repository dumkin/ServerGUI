using ServerGUI.Utilities.Project;

namespace ServerGUI.GUI;

public partial class FormProject : Form
{
    private readonly ProjectListManager _projectManager;
    public string? SelectedPath;

    public FormProject(ProjectListManager projectManager)
    {
        _projectManager = projectManager;

        InitializeComponent();

        foreach (var path in _projectManager.GetAll()) Main_ProjectList.Items.Add(path);
    }

    private void Form_Project_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void Main_DeleteProject_Click(object sender, EventArgs e)
    {
        var selectedPath = Main_ProjectList.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedPath)) return;

        _projectManager.Delete(selectedPath);
        Main_ProjectList.Items.RemoveAt(Main_ProjectList.SelectedIndex);
    }

    private void Main_CreateProject_Click(object sender, EventArgs e)
    {
        if (Main_Dialog_ChooseFolder.ShowDialog() != DialogResult.OK) return;

        Main_ProjectList.Items.Add(Main_Dialog_ChooseFolder.SelectedPath);
        _projectManager.Create(Main_Dialog_ChooseFolder.SelectedPath);

        SelectedPath = Main_Dialog_ChooseFolder.SelectedPath;
        Hide();
    }

    private void Main_OpenProject_Click(object sender, EventArgs e)
    {
        var selectedPath = Main_ProjectList.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedPath)) return;

        SelectedPath = selectedPath;
        Hide();
    }

    private void Main_ProjectList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (Main_ProjectList.SelectedIndex >= 0)
        {
            Main_OpenProject.Enabled = true;
            Main_DeleteProject.Enabled = true;
        }
        else
        {
            Main_OpenProject.Enabled = false;
            Main_DeleteProject.Enabled = false;
        }
    }
}