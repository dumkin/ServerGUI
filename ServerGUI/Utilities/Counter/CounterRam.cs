using System.Diagnostics;
using Microsoft.VisualBasic.Devices;

namespace ServerGUI.Utilities.Counter;

public class CounterRam
{
    public static int Total = Convert.ToInt32(new Computer().Info.TotalPhysicalMemory / 1024 / 1024);

    private readonly PerformanceCounter Counter;

    // private readonly PerformanceCounter CounterAvailable = new("Memory", "Available MBytes");
    private readonly bool CounterTotal = true;

    public CounterRam()
    {
    }

    public CounterRam(int Id)
    {
        Counter = new PerformanceCounter("Process V2", "Working Set",
            Process.GetProcessById(Id).ProcessName + ":" + Id);
        // Counter = new PerformanceCounter("Process", "Working Set", Process.GetProcessById(Id).ProcessName);
        CounterTotal = false;
    }

    public int GetUsage()
    {
        if (CounterTotal) return Total - GetAvailable();

        return Convert.ToInt32(Counter.NextValue() / 1024 / 1024);
    }

    public int GetAvailable()
    {
        return -1;
        // return Convert.ToInt32(CounterAvailable.NextValue());
    }

    public int GetUsagePercent()
    {
        if (CounterTotal)
            return (Total - GetAvailable()) * 100 / Total;
        return GetUsage() * 100 / Total;
    }

    public int GetAvailablePercent()
    {
        return GetAvailable() / Total;
    }
}