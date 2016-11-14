using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ls_comand
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = "cmd.exe";
            psi.Arguments = "/c " + "dir";
            psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = false;

            Process proc = new Process();
            proc.StartInfo = psi;
            proc.Start();
            Console.WriteLine(proc.StandardOutput.ReadToEnd());
            
            /*prueba desde github */
        }
    }
}
