using System;
using System.Diagnostics;

namespace UnRegOPCDAAuto
{
    internal class Program
    {
        static string sysfolder = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
        static string dllname = "OPCDAAuto.dll";

        static void Main(string[] args)
        {
            Process proc = Process.Start(sysfolder + "\\cmd.exe", "/C regsvr32 /U " + dllname + " && del " + sysfolder + "\\" + dllname);
        }
    }
}
