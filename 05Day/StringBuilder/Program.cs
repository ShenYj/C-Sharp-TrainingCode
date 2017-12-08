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
