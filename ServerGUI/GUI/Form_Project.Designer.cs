namespace ServerGUI.GUI
{
    partial class FormProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProject));
            Main_OpenProject = new Button();
            Main_ProjectList = new ListBox();
            Main_CreateProject = new Button();
            Main_DeleteProject = new Button();
            Main_Dialog_ChooseFolder = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // Main_OpenProject
            // 
            Main_OpenProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Main_OpenProject.Enabled = false;
            Main_OpenProject.Location = new Point(20, 300);
            Main_OpenProject.Margin = new Padding(3, 4, 3, 4);
            Main_OpenProject.Name = "Main_OpenProject";
            Main_OpenProject.Size = new Size(100, 35);
            Main_OpenProject.TabIndex = 0;
            Main_OpenProject.Text = "Open project";
            Main_OpenProject.UseVisualStyleBackColor = true;
            Main_OpenProject.Click += Main_OpenProject_Click;
            // 
            // Main_ProjectList
            // 
            Main_ProjectList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Main_ProjectList.BorderStyle = BorderStyle.None;
            Main_ProjectList.FormattingEnabled = true;
            Main_ProjectList.ItemHeight = 28;
            Main_ProjectList.Location = new Point(0, 0);
            Main_ProjectList.Margin = new Padding(0);
            Main_ProjectList.Name = "Main_ProjectList";
            Main_ProjectList.Size = new Size(384, 252);
            Main_ProjectList.TabIndex = 1;
            Main_ProjectList.SelectedIndexChanged += Main_ProjectList_SelectedIndexChanged;
            // 
            // Main_CreateProject
            // 
            Main_CreateProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Main_CreateProject.Location = new Point(140, 300);
            Main_CreateProject.Margin = new Padding(3, 4, 3, 4);
            Main_CreateProject.Name = "Main_CreateProject";
            Main_CreateProject.Size = new Size(100, 35);
            Main_CreateProject.TabIndex = 2;
            Main_CreateProject.Text = "Create project";
            Main_CreateProject.UseVisualStyleBackColor = true;
            Main_CreateProject.Click += Main_CreateProject_Click;
            // 
            // Main_DeleteProject
            // 
            Main_DeleteProject.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Main_DeleteProject.Enabled = false;
            Main_DeleteProject.Location = new Point(260, 300);
            Main_DeleteProject.Margin = new Padding(3, 4, 3, 4);
            Main_DeleteProject.Name = "Main_DeleteProject";
            Main_DeleteProject.Size = new Size(100, 35);
            Main_DeleteProject.TabIndex = 4;
            Main_DeleteProject.Text = "Delete project";
            Main_DeleteProject.UseVisualStyleBackColor = true;
            Main_DeleteProject.Click += Main_DeleteProject_Click;
            // 
            // FormProject
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(384, 361);
            Controls.Add(Main_DeleteProject);
            Controls.Add(Main_CreateProject);
            Controls.Add(Main_ProjectList);
            Controls.Add(Main_OpenProject);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose project";
            FormClosed += Form_Project_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button Main_OpenProject;
        private System.Windows.Forms.ListBox Main_ProjectList;
        private System.Windows.Forms.Button Main_CreateProject;
        private System.Windows.Forms.Button Main_DeleteProject;
        private System.Windows.Forms.FolderBrowserDialog Main_Dialog_ChooseFolder;
    }
}