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

namespace _事件
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            // 模拟事件

            MusicPlayer mp = new MusicPlayer();

            mp.AfterStartedPlay = () => { Console.WriteLine("开始播放后增加的额外操作"); };
            mp.BeforeMusicStop = () => { Console.WriteLine("停止播放前额外执行的操作"); };

            mp.PlayMusic();
            mp.StopPlayMusic();
        }

        
    }


    public class MusicPlayer
    {

        public Action AfterStartedPlay; // 在开始播放后执行额外操作
        public Action BeforeMusicStop;  // 在停止播放前执行额外操作

        /// 用委托的方式，外界可以任意访问，如果改成private，那么外界无法赋值，失去意义，通过=符号还会将之前注册的方法覆盖掉
        /// 通过事件+= -=的方式可以避免把之前注册的方法覆盖，同时，即便事件使用了public修饰，但是在外部，事件不能直接调用，只能在内部调用 （系统内部将这个委托转成一个私有委托和两个共有方法）

        /// <summary>
        /// 播放音乐
        /// </summary>
        public void PlayMusic()
        {
            if (AfterStartedPlay != null)
            {
                Play();
            }
            
            AfterStartedPlay();
        }
        /// <summary>
        /// 停止播放
        /// </summary>
        public void StopPlayMusic()
        {
            if (BeforeMusicStop != null)
            {
                BeforeMusicStop();
            }
            Console.WriteLine("结束播放");
        }

        private void Play()
        {
            Console.WriteLine("开始播放");
        }

    }
}
