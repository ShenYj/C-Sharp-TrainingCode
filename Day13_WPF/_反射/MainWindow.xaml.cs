using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace _反射
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            MyClass1 cls1 = new MyClass1();
            MyClass2 cls2 = new MyClass2();

            Type type1 = cls1.GetType();
            Type type2 = typeof(MyClass2);// 同构typeof，无需获取类对象就可以获取到类型

            
            Console.WriteLine(type1.ToString());
            Console.WriteLine(type2);

            // 查看非私有字段（成员变量）
            FieldInfo[] fields = type1.GetFields();
            foreach (var item in fields)
            {
                FieldInfo fieldi = (FieldInfo)item;
                Console.WriteLine(fieldi.Name);
            }

            // 查看非私有属性
            PropertyInfo[] properties = type1.GetProperties();
            foreach (var item in properties)
            {
                PropertyInfo proper = (PropertyInfo)item;
                Console.WriteLine(proper.Name);
            }
        }

        

    }


    public class MyClass1
    {

        private int _age;
        private int _sex;
        private int _year;
        private int _month;
        public int _day;

        public int Age
        {
            set
            {
                _age = value;
            }
            get
            {
                return _age;
            }
        }
        public int Name { set; get; }

        public void Des()
        {
            Console.WriteLine("a method ");
        }
    }
    public class MyClass2
    {

    }
}
