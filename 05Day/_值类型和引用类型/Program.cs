using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //_值类型和引用类型
            //1.值类型和引用类型在内存上存储的地方不一样
            //2.在传递值类型和传递引用累心个到时候，传递的方式不一样。
            //  值类型我们称之为值传递， 引用类型我们称之为引用传递
            //  值类型的值是存储在内存的栈当中， 引用类型的值存储在内存的堆当中

            StringTest2();
        }

        // 字符串的不可变性
        public static void StringTest()
        {
            string str1 = "张三";
            string str2 = "张三";
            // 即时窗口下 &str1 &str2 分别查看两个字符串存储的地址相同
            //&str1
            //0x0034ed08
            //    * &str1: 0x023b23f0
            //& str2
            //0x0034ed04
            //    * &str2: 0x023b23f0
            Console.ReadKey();
        }

        // 字符串的不可变性
        public static void StringTest2()
        {
            string str1 = "张三";
            string str2 = "张三";

            str1 = "李四";
            Console.ReadKey();
        }

    }
}
