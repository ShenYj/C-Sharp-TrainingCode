using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace ListBox自定义模板练习
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        ObservableCollection<User> Users = new ObservableCollection<User>();

        void Init()
        {
            Users.Add(new User() { UserName = "Cs", UserNum = "+86123456" });
            Users.Add(new User() { UserName = "Jxy", UserNum = "+86123456" });
            Users.Add(new User() { UserName = "Lmf", UserNum = "+86123456" });
            Users.Add(new User() { UserName = "asd", UserNum = "+86123456" });
            Users.Add(new User() { UserName = "张三", UserNum = "+86123456" });
            this.listBox1.ItemsSource = Users;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string s = "";
            foreach (var user in Users)
            {
                if (user.UserSelect)
                {
                    s += user.ToString();
                }
            }
            MessageBox.Show(s);
        }

    }

    public class User : INotifyPropertyChanged
    {
        bool _UserSelect;

        public bool UserSelect
        {
            get { return _UserSelect; }
            set { _UserSelect = value; FirePropertyChanged("UserSelect"); }
        }

        string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; FirePropertyChanged("UserName"); }
        }

        string _UserNum;

        public string UserNum
        {
            get { return _UserNum; }
            set { _UserNum = value; FirePropertyChanged("UserNum"); }
        }


        string _UserIco = AppDomain.CurrentDomain.BaseDirectory + "imgs\\user.png";

        public string UserIco
        {
            get { return _UserIco; }
            set { _UserIco = value; FirePropertyChanged("UserIco"); }
        }

        public override string ToString()
        {
            return UserName + " : " + UserNum + "\n";
        }

        public virtual event PropertyChangedEventHandler PropertyChanged;

        public virtual void FirePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
