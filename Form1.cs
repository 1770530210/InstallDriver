namespace InstallDriver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 50;
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            Program.Install(exePath); progressBar1.Value = 100;
            MessageBox.Show("驱动安装成功"); Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
