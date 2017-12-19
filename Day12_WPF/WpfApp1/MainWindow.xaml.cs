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

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public object MessageBoxButtons { get; private set; }
        public object MessageBoxIcon { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string message = "Are you sure that you would like to close the form ?";
            string caption = "Form Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButton.YesNo, MessageBoxImage.Question);

            Console.WriteLine(result);
            // If the no button was pressed ...
            if (result == MessageBoxResult.No)
            {
                // cancel the closure of the form.

            }
            else if ( result == MessageBoxResult.Yes)
            {

            }
        }

        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn.Content = "光标位于按钮区域内";
        }

        private void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            Btn.Content = "光标移除了按钮区内";
        }
    }
}
