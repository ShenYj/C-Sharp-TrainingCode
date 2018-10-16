using System;
using System.Collections;
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

namespace ListBox练习
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

        private void MyListBox_Loaded(object sender, RoutedEventArgs e)
        {

            //Hashtable ht1 = new Hashtable();
            //ht1.Add("account", "CB2342432432");
            //ht1.Add("cacheDate", "2017/08/18-2018/03/13");
            //ht1.Add("cacheDuration", "10天7时");
            //ht1.Add("phneNumber", "13888888888");
            //ht1.Add("gender", "女");
            //ht1.Add("MAC", "10:20:30:AC:ED");
            //ht1.Add("account", "CB2342432432");
            //ht1.Add("name", "张三");
            //ht1.Add("upload", "未上传");
            //ht1.Add("bind", "绑定用户");
            //ht1.Add("apply", "申请");

            DeviceListItem item = new DeviceListItem();
            item.DAccount.Content = "CB2342432432";
            item.DCacheDate.Content = "2017/08/18-2018/03/13";
            item.DCacheDuration.Content = "10天7时";
            item.DName.Content = "张三";
            item.DPhoneNumber.Content = "13888888888";
            item.DGender.Content = "女";
            item.DIsBinding.IsEnabled = false;
            MyListBox.Items.Add(item);
        }
    }
}
