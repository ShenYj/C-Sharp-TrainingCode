using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02DayCSharp
{
    public class Student
    {
        // 构造函数
        // 1.构造函数没有返回值， 连void也不能写
        // 2.构造函数名称必须跟类名一样
        public Student(string name, int age, double height)
        {
            this.Name = name;
            this.Aage = age;
            this.Height = height;
        }
        // 重载构造函数
        public Student(string name, int age):this(name, age, 0.0)
        {
            
        }
        public Student(string name):this(name,0,0.0)
        {

        }

        // 析构函数
        ~Student()
        {
            Console.WriteLine("学生的析构函数");
        }

        private string _name;
        private int _age;
        private double height;

        public string Name { get; set; }
        public int Aage { get; set; }
        public double Height { get; set; }
    }
}
