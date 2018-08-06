using ServerGUI.Server.Vault;
using System.Text.RegularExpressions;

namespace ServerGUI.Utilities.Triggers
{
    public class TriggerWorldSaved : ITrigger
    {
        private int LastCheckIndex = VaultLog.Data.Count - 1;

        public bool Check()
        {
            int NewLastCheckIndex = VaultLog.Data.Count - 1;

            for (int i = LastCheckIndex; i <= NewLastCheckIndex; i++)
            {
                Regex Regex = new Regex("^\\[[0-9]{2}:[0-9]{2}:[0-9]{2}\\] \\[Server thread/INFO\\]: Saved the game", RegexOptions.None);

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