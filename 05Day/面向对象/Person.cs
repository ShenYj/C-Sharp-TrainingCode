using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象
{
    public class Person
    {
        // 1.字段
        public string _name;
        public int _age;
        public char _gender;
        // 2.属性 （作用：保护字段， 对字段的取值/赋值 进行限定）
        public string Name
        {
            get { return _name; }
            set
            {
                if (value < 0 || value > 100)
                {
                    value = 0;
                }
                _name = value;
            }
        }
        public string Age { get; set; }
        public string Gender { get; set; }

        // 3.1方法 (静态方法)
        public static void Description()
        {
            Console.WriteLine("Person 类的静态方法");
        }
            
        // 3.2方法 (非静态方法)
        public void Eat(string sth)
        {
            Console.WriteLine("{0} 吃 {1}",this._name,sth);
        }
        public void Drink(string sth)
        {
            Console.WriteLine("{0} 喝 {1}",this._name,sth);
        }
    }
}
