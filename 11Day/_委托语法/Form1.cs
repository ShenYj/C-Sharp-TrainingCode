using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _委托语法
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //  委托： 将方法作为参数， 作为参数的方法就是一个委托类型
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 三个需求
            // 1. 将一个字符串数组中的每个元素都转换成大写
            // 2. 将一个字符串数组中的每个元素都转换成小写
            // 3. 将一个字符串数组中的每个元素两边都加上 双引号

            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Demo1(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Demo2(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Demo3(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }


        /// <summary>
        /// 转大写
        /// </summary>
        /// <param name="name"></param>
        private static void Demo1(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToUpper();
            }
        }
        /// <summary>
        /// 转小写
        /// </summary>
        /// <param name="name"></param>
        private static void Demo2(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToLower();
            }
        }

        /// <summary>
        /// 两边加上“”
        /// </summary>
        /// <param name="name"></param>
        private static void Demo3(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = "\"" + names[i] + "\"";
            }
        }
    }
}
