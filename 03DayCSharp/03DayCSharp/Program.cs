using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03DayCSharp
{
    // _03DayCSharp命名空间下都可以使用的枚举
    public enum Sexs
    {
        男,
        女
    }
    class Program
    {
        // Program类中定义一个枚举
        public enum Sex
        {
            Female,
            Male
        }
        public struct Person
        {
            public string _name;
            public int _age;
            public Sex _sex;
        }

        static void Main(string[] args)
        {
            Demo8();
            

        }

        public static void Demo8()
        {
            // 结构体
            Person person ;
            person._name = "张安";
            person._age = 18;
            person._sex = Sex.Female;
            Console.WriteLine("我叫{0}，年龄：{1}，性别：{2}",person._name,person._age,person._sex);
            Console.ReadKey();
        }
        
        public static void Demo7()
        {
            Sex sex = Sex.Female;

            // 将一个字符串转换成枚举
            Sexs sex1 = (Sexs)Enum.Parse(typeof(Sexs), "男");
            Console.WriteLine(sex1);
            Console.ReadKey();

            // 枚举转字符串
            string sex2 = sex.ToString();
            Console.WriteLine(sex2);
            Console.ReadKey();
        }


        public static void Demo6()
        {
            // 产生随机数  1 ~ 100 
            Random random = new Random();
            int aRandomNumber = random.Next(0, 101);
            Console.WriteLine(aRandomNumber);
            Console.ReadKey();
        }

        public static void Demo5()
        {
            // 求质数
            // 找出100以内的质数
            for (int i = 2; i <= 100; i++)
            {
                bool flag = false;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }


        public static void Demo4()
        {

            // TryParse() 
            int number = 0;
            bool b = int.TryParse("123a",out number);
            Console.WriteLine(b);
            Console.WriteLine(number);
            Console.ReadKey();

            // parase
            //int number = int.Parse("123");
            //Console.WriteLine("输入的数值是：{0}",number);
            //Console.ReadKey();

            

            //Convert.ToInt32  内部调用了 int.Parse

            //int numberOne = 0;
            //bool flag = true;
            //try
            //{
            //    numberOne = Convert.ToInt32(Console.ReadLine());
            //}
            //catch
            //{
            //    flag = false;
            //    Console.WriteLine("输入的并非是数值类型");
            //}

            //if (flag)
            //{
            //    Console.WriteLine("输入的数值是： {0}",numberOne);
            //}
            //Console.ReadKey();

        }

        public static void Demo3()
        {
            // 异常捕获
            Console.WriteLine("请输入一个数字");
            int number = 0;

            bool flag = true;
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                flag = false;
                Console.WriteLine("获取的数字内容格式错误！");
            }

            if (flag)
            {
                Console.WriteLine("输入的数字是{0}",number);
            }

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
            }
            else
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
