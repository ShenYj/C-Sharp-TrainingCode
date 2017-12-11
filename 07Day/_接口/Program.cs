using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _接口
{
    class Program
    {

        static void Main(string[] args)
        {
            NBAPlayer nbaPlayer = new NBAPlayer();
            nbaPlayer.KouLan();
            Person person = new Person();
            person.Eat();
            Student student = new Student();
            student.Eat();      // 通过继承具有Eat方法 
            student.KouLan();   // 通过接口具有KouLan方法

            person.Say();

            Console.ReadKey();
        }
    }

    public class Person
    {
        public void Eat()
        {
            Console.WriteLine("吃");
        }
    }

    public class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("我可以扣篮");
        }
    }

    // 继承具有单根性， 只能继承自一个类 IKouLanable是声明的一个接口
    public class Student : Person, IKouLanable, ISleep
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        // 想要让学生也会扣篮
        public void KouLan()
        {
            Console.WriteLine("学生也会扣篮");
        }

        public string Sleep()
        {
            return "学生爱睡觉";
        }

    }

    // 声明接口
    public interface IKouLanable
    {
        // 1. 接口中声明的方法默认是public， 不允许再手动添加public修饰
        //    同抽象类方法一样，没有方法体
        // 2. 接口中不能包含字段
        // 3. 接口中可以写属性， 但不能有方法体
        
        void KouLan();

        string Name
        {
            get;
            set;
        }
    }
    public interface ISleep
    {
        string Sleep();
    }

    // 声明接口语法:
    //[public] interface I...接口名（一般以I开头）

    // 接口的特点
    // 1. 不可以有访问修饰符 默认为public， 不能修改
    // 2. 可以有方法、属性（自动属性--没有方法体）
    // 3. 接口和静态类、抽象类一样不允许被实例化
    // 4. 接口可以多继承， 如果继承了类的同时，父类必须写在接口前
    // 5. 接口只能继承与接口， 不能继承与类
    // 6. 继承自某个接口后， 必须实现接口中的方法
    
}
