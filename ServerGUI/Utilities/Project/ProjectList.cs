using System;
using System.Collections.Generic;
using System.IO;

namespace ServerGUI.Utilities.Project
{
    public class ProjectList
    {
        public List<String> Data = new List<String>();

        public bool CheckCorrect(String Path)
        {
            return Directory.Exists(Path + "//ServerGUI");
        }
        public void ProjectListRepair()
        {
            List<String> NewData = new List<String>();

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
