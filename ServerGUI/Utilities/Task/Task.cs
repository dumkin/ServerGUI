using ServerGUI.Utilities.Triggers;

namespace ServerGUI.Utilities.Task;

public class Task
{
    public ITrigger Trigger;

    public Task(string Name)
    {
        if (Name == "TriggerWorldSaved")
            Trigger = new TriggerWorldSaved();
        else if (Name == "TriggerPlayerJoin")
            Trigger = new TriggerPlayerJoin();
        else if (Name == "TriggerPlayerLeft") Trigger = new TriggerPlayerLeft();
    }
}