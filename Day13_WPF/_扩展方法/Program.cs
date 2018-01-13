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
            //List<int> list = new List<int>();
            //list.Add(10);
            //list.Add(12);
            //list.Add(134);
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
        public static void SayHello(this Person p)
        {
            Console.WriteLine("SayHello Method");
        }
    }
}
