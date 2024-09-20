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
            //Assembly assembly = Assembly.GetExecutingAssembly();
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            Install(exePath);
            MessageBox.Show("驱动安装完成");
        }
        static void Install(String exePath)
        {  // 设置证书和驱动程序的路径
            string infPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "", "aicusbdisplaydriver.cat");
            string certPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "", "DriverTrust.cer");
          
            infPath = exePath + "x64";
            certPath = exePath + "x64";
            exeCommand(certPath, "certutil -addstore -f TrustedPublisher DriverTrust.cer");
            exeCommand(infPath, "pnputil /add-driver AicUsbDisplayDriver.inf /install");         
        }
        static void exeCommand(string path, string arguments)
        {
            // 指定要执行的命令
            string command = arguments;

            // 指定命令执行的工作目录
            string workingDirectory = @path;

            // 创建一个新的进程启动配置
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                // 指定要启动的程序，这里是cmd.exe
                FileName = "cmd.exe",

                // 指定窗口显示方式，false表示不显示窗口
                UseShellExecute = false,
                // 重定向标准输入，这样你就可以从你的程序中写入输入
                RedirectStandardInput = true,
                // 重定向输出，这样你就可以从你的程序中读取输出
                RedirectStandardOutput = true,

                // 重定向错误输出，这样你就可以从你的程序中读取错误
                RedirectStandardError = true,

                // 不创建新窗口
                CreateNoWindow = true,

                // 设置工作目录
                WorkingDirectory = workingDirectory
            };

            // 创建一个新的进程实例
            using (Process process = new Process { StartInfo = startInfo })
            {
                try
                {
                    // 启动进程
                    process.Start();

                    // 写入要执行的命令
                    process.StandardInput.WriteLine(command);
                    process.StandardInput.WriteLine("exit");

                    // 读取命令输出
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();

                    // 等待进程结束
                    process.WaitForExit();

                    // 打印输出和错误
                    Console.WriteLine("Output:\n" + output);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        Console.WriteLine("Errors:\n" + errors);
                    }
                }
                catch (Exception ex)
                {
                    // 打印异常信息
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}