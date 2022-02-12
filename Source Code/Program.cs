using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinActivation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Thread.Sleep(4000);
            Console.WriteLine("Activating Windows 10 PRO version");
            Thread.Sleep(5000);
            ProcessStartInfo win1 = new ProcessStartInfo();
            win1.FileName = "cmd.exe";
            win1.Arguments = "/c slmgr /ipk VK7JG-NPHTM-C97JM-9MPGT-3V66T"; //you can change any key, but it will no longer be a pro version, but some other version
            win1.Verb = "runas";
            win1.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(win1);
            Thread.Sleep(5000);
            ProcessStartInfo win2 = new ProcessStartInfo();
            win2.FileName = "cmd.exe";
            win2.Arguments = "/c slmgr /skms kms8.msguides.com";
            win2.WindowStyle = ProcessWindowStyle.Hidden;
            win2.Verb = "runas";
            Process.Start(win2);
            Thread.Sleep(5000);
            ProcessStartInfo wiingb = new ProcessStartInfo();
            wiingb.FileName = "cmd.exe";
            wiingb.Arguments = "/c slmgr /ato";
            wiingb.WindowStyle = ProcessWindowStyle.Hidden;
            wiingb.Verb = "runas";
            Process.Start(wiingb);
            Thread.Sleep(15000);
            foreach(var slmgr in Process.GetProcessesByName("slmgr.exe"))
            {
                slmgr.Kill();
            }
            Console.WriteLine("Activating is Complete");
            Thread.Sleep(400);
            Console.Beep();
            Thread.Sleep(6000);
            Environment.Exit(0);
        }
    }
}
