using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _抽象类
{
    class Program
    {

        // 实现多态： 1.虚方法 2.抽象类 3.接口


        // 通过抽象类实现多态
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.Bark();
            cat.Bark();

            Console.ReadKey();
        }

    }
    // 抽象类
    public abstract class Animal
    {
        // 抽象方法
        public abstract void Bark();
  
    }

    public class Dog : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("汪汪汪");
        }
    }

    public class Cat : Animal
    {
        public override void Bark()
        {
            Console.WriteLine("喵喵喵");
        }
    }
    
}
