using System;
using System.Diagnostics;

namespace ServerGUI.Utilities.Counter
{
    public class CounterCpu
    {
        private PerformanceCounter Counter;
        private int Cores = Environment.ProcessorCount;
        private bool CounterTotal = true;

        public CounterCpu()
        {
            Counter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        }

        public CounterCpu(int Id)
        {
            Counter = new PerformanceCounter("Process", "% Processor Time", Process.GetProcessById(Id).ProcessName);
            CounterTotal = false;
        }

        public Int32 GetUsage()
        {
            if (CounterTotal)
            {
                return Convert.ToInt32(Counter.NextValue());
            }

            return Convert.ToInt32(Counter.NextValue() / Cores);
        }
    }
}