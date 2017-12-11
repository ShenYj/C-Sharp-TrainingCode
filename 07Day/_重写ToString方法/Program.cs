using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _重写ToString方法
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString 默认打印的是这个类所在的命名空间
            Person person = new Person();
            Console.WriteLine(person.ToString());
            Console.ReadKey();

        }
    }

    public class Person
    {
        // 重写父类的虚方法
        public override string ToString()
        {
            //return base.ToString();
            return "hello C#";
        }
    }
}
