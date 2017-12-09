using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{
    class Program
    {
        static void Main(string[] args)
        {
            // 继承的特性：
            // 1. 继承具有单根性 ： 一个子类只有一个父类
            // 2. 继承具有传递性 ： 

            // 如果某个类没有继承任何类， 则继承自object类


            // 如果在父类中重写了构造函数， 子类找不到无参构造函数就会报错， 解决方法
            // 1. 在父类中重新写一个无参的构造函数
            // 2. 在子类中 “显示”的调用父类的构造函数， 使用关键字 :base()

            Student xiaoDu = new Student("小杜", 19, Person.Gender.Female);
            Console.WriteLine("学生{0}的年龄是{1}性别是{2}", xiaoDu.Name, xiaoDu.Age, xiaoDu.Sex);

            Student xiaoWang = new Student("小王", 19, Person.Gender.Male, 01);
            Console.WriteLine("学生{0}的年龄是{1}性别是{2}学号是{3}",xiaoWang.Name, xiaoWang.Age, xiaoWang.Sex,xiaoWang.Id);

            Teacher laoDu = new Teacher("老杜", 30, Person.Gender.Male);
            Console.WriteLine("教师{0}的年龄是{1}性别是{2}", laoDu.Name, laoDu.Age, laoDu.Sex);

            Teacher xiaoLiu = new Teacher("小刘", 26, Person.Gender.Female);
            Console.WriteLine("实习教师{0}今年{1}岁，性别{2}",xiaoLiu.Name, xiaoLiu.Age, xiaoLiu.Sex);

            xiaoDu.SayHello();

            Console.ReadKey();
        }
    }

    public class Person
    {

        public enum Gender
        {
            Male,
            Female
        }

        // 使用private ， 子类并没有继承
        private string _name;
        private int _age;
        private Gender _sex;

        // 构造函数
        public Person(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public void SayHello()
        {
            Console.WriteLine("大家好， 我是人类");
        }

        // 避免子类报错方式一
        //public Person()
        //{

        //}

        // 属性
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        public int Age
        {
            set
            {
                if (value <= 0 || value > 110)
                {
                    value = 0;
                }
                _age = value;
            }
            get
            {
                return _age;
            }
        }
        public Gender Sex
        {
            set
            {
                if (value != Gender.Female && value != Gender.Male)
                {
                    value = Gender.Male;
                }
                _sex = value;
            }
            get
            {
                return _sex;
            }
        }

    }

    public class Teacher : Person
    {

        public void Coach()
        {
            Console.WriteLine("授课");
        }

        //  避免子类报错方式二（推荐方式）
        public Teacher(string name, int age, Gender sex) :base(name, age, sex)
        {

        }
    }

    public class Student : Person
    {
        public void Study()
        {
            Console.WriteLine("上学");
        }
        public Student(string name, int age, Gender sex) : base(name, age, sex)
        {

        }
        public Student(string name, int age, Gender sex, int id) : base(name, age, sex)
        {
            this.Id = id;
        }

        public void SayHello()
        {
            Console.WriteLine("大家好， 我是学生类");
        }

        private int _id;
        public int Id
        {
            set
            {
                if (value < 1) value = 1;
                _id = value;
            }
            get
            {
                return _id;
            }
        }
    }
}
