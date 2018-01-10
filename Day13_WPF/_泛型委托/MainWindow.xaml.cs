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

namespace _泛型委托
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // 1.系统内置的无参无返回值委托
            Action md = delegate () {
                Console.WriteLine("aaa");
            };
            md();

            Action md1 = Method1;
            md1();

            // 2.有参数无返回值泛型委托
            Action<string> md2 = Method2;

            Action<int, int> md3 = (a, b) => { Console.WriteLine(a + b); };

            // Action都是没有返回值的


            // 3.有参有返回值的泛型委托
            Func<int, int, int> md4 = Method3;
            int value = md4(10, 20);
            Console.WriteLine(value);


        }

        private int Method3(int a, int b)
        {
            return a + b;
        }

        private void Method2(string abc)
        {
            Console.WriteLine(abc);
        }

        private void Method1()
        {
            Console.WriteLine("asdfasdf");
        }


        // 定义泛型委托
        public delegate void MyDelegate<T>(T args);
    }
}
