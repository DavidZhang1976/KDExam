using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDExam
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //// 启动 
            //SplashScreen sc=new SplashScreen();
            //sc.Show();
            //// 进行自己的操作：加载组件，加载文件等等 
            //// 示例代码为休眠一会 
            //System.Threading.Thread.Sleep(3000);
            //sc.Close();
            Application.Run(new frmMain());

        }
    }
}
