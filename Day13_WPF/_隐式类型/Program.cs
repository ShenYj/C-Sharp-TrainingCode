using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _隐式类型
{
    class Program
    {
        static void Main(string[] args)
        {
            // 隐式类型
            var p = new { Name = "黄林", Age = 18, Email = "wqasdf@163.com" };
            Console.WriteLine(p.Name);
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Email);
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }

}
