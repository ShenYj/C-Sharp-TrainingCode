using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace _多播委托
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Action<string> md = Method1;
            md += Method2;
            md += Method3;
            md += Method4;

            md("多播委托");
            // 调用md后， 以下4个方法都会被调用
            // 执行顺序不一定会保持这个添加的顺序
            md -= Method2; 
        }

        private void Method1(string str)
        {
            Console.WriteLine("Method1: " + str);
        }
        private void Method2(string str)
        {
            Console.WriteLine("Method2: " + str);
        }
        private void Method3(string str)
        {
            Console.WriteLine("Method3: " + str);
        }
        private void Method4(string str)
        {
            Console.WriteLine("Method4: " + str);
        }
    }
}
