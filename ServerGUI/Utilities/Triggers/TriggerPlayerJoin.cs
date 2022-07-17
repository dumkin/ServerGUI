using System.Text.RegularExpressions;
using ServerGUI.Server.Vault;

namespace ServerGUI.Utilities.Triggers;

public class TriggerPlayerJoin : ITrigger
{
    private int LastCheckIndex = VaultLog.Data.Count - 1;

    public bool Check()
    {
        var NewLastCheckIndex = VaultLog.Data.Count - 1;

        for (var i = LastCheckIndex; i <= NewLastCheckIndex; i++)
        {
            var Regex = new Regex(
                "^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[Server thread/INFO\\]: [a-z,A-Z,0-9]{0,16} joined the game$",
                RegexOptions.None);

            if (Regex.IsMatch(VaultLog.Data[i])) return true;
        }

        LastCheckIndex = NewLastCheckIndex;

        return false;
    }
}