using System;
using System.Diagnostics;
using System.IO;

namespace RegOPCDAAuto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sysfolder = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
            string dllname = "OPCDAAuto.dll";

            if (!File.Exists(sysfolder + "\\" + dllname))
                Process.Start(sysfolder + "\\cmd.exe", "/C copy " + dllname + " " + sysfolder + " && regsvr32 " + dllname);
            else
                Process.Start(sysfolder + "\\cmd.exe", "/C regsvr32 " + dllname);
        }
    }
}
