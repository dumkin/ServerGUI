using System.Collections.Generic;
using System.IO;

namespace ServerGUI.Utilities.Project
{
    public class ProjectList
    {
        public List<string> Data = new List<string>();

        public bool CheckCorrect(string Path)
        {
            return Directory.Exists(Path + "//ServerGUI");
        }

        public void ProjectListRepair()
        {
            List<string> NewData = new List<string>();

            foreach (var Item in Data)
            {
                if (CheckCorrect(Item))
                {
                    NewData.Add(Item);
                }
            }

            Data = NewData;
        }
    }
}