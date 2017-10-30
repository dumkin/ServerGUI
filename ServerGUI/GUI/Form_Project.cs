using ServerGUI.Utilities.Config;
using ServerGUI.Utilities.Project;
using System;
using System.IO;
using System.Windows.Forms;

namespace ServerGUI.GUI
{
    public partial class Form_Project : Form
    {
        ProjectList Projects = new ProjectList();
        ConfigSystem Config = new ConfigSystem();

        public Form_Project()
        {
            InitializeComponent();

            if (File.Exists(Directory.GetCurrentDirectory() + "\\projects.json"))
            {
                Projects = Config.Load<ProjectList>(Directory.GetCurrentDirectory() + "\\projects.json");
                Projects.ProjectListRepair();
            }

            Config.Save<ProjectList>(Projects, Directory.GetCurrentDirectory() + "\\projects.json");

            foreach (var Item in Projects.Data)
            {
                Main_ProjectList.Items.Add(Item);
            }
        }
        private void Form_Project_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Main_DeleteProject_Click(object sender, EventArgs e)
        {
            string Path = Main_ProjectList.SelectedItem.ToString();

            Projects.Data.Remove(Path);
            Main_ProjectList.Items.RemoveAt(Main_ProjectList.SelectedIndex);

            Config.Save<ProjectList>(Projects, Directory.GetCurrentDirectory() + "\\projects.json");

            Directory.Delete(Path + "\\ServerGUI", true);
        }
        private void Main_CreateProject_Click(object sender, EventArgs e)
        {
            if (Main_Dialog_ChooseFolder.ShowDialog() == DialogResult.OK)
            {
                Main_ProjectList.Items.Add(Main_Dialog_ChooseFolder.SelectedPath);
                Directory.CreateDirectory(Main_Dialog_ChooseFolder.SelectedPath + "\\ServerGUI");
                Projects.Data.Add(Main_Dialog_ChooseFolder.SelectedPath);
                Config.Save(Projects, Directory.GetCurrentDirectory() + "\\projects.json");

                Form_Main.WorkingDirectory = Main_Dialog_ChooseFolder.SelectedPath;
                Hide();
            }
        }
        private void Main_OpenProject_Click(object sender, EventArgs e)
        {
            Form_Main.WorkingDirectory = Main_ProjectList.SelectedItem.ToString();
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
}