using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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

namespace ListView练习
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            MyListView.Items.Add(new { ID = "001", Name = "李刚", SEX = "男"});
            MyListView.Items.Add(new { ID = "002", Name = "李刚他爸", SEX = "男" });
            MyListView.Items.Add(new { ID = "003", Name = "李刚他妈", SEX = "女" });
            
            CheckUSBDeviceTool.SharedUSBDeviceTool().CheckUSBDeviceTimer();
        }

        
    }
}
