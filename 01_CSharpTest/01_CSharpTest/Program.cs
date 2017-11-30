using System;

namespace _CSharpTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            test3();//转译符

        }

        public static void test3 ()
        {
            // 转译符
            Console.WriteLine("\"今天天气好晴朗 \t 处处好风光\"");
            Console.WriteLine("------------------------");
            Console.WriteLine("今天天气好晴朗 \n 处处好风光");
            Console.WriteLine("------------------------");

            // /b放在字符串的两边没有效果
            Console.WriteLine("\b今天天气好晴朗\b处处好风光\b");

            string text = "今天天气后晴朗/r/n处处好风光";
            // /n 在Mac下可以, windows下需要使用/r/n
            System.IO.File.WriteAllText(@"/Users/shenyj/Desktop/123.txt",text);
        }


        public static void test ()
        {
            Console.WriteLine("Hello C Sharp !");

            int a = 10;
            int b = 23;

            int result = calculate(a, b);
            int[] array = { 2, 256, 6543, 12 };
            result = sum(array);
            Console.WriteLine(result);


            string name = "小桌子";
            int age = 18;

            Console.WriteLine("姓名: " + name + ";\n" + "年龄: " + age);
        }

        /// <summary>
        /// Test1 this instance.
        /// </summary>
        public static void test1 ()
        {
            Console.WriteLine("请输入您的姓名: ");
            string name = Console.ReadLine();
            Console.WriteLine("请输入您的年龄:");
            string age = Console.ReadLine();
            Console.WriteLine("请输入您的性别:");
            string sex = Console.ReadLine();
            // C# 的占位符使用{},在{ }内填写所占的位的序号，C#规定从0开始
            Console.WriteLine("确认您的信息:\n 姓名:{0}\n 年龄:{1} \n 性别:{2}", name, age, sex);   
        }

        /// <summary>
        /// Calculate the specified a and b.
        /// </summary>
        /// <returns>The calculate.</returns>
        /// <param name="a">The alpha component.</param>
        /// <param name="b">The blue component.</param>
        public static int calculate(int a,int b)
        {
            return a + b;
        }

        /// <summary>
        /// Sum the specified arr.
        /// </summary>
        /// <returns>The sum.</returns>
        /// <param name="arr">Arr.</param>
        public static int sum(int[] arr)
        {
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                result += arr[i];
            }
            return result;
        }




    }
}
