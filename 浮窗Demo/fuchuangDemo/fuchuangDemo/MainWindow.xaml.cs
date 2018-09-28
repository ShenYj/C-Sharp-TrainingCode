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


namespace fuchuangDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private FloatWindow MyFloatWindow;
        public MainWindow()
        {
            InitializeComponent();
            this.ShowInTaskbar = true;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (MyFloatWindow == null) MyFloatWindow = new FloatWindow(this);
            MyFloatWindow.Left = SystemParameters.WorkArea.Width - 80;
            MyFloatWindow.Top = SystemParameters.WorkArea.Height- 80;
            MyFloatWindow.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MyFloatWindow != null) MyFloatWindow.Close();
        }
    }
}
