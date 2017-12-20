using ServerGUI.Utilities.Config;
using ServerGUI.Utilities.Translate.Vault;
using System.IO;

namespace ServerGUI.Utilities.Translate
{
    public class Translate
    {
        public ConfigSystem Config = new ConfigSystem();
        public static VaultMessage Message = new VaultMessage();

        public void Load(string locale)
        {
            Message = Config.Load<VaultMessage>(Directory.GetCurrentDirectory() + "\\locale\\" + locale + ".lang");
        }
    }
}