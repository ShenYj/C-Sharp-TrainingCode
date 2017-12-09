using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace StringBuilder练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder 练习
            //Test1();  18s左右， 原因：频繁的开辟内存空间
            //Test2();  // 不到1s

            // 转大写、转小写
            string c = "c";
            string b = "B";

            Console.WriteLine(c.ToUpper());// 转大写
            Console.WriteLine(b.ToLower());// 转小写

            string str1 = "c#";
            string str2 = "C#";

            // 忽略大小写
            if (str1.Equals(str2, StringComparison.OrdinalIgnoreCase)) Console.WriteLine("相同");

            // 分割字符串
            string s = "a b dfd _ + = ,, fasdfasd";
            Console.WriteLine(s);
            // 将不需要的字符换成空
            char[] chs = { ' ', '_', '=', '+', ',' };
            // 加上后面枚举参数， 分割成多个字符串
            string[] s1 = s.Split(chs,StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(s1[i]);
            }

            // 字符串 去空格
            string string3 = "       sdas       ";
            string strStart = string3.TrimStart();
            string strEnd = string3.TrimEnd();
            string str3 = string3.Trim();
            Console.WriteLine(strStart);
            Console.WriteLine(strEnd);
            Console.WriteLine(str3);


            // 判断空
            string string4 = "";
            string string5 = null;
            bool flag1 = string.IsNullOrEmpty(string4);
            bool flag2 = string.IsNullOrEmpty(string5);
            Console.WriteLine(flag1);
            Console.WriteLine(flag2);


            // 截取
            string string6 = "今天天气好晴朗， 处处好风光";
            string substring2 = string6.Substring(2);
            Console.WriteLine(substring2);
            // 获取索引
            int index = string6.IndexOf('天');
            Console.WriteLine(index);
            int indexLast = string6.LastIndexOf('天');
            Console.WriteLine(indexLast);

            bool flag3 = string6.StartsWith("今天");
            bool flag4 = string6.EndsWith("风光");
            Console.WriteLine(flag3);
            Console.WriteLine(flag4.ToString());

            // 插入
            string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            string newString = string.Join("|", names);
            Console.WriteLine(newString);


            // 包含
            string string8 = "我是小明";
            bool flag5 = string8.Contains("小");
            Console.WriteLine(flag5);

            // 替换
            string string9 = "我是小明";
            //string newStr = string9.Replace("小明", "小杜");
            string newStr = string9.Replace("小垃圾", "小杜");
            Console.WriteLine(newStr);


            Console.ReadKey();
            
        }

        public static void Test2()
        {
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 100000; i++)
            {
                sb.Append(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            //Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }

        public static void Test1()
        {
            string str = null;
            // 创建了一个计时器， 用来记录程序运行的时间
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for(int i = 0; i < 100000; i++)
            {
                str += i;
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();

        }
    }
}
