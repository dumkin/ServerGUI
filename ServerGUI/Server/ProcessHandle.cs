using ServerGUI.Utilities.Counter;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace ServerGUI.Server
{
    public class ProcessHandle
    {
        public ProcessHandle()
        {
            Enabled = false;

            Process.StartInfo.UseShellExecute = false;
            Process.StartInfo.ErrorDialog = false;
            Process.StartInfo.RedirectStandardError = true;
            Process.StartInfo.RedirectStandardInput = true;
            Process.StartInfo.RedirectStandardOutput = true;
            Process.StartInfo.StandardErrorEncoding = Encoding.UTF8;
            Process.StartInfo.StandardOutputEncoding = Encoding.UTF8;
            Process.StartInfo.CreateNoWindow = true;

            Process.EnableRaisingEvents = true;

            Process.OutputDataReceived += new DataReceivedEventHandler(Output);
            Process.Exited += new EventHandler(ExitCallback);
        }

        private Process Process = new Process();
        private StreamWriter OutputStream;

        public CounterRam CounterRam;
        public CounterCpu CounterCpu;

        public delegate void EventStateChanged();
        public delegate void EventCallbackOutput(string text);

        private EventStateChanged CallbackStateChanged;
        private EventCallbackOutput CallbackOutput;

        public string JavaFilename { get; set; }
        public string JavaArguments { get; set; }
        public string CoreFilename { get; set; }
        public string CoreArguments { get; set; }

        public string WorkingDirectory { get; set; }
        public bool Enabled { get; private set; }

        public void Start()
        {
            Process.StartInfo.FileName = JavaFilename;
            Process.StartInfo.Arguments = JavaArguments + " -jar \"" + CoreFilename + "\" " + CoreArguments;
            Process.StartInfo.WorkingDirectory = WorkingDirectory;

            Process.Start();
            Process.BeginOutputReadLine();
            OutputStream = Process.StandardInput;

            CounterRam = new CounterRam(Process.Id);
            CounterCpu = new CounterCpu(Process.Id);

            Enabled = true;
            CallbackStateChanged();
        }

        public void Stop()
        {
            SendCommand("stop");
        }

        public void Kill()
        {
            Process.Kill();
        }

        public void SendCommand(string Command)
        {
            if (Enabled)
            {
                OutputStream.WriteLineAsync(Command);
            }
        }

        private void Output(object sender, DataReceivedEventArgs output)
        {
            CallbackOutput(output.Data);
        }

        public void SetCallbackStateChanged(EventStateChanged NewCallbackStateChanged)
        {
            CallbackStateChanged = new EventStateChanged(NewCallbackStateChanged);
        }

        public void SetCallbackOutput(EventCallbackOutput NewCallbackOutput)
        {
            CallbackOutput = new EventCallbackOutput(NewCallbackOutput);
        }

        public void WaitStopProcess()
        {
            Process.WaitForExit();
        }

        private void ExitCallback(Object sender, EventArgs e)
        {
            Enabled = false;
            CallbackStateChanged();
            Process.CancelOutputRead();
        }
    }
}