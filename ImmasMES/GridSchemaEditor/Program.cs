using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridSchemaEditor
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main(params string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // grd 파일을 실행했을 때
            if (args.Length == 1)
            {

            }
            else
            {
                // exe파일 바로 실행
            }
            
            Application.Run(new MainForm());
        }
    }
}
