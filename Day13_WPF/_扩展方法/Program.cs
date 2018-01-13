using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _扩展方法
{
    class Program
    {
        static void Main(string[] args)
        {
            // 所有的扩展方法都是在静态类中的

            Person p = new Person();
            p.SayHello();
            Console.ReadKey();
        }

    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

    // 1. 扩展方法第一步：先定义一个静态类
    public static class PersonExt
    {
        // 2.通过this关键字，表示给哪个类增加扩展方法
        public static void SayHello(this Person p)
        {
            Console.WriteLine("SayHello Method");
        }
    }
}
