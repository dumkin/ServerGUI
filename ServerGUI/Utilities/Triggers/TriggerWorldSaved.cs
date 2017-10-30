using ServerGUI.Server.Vault;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ServerGUI.Utilities.Triggers
{
    public class TriggerWorldSaved : ITrigger
    {
        int LastCheckIndex = VaultLog.Data.Count - 1;

        public bool Check()
        {
            int NewLastCheckIndex = VaultLog.Data.Count - 1;

            for (int i = LastCheckIndex; i <= NewLastCheckIndex; i++)
            {
                Regex Regex = new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[Server thread/INFO\\]: Saved the world$", RegexOptions.None);

                if (Regex.IsMatch(VaultLog.Data[i]))
                {
                    return true;
                }
            }

            LastCheckIndex = NewLastCheckIndex;

            return false;
        }
    }
}
