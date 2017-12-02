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
            Student xiaoming = new Student("xiaoming",18,12.5);
            Console.WriteLine("姓名： {0}\n年龄：{1}\n身高：{2}\n",xiaoming.Name,xiaoming.Aage,xiaoming.Height);
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
