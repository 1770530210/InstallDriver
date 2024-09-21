using System.Diagnostics;
using System.Reflection;

namespace InstallDriver
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
        }

        public static void Install(String exePath)
        { 
            string infPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "", "AicUsbDisplayDriver.inf");//"aicusbdisplaydriver.cat"
            string certPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "", "DriverTrust.cer");
          
            infPath = exePath + "x64";
            certPath = exePath + "x64";
            exeCommand(certPath, "certutil -addstore -f TrustedPublisher DriverTrust.cer");
            exeCommand(infPath, "pnputil /add-driver AicUsbDisplayDriver.inf /install");         
        }
        static void exeCommand(string path, string arguments)
        {
            string command = arguments;
            string workingDirectory = @path;
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                CreateNoWindow = true,
                WorkingDirectory = workingDirectory
            };
            using (Process process = new Process { StartInfo = startInfo })
            {
                try
                {
                    process.Start();
                    process.StandardInput.WriteLine(command);
                    process.StandardInput.WriteLine("exit");
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();
                    process.WaitForExit();
                    Console.WriteLine("Output:\n" + output);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        Console.WriteLine("Errors:\n" + errors);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}