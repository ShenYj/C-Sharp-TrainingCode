using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    class Person
    {
        public string _name;
        public int _age;
        public char _gender;

        public void Eat ()
        {
            Console.WriteLine("吃");
        }

        public void Drink ()
        {
            Console.WriteLine("喝");
        }

        public static void descript()
        {
            Console.WriteLine("~~~~~静态方法");
        }
    }
}
