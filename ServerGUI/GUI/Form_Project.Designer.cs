namespace ServerGUI.GUI
{
    partial class Form_Project
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Project));
            this.Main_OpenProject = new System.Windows.Forms.Button();
            this.Main_ProjectList = new System.Windows.Forms.ListBox();
            this.Main_CreateProject = new System.Windows.Forms.Button();
            this.Main_DeleteProject = new System.Windows.Forms.Button();
            this.Main_Dialog_ChooseFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // Main_OpenProject
            // 
            this.Main_OpenProject.Enabled = false;
            this.Main_OpenProject.Location = new System.Drawing.Point(20, 300);
            this.Main_OpenProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main_OpenProject.Name = "Main_OpenProject";
            this.Main_OpenProject.Size = new System.Drawing.Size(100, 35);
            this.Main_OpenProject.TabIndex = 0;
            this.Main_OpenProject.Text = "Open project";
            this.Main_OpenProject.UseVisualStyleBackColor = true;
            this.Main_OpenProject.Click += new System.EventHandler(this.Main_OpenProject_Click);
            // 
            // Main_ProjectList
            // 
            this.Main_ProjectList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Main_ProjectList.FormattingEnabled = true;
            this.Main_ProjectList.ItemHeight = 17;
            this.Main_ProjectList.Location = new System.Drawing.Point(0, 0);
            this.Main_ProjectList.Margin = new System.Windows.Forms.Padding(0);
            this.Main_ProjectList.Name = "Main_ProjectList";
            this.Main_ProjectList.Size = new System.Drawing.Size(384, 272);
            this.Main_ProjectList.TabIndex = 1;
            this.Main_ProjectList.SelectedIndexChanged += new System.EventHandler(this.Main_ProjectList_SelectedIndexChanged);
            // 
            // Main_CreateProject
            // 
            this.Main_CreateProject.Location = new System.Drawing.Point(140, 300);
            this.Main_CreateProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main_CreateProject.Name = "Main_CreateProject";
            this.Main_CreateProject.Size = new System.Drawing.Size(100, 35);
            this.Main_CreateProject.TabIndex = 2;
            this.Main_CreateProject.Text = "Create project";
            this.Main_CreateProject.UseVisualStyleBackColor = true;
            this.Main_CreateProject.Click += new System.EventHandler(this.Main_CreateProject_Click);
            // 
            // Main_DeleteProject
            // 
            this.Main_DeleteProject.Enabled = false;
            this.Main_DeleteProject.Location = new System.Drawing.Point(260, 300);
            this.Main_DeleteProject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Main_DeleteProject.Name = "Main_DeleteProject";
            this.Main_DeleteProject.Size = new System.Drawing.Size(100, 35);
            this.Main_DeleteProject.TabIndex = 4;
            this.Main_DeleteProject.Text = "Delete project";
            this.Main_DeleteProject.UseVisualStyleBackColor = true;
            this.Main_DeleteProject.Click += new System.EventHandler(this.Main_DeleteProject_Click);
            // 
            // Form_Project
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.Main_DeleteProject);
            this.Controls.Add(this.Main_CreateProject);
            this.Controls.Add(this.Main_ProjectList);
            this.Controls.Add(this.Main_OpenProject);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_Project";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose project";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Project_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Main_OpenProject;
        private System.Windows.Forms.ListBox Main_ProjectList;
        private System.Windows.Forms.Button Main_CreateProject;
        private System.Windows.Forms.Button Main_DeleteProject;
        private System.Windows.Forms.FolderBrowserDialog Main_Dialog_ChooseFolder;
    }
}