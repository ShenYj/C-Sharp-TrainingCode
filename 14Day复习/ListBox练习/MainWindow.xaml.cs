using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //public MainWindowViewModel MainWindowsVM { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }

    public class MainWindowViewModel : ViewModelBase, IDisposable
    {
        public MainWindowViewModel()
        {
            LoadedCommand = new RelayCommand(() => LoadData());
            UnloadedCommand = new RelayCommand(() => UnLoadData());

            CurrentDeviceList = new ObservableCollection<DeviceListItem>();
            
        }

        public virtual void LoadData()
        {
            DeviceListItem item = new DeviceListItem()
            {
                DataContext = new DeviceListItemViewModel()
                {
                    DeviceItemModel = new ItemModel()
                    {
                        DAccount = "CB23424323111",
                        DCacheDate = "2017/08/18-2018/03/13",
                        DCacheDuration = "1天7时",
                        DName = "张三",
                        DPhoneNumber = "13888777788",
                        DGender = "男",
                        DIsBinding = false
                    }
                }
            };
            CurrentDeviceList.Add(item);
            
            DeviceListItem item1 = new DeviceListItem()
            {
                DataContext = new DeviceListItemViewModel()
                {
                    DeviceItemModel = new ItemModel()
                    {
                        DAccount = "CB2342432234",
                        DCacheDate = "2017/08/20-2018/03/13",
                        DCacheDuration = "10天7时",
                        DName = "王五",
                        DPhoneNumber = "13888888888",
                        DGender = "女",
                        DIsBinding = false
                    }
                }
            };
            CurrentDeviceList.Add(item1);

            Console.WriteLine("列表元素个数：" + CurrentDeviceList.Count);


            Console.WriteLine("LoadData 方法");
            RaisePropertyChanged("CurrentDeviceList");
        }

        public virtual void UnLoadData()
        {
            Dispose();
        }


        public void Dispose()
        {
            //卸载当前对象注册的所有MVVMLight消息
            Messenger.Default.Unregister(this);
        }


        #region 事件

        /// <summary>
        /// 加载数据
        /// </summary>
        public RelayCommand LoadedCommand { get; set; }

        /// <summary>
        /// 加载数据
        /// </summary>
        public RelayCommand UnloadedCommand { get; set; }

        #endregion

        public ObservableCollection<DeviceListItem> CurrentDeviceList { get; set; }
    }


    public class ItemModel : ViewModelBase
    {
        public string DAccount { get; set; }
        public string DCacheDate { get; set; }
        public string DCacheDuration { get; set; }
        public string DName { get; set; }
        public string DPhoneNumber { get; set; }
        public string DGender { get; set; }
        public bool DIsBinding { get; set; }
    }

}
