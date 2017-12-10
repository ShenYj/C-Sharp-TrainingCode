using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _虚拟方法
{
    class Program
    {
        // 通过虚方法实现多态
        static void Main(string[] args)
        {
            Person person = new Student();
            person.SayHello();
            Console.ReadKey();
        }
    }

    public class Person
    {
        // 标记为虚方法 （可以被子类重新写一遍）
        public virtual void SayHello()
        {
            Console.WriteLine("人类SayHello");
        }
    }
    public class Student : Person
    {
        // 子类中通过override关键字重写
        public override void SayHello()
        {
            Console.WriteLine("学生类SayHello");
        }
    }
}
