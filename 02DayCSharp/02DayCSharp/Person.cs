using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DayCSharp
{
    // 非静态类
    public class Person
    {
        // 静态字段
        private static string _name;
        // 实例字段
        private char _gender;

        // 静态属性
        public static string Name
        {
            get { return Person._name; }
            set { Person._name = value; }
        }

        // 静态属性
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        // 静态方法
        public static void M2()
        {
            Console.WriteLine("Person 类中的静态方法, 可以访问静态成员变量 {0}", _name);
        }
        // 实例方法
        public void M1()
        {
            // 实例函数中， 既可以使用静态成员， 也可以使用实例成员
            Console.WriteLine("Person 类中的非静态方法， 可以访问实例成员变量{0}", _gender);
        }

    }

    // 静态类
    public static class Teacher
    {
        // 静态类中不允许存在实例成员， 只允许存在静态成员
        // 静态类不允许实例化对象
        // 静态类会在应用程序退出时释放内存资源
    }

}
