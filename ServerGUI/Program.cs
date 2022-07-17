namespace ServerGUI;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetHighDpiMode(HighDpiMode.DpiUnawareGdiScaled);
        ApplicationConfiguration.Initialize();
        Application.Run(new Form_Main());
    }
}