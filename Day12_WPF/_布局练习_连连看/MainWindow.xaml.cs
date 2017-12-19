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

namespace _布局练习_连连看
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 动态的像视图中添加控件
            //Button btn = new Button();
            //btn.Content = "按钮";
            //btn.Width = 40;
            //btn.Height = 20;
            //sp1.Children.Add(btn);
            
            /// 动态的创建10行10列 Grid
            for (int i = 0; i < 10; i++)
            {
                ColumnDefinition colDefinition = new ColumnDefinition();
                ContainerGrid.ColumnDefinitions.Add(colDefinition);
                RowDefinition rowDefinition = new RowDefinition();
                ContainerGrid.RowDefinitions.Add(rowDefinition);
            }

            Random random = new Random();
            int flag = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    //Button btn = new Button();
                    //btn.Content = "R" + i + "C" + j;
                    //Grid.SetRow(btn, i);                 // 设置row
                    //Grid.SetColumn(btn, j);              // 设置col
                    //ContainerGrid.Children.Add(btn);     // 添加到Grid中
                    Image img = new Image();
                    flag = random.Next(1, 3);
                    img.Source = new BitmapImage(new Uri(flag +".jpg", UriKind.Relative));
                    Grid.SetRow(img, i);
                    Grid.SetColumn(img, j);
                    ContainerGrid.Children.Add(img);
                }
            }
        }
    }
}
