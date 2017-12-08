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
            set { _name = value; }
        }
        public int Age
        {
            set
            {
                // set 方法中做限定
                if (value < 0 || value > 100) value = 0;
                _age = value;
            }
            get { return _age; }
        }
        
        public char Gender
        {
            set { _gender = value; }
            get
            {
                // get 方法做限定
                if (_gender != '男' || _gender != '女') return _gender = '男';
                return _gender;

            }
        }

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

        // 构造函数
        public Person(string name, int age, char gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        // 构造函数参数少的调用全参的构造函数
        public Person(string name, int age):this(name,age,'男')
        {
        }
    }
}
