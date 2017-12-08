using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.Description(); // 调用静态方法

            Person xiaoMing = new Person();
            xiaoMing.Name = "小明";
            //xiaoMing._name = "小明";
            
            xiaoMing.Eat("炸鸡");
            xiaoMing.Drink("啤酒");
            Console.ReadKey();
        }
    }
}
