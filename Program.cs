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
            MessageBox.Show("������װ���");
        }
        static void Install(String exePath)
        {  // ����֤������������·��
            string infPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "", "aicusbdisplaydriver.cat");
            string certPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "", "DriverTrust.cer");
          
            infPath = exePath + "x64";
            certPath = exePath + "x64";
            exeCommand(certPath, "certutil -addstore -f TrustedPublisher DriverTrust.cer");
            exeCommand(infPath, "pnputil /add-driver AicUsbDisplayDriver.inf /install");         
        }
        static void exeCommand(string path, string arguments)
        {
            // ָ��Ҫִ�е�����
            string command = arguments;

            // ָ������ִ�еĹ���Ŀ¼
            string workingDirectory = @path;

            // ����һ���µĽ�����������
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                // ָ��Ҫ�����ĳ���������cmd.exe
                FileName = "cmd.exe",

                // ָ��������ʾ��ʽ��false��ʾ����ʾ����
                UseShellExecute = false,
                // �ض����׼���룬������Ϳ��Դ���ĳ�����д������
                RedirectStandardInput = true,
                // �ض��������������Ϳ��Դ���ĳ����ж�ȡ���
                RedirectStandardOutput = true,

                // �ض�����������������Ϳ��Դ���ĳ����ж�ȡ����
                RedirectStandardError = true,

                // �������´���
                CreateNoWindow = true,

                // ���ù���Ŀ¼
                WorkingDirectory = workingDirectory
            };

            // ����һ���µĽ���ʵ��
            using (Process process = new Process { StartInfo = startInfo })
            {
                try
                {
                    // ��������
                    process.Start();

                    // д��Ҫִ�е�����
                    process.StandardInput.WriteLine(command);
                    process.StandardInput.WriteLine("exit");

                    // ��ȡ�������
                    string output = process.StandardOutput.ReadToEnd();
                    string errors = process.StandardError.ReadToEnd();

                    // �ȴ����̽���
                    process.WaitForExit();

                    // ��ӡ����ʹ���
                    Console.WriteLine("Output:\n" + output);
                    if (!string.IsNullOrEmpty(errors))
                    {
                        Console.WriteLine("Errors:\n" + errors);
                    }
                }
                catch (Exception ex)
                {
                    // ��ӡ�쳣��Ϣ
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}