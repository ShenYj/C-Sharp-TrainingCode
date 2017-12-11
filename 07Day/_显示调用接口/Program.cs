using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _显示调用接口
{
    class Program
    {
        // 显示实现接口 解决方法的重名问题
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Say();

            ISay isay = new Person();
            isay.Say();
            Console.ReadKey();
        }
    }

    public class Person : ISay
    {
        public void Say()
        {
            Console.WriteLine("人会说话");
        }

        // 显示实现接口
        void ISay.Say()
        {
            Console.WriteLine("接口的说话方法");
        }
    }

    public interface ISay
    {
        void Say();
    }
}
