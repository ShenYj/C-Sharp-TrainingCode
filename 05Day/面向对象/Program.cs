using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace 面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 缺少引用的命名空间， shift + alt + F10 快捷键查看
            //2. 一个项目引用另一个项目的类， 引用中添加需要被引用的项目即可
            Console.ReadKey();
        }

        public static void RefOtherProjectClassTest1()
        {
            Student student = new Student();

        }
        /// <summary>
        /// 类、属性、字段、方法、构造函数练习
        /// </summary>
        public static void ObjectTest1()
        {
            Person.Description(); // 调用静态方法
            Person xiaoMing = new Person("小明", 18, '男');
            //xiaoMing.Name = "小明";
            //xiaoMing._name = "小明";

            xiaoMing.Eat("炸鸡");
            xiaoMing.Drink("啤酒");
        }
    }
}
