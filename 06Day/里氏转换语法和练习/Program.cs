using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏转换语法和练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 子类对象可以调用父类的成员， 但是父类对象永远都只能调用自己的成员
            Person person = new Person(); // 父类
            Student student = new Student();
            Teacher teacher = new Teacher();

            

            // 1) 子类可以复制给父类 
            //Person newPerson = student;

            // 2）如果父类中装的是子类对象， 那么可以将这个父类强转为子类对象
            //Student newStudent = (Student)newPerson;

            // 1. is: 表示类型转换， 如果能够转换成功， 则返回一个true， 否则返回一个false
            // 2. as: 表示类型转换， 如果能够转换则返回对应的对象， 否则返回一个null

            // 补充： protect关键字， 可以被1.该类中的函数、2.子类的函数、以及3.其友元函数访问。 但不能被该类的对象访问


            Person newPerson = student;
            // 1. is使用
            if (newPerson is Student)
            {
                Student newStudent = (Student)newPerson;
                Console.WriteLine("转换成功 is");
                
            }
            else
            {
                Console.WriteLine("转换失败 is");
            }

            // 2. as使用
            Teacher newTeacher = newPerson as Teacher;
            if (newTeacher == null)
            {
                Console.WriteLine("转换失败 as");
            }
            else
            {
                Console.WriteLine("转换成功 as");
            }

            Console.ReadKey();
        }
    }

    // 基类: 人类
    public class Person
    {
        protected int abc;
        public void PersonSayHello()
        {
            Console.WriteLine("我是父类");
        }
    }
    // 派生类: 教师类
    public class Teacher : Person
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是教师类");
            
        }
    }
    // 派生类： 学生类
    public class Student : Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生类");
        }
    }
}
