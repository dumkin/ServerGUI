using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;

namespace ServerGUI.Utilities.Counter
{
    public class CounterRam
    {
        private PerformanceCounter Counter;
        private PerformanceCounter CounterAvailable = new PerformanceCounter("Memory", "Available MBytes");
        private bool CounterTotal = true;

        public static Int32 Total = Convert.ToInt32(new Computer().Info.TotalPhysicalMemory / 1024 / 1024);

        public CounterRam()
        {
        }

        public CounterRam(int Id)
        {
            Counter = new PerformanceCounter("Process", "Working Set", Process.GetProcessById(Id).ProcessName);
            CounterTotal = false;
        }

        public Int32 GetUsage()
        {
            if (CounterTotal)
            {
                return Total - GetAvailable();
            }

            return Convert.ToInt32(Counter.NextValue() / 1024 / 1024);
        }

        public Int32 GetAvailable()
        {
            return Convert.ToInt32(CounterAvailable.NextValue());
        }

        public Int32 GetUsagePercent()
        {
            if (CounterTotal)
            {
                return (Total - GetAvailable()) * 100 / Total;
            }
            else
            {
                return GetUsage() * 100 / Total;
            }
        }

        public Int32 GetAvailablePercent()
        {
            return GetAvailable() / Total;
        }
    }
}