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

namespace _StackPannel布局
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UserControl1_Loaded(object sender, RoutedEventArgs e)
        {
            cc.WBDemo.Visibility = System.Windows.Visibility.Collapsed;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Content.ToString() == "打开WebBrowser")
            {
                cc.WBDemo.Source = new Uri("http://www.baidu.com/");
                cc.Visibility = System.Windows.Visibility.Visible;
                btn.Content = "关闭WebBrowser";
            }
            else
            {
                cc.Visibility = System.Windows.Visibility.Collapsed;
                btn.Content = "打开WebBrowser";
            }

        }
    }
}
