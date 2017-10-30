using ServerGUI.Utilities.Triggers;
using System;

namespace ServerGUI.Utilities.Task
{
    public class Task
    {
        public ITrigger Trigger;

        public Task(String Name)
        {
            if (Name == "TriggerWorldSaved")
            {
                Trigger = new TriggerWorldSaved();
            }
            else if (Name == "TriggerPlayerJoin")
            {
                Trigger = new TriggerPlayerJoin();
            }
            else if (Name == "TriggerPlayerLeft")
            {
                Trigger = new TriggerPlayerLeft();
            }
        }
    }
}
