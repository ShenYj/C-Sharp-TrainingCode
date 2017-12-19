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

namespace _CheckBox和可空类型
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? value = DatePicker1.SelectedDate;

            if (value == null)
            {
                //MessageBox.Show("请选择日期");
                DatePicker1.SelectedDate = DateTime.Today;
            }
            else
            {
                MessageBox.Show("选择的日期是: " + value.Value.Year.ToString() + "-" + value.Value.Month.ToString() + "-" + value.Value.Day.ToString());
            }
        }
    }
}
