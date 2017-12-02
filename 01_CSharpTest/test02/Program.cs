using System;

namespace test02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person wangmazi = new Person();

            wangmazi._name = "王麻子";
            wangmazi._age = 25;
            wangmazi._gender = '男';

            Person.descript();
            

            wangmazi.Eat();
            wangmazi.Drink();

            Console.ReadKey();
        }
    }
}





