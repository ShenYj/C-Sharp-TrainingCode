using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DayCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // new的作用
            // 1.在内存中开辟内存空间
            // 2.开辟的空间中创建对象
            // 3.调用对象的构造函数初始化对象
            Student xiaoming = new Student("xiaoming",18,12.5);
            Console.WriteLine("姓名：{0}\n年龄：{1}\n身高：{2}\n",xiaoming.Name,xiaoming.Aage,xiaoming.Height);
            Console.ReadKey();

            // 重载构造函数的使用
            Student xiaohua = new Student("zhangsan");
            Console.WriteLine("{0}的年龄：{1}", xiaohua.Name, xiaohua.Aage);
            Console.ReadKey();
        }

        // 静态方法 实例方法
        public void test ()
        {
            Person p = new Person();
            // 实例调用实例方法
            p.M1();
            p.Gender = '男';
            // 静态方法
            Person.M2();
            Person.Name = "人类";

            Console.ReadKey();
        }
    }
}
