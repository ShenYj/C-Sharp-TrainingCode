﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test02
{
    class Person
    {
        private string _name;
        private int _age;
        private char _gender;

        // 属性
        public string Name
        {
            // set方法
            set { _name = value; }
            // get方法
            get { return _name; }
        }
        public int Age
        {
            set
            {
                if ( value < 0 || value >100)
                {
                    value = 0;
                }
                _age = value;
            }
            get { return _age; }
        }
        public char Gender
        {
            set { _gender = value; }
            get
            {
                if (_gender != '男' && _gender != '女')
                {
                    return _gender = '男';
                }
                return _gender;
            }
        }


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
