using System.Diagnostics;

namespace ServerGUI.Utilities.Counter;

public class CounterCpu
{
    private readonly int Cores = Environment.ProcessorCount;
    private readonly PerformanceCounter Counter;
    private readonly bool CounterTotal = true;

    public CounterCpu()
    {
        var k = PerformanceCounterCategory.GetCategories();
        Counter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        // Counter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
    }

    public CounterCpu(int Id)
    {
        var categories = PerformanceCounterCategory.GetCategories().OrderBy(c => c.CategoryName).ToList();
        var category = categories.FirstOrDefault(C => C.CategoryName == "Process V2");
        // var counters = category.GetCounters();
        // Counter = new PerformanceCounter("Process", "% Processor Time", Process.GetProcessById(Id).ProcessName);
        Counter = new PerformanceCounter("Process V2", "% Processor Time", Process.GetProcessById(Id).ProcessName + ":" + Id);
        CounterTotal = false;
    }

    public int GetUsage()
    {
        if (CounterTotal) return Convert.ToInt32(Counter.NextValue());

        return Convert.ToInt32(Counter.NextValue() / Cores);
    }
}