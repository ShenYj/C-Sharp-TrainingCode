using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _14Day复习
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            
            ThreadDemo();
            
            //ExcutePro();
            //ProcessDemo();
        }

        #region 线程
        static void ThreadDemo()
        {
            // Control取消线程检查只适用于Winform开发
            Thread thread = new Thread(ThreadMethod);
            thread.IsBackground = true;
            thread.Start();
        }
        static void ThreadMethod()
        {
            Console.WriteLine("ThreadMethod : {0}",Thread.CurrentThread.Name);
        }
        #endregion


        #region 进程
        /// <summary>
        /// 遍历输出当前的进程
        /// </summary>
        static void ProcessDemo()
        {
            Process[] pros = Process.GetProcesses();
            foreach (var pro in pros) {
                Console.WriteLine(pro.ProcessName);
            }
        }
        /// <summary>
        /// 打开指定文件
        /// </summary>
        static void ExcutePro()
        {
            Process p = new Process();
            ProcessStartInfo pStartInfo = new ProcessStartInfo(@"C:\Users\Ryan Shen\Desktop\temp.txt");
            p.StartInfo = pStartInfo;
            p.Start();
        }
        #endregion
    }


}
