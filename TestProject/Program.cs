using System;
using System.Threading;
using System.Windows.Forms;

namespace TestProject
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var mutex = new Mutex(true, "TestProject", out bool Success))
            {
                if (!Success)
                {
                    MessageBox.Show("TestProject 프로그램이 실행 중 입니다.", "중복실행", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                LoginForm loginForm = new LoginForm();
                DialogResult dialogResult = loginForm.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    Application.Run(new MainForm());
                }
            }
        }
    }
}
