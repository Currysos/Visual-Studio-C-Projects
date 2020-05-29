using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Writing_Python
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Directory.Exists("/Logs")) ;
            Directory.CreateDirectory("/Logs");

            FileStream ostrm;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                ostrm = new FileStream("./Logs/Test.py", FileMode.Create, FileAccess.Write);
                writer = new StreamWriter(ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot open Test.py for writing");
                Console.WriteLine(e.Message);
                return;
            }
            //open
            Console.SetOut(writer);
            //Code

            Console.WriteLine("print('Helo World')");

            //Close
            Console.SetOut(oldOut);
            writer.Close();
            ostrm.Close();

            string arguments = "notepad.exe";
            string ExeName = "./Logs/Test.py";

            // Prepare the process to run
            ProcessStartInfo start = new ProcessStartInfo();
            // Enter in the command line arguments, everything you would enter after the executable name itself
            start.Arguments = arguments;
            // Enter the executable to run, including the complete path
            start.FileName = ExeName;
            // Do you want to show a console window?
            start.WindowStyle = ProcessWindowStyle.Hidden;
            start.CreateNoWindow = true;
            int exitCode;


            // Run the external process & wait for it to finish
            using (Process proc = Process.Start(start))
            {
                proc.WaitForExit();

                // Retrieve the app's exit code
                exitCode = proc.ExitCode;
            }

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
