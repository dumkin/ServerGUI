using System.Text.RegularExpressions;
using ServerGUI.Server.Vault;

namespace ServerGUI.Utilities.Triggers;

public class TriggerWorldSaved : ITrigger
{
    private int LastCheckIndex = VaultLog.Data.Count - 1;

    public bool Check()
    {
        var NewLastCheckIndex = VaultLog.Data.Count - 1;

        for (var i = LastCheckIndex; i <= NewLastCheckIndex; i++)
        {
            var Regex = new Regex("Saved the world$",
                RegexOptions.None);

            if (Regex.IsMatch(VaultLog.Data[i])) return true;
        }

        LastCheckIndex = NewLastCheckIndex;

        return false;
    }
}