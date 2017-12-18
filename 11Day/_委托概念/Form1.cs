using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _委托概念
{
    // 声明一个委托，指向一个函数
    // 委托所指向的函数，必须和委托具有相同的 签名(返回值和参数)
    public delegate void DelegateSayHello(string name);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 创建一个委托对象
            // 方式1
            DelegateSayHello del1 = new DelegateSayHello(SayHiChinese);
            del1("张三");

            // 方式2
            DelegateSayHello del2 = SayHiEnglish;
            del2("Micheal Jhon");

            // 方式3
            SayHello("老王", SayHiChinese);

        }

        public static void SayHello(string name, DelegateSayHello delgateSayhello)
        {
            delgateSayhello(name);
        }

        public static void SayHiChinese(string name)
        {
            Console.WriteLine("吃了么?" + name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to meet you" + name);
        }
    }
}
