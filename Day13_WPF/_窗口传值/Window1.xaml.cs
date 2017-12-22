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
using System.Windows.Shapes;

namespace _窗口传值
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {

        public string ReveivedMessage { get; set; }
        public string SendMessage { get; set; }
        public delegate void DHandlerBlock(string content);
        public DHandlerBlock Block;

        public Window1()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            lb1.Content = ReveivedMessage;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            SendMessage = tb1.Text;
        }

        private void BTNOK_Click(object sender, RoutedEventArgs e)
        {
            Block(tb1.Text);
            Close();
        }

        private void BTNCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
