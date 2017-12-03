using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DayCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo3();
        }

        public static void Demo3()
        {
            // 异常捕获
            Console.WriteLine("请输入一个数字");
            int number = 0;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("获取的数字内容格式错误！");
            }

            Console.WriteLine("输入的数字是{0}",number);
            Console.ReadKey();

        }

        public static void Demo2()
        {
            // if 结构
            Console.WriteLine("请输入你跪键盘的时间");
            int timer = Convert.ToInt32(Console.ReadLine());

            if ( timer > 60 )
            {
                // 大于60分钟
                Console.WriteLine("大于60分钟");
            }  else
            {
                Console.WriteLine("小于等于60分钟");
            }
            Console.ReadKey();

        }
        public static void Demo1()
        {
            // 类型转换 convert
            //string s = "123";
            //double doubleS = Convert.ToDouble(s);
            //Console.WriteLine(doubleS);
            //Console.ReadKey();

            // 让用户输入姓名 语文 数学 英语 三门课的成绩
            // 然后给用户提示：XX 你的总成绩为XX分，平均成绩为XX分
            Console.WriteLine("请输入你的姓名、语文、数据、英语三门功课的成绩\n");
            Console.WriteLine("您的姓名是：\n");
            string name = Console.ReadLine();
            Console.WriteLine("您的语文成绩：\n");
            string yuwen = Console.ReadLine();
            Console.WriteLine("您的数学成绩：\n");
            string math = Console.ReadLine();
            Console.WriteLine("您的英语成绩：\n");
            string english = Console.ReadLine();

            double yuwenR = Convert.ToDouble(yuwen);
            double mathR = Convert.ToDouble(math);
            double englishR = Convert.ToDouble(english);

            double total = yuwenR + mathR + englishR;
            double average = (int)total * 1.0 / 3; // double average = (int)total / 3; 此时average仍然是int类型

            Console.WriteLine("{0}你的总成绩为{1}，平均成绩是{2:0.00}", name, total, average);
            Console.ReadKey();
        }
    }
}
