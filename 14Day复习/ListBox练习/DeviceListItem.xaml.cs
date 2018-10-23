using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
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

namespace ListBox练习
{
    /// <summary>
    /// DeviceListItem.xaml 的交互逻辑
    /// </summary>
    public partial class DeviceListItem : UserControl
    {

        public DeviceListItemViewModel DeviceListItemVM { get; set; }

        public DeviceListItem()
        {
            InitializeComponent();
        }
    }

    public class DeviceListItemViewModel : ViewModelBase, IDisposable
    {

        public ItemModel DeviceItemModel { get; set; }

        public DeviceListItemViewModel()
        {
            LoadedCommand = new RelayCommand(() => LoadData());
            UnloadedCommand = new RelayCommand(() => UnLoadData());
        }

        public virtual void LoadData()
        {
            Console.WriteLine("DeviceListItem的 LoadData方法");
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
    }

}