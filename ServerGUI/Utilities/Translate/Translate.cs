using ServerGUI.Utilities.Config;
using ServerGUI.Utilities.Translate.Vault;

namespace ServerGUI.Utilities.Translate;

public class Translate
{
    public static VaultMessage Message = new();
    public ConfigSystem Config = new();

    public void Load(string locale)
    {
        Message = Config.Load<VaultMessage>(Directory.GetCurrentDirectory() + "\\locale\\" + locale + ".lang");
    }
}