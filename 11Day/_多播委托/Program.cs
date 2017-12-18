using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _多播委托
{
    class Program
    {
        public delegate void DelegateTest();


        static void Main(string[] args)
        {

            DelegateTest del1 = Test1;
            // 多播委托
            del1 += Test2;
            del1 += Test3;
            del1 += Test4;
            del1();
            Console.WriteLine("~~~~~~~~~~~~~~~");
            del1 -= Test4;
            del1 -= Test3;

            del1();

            Console.ReadKey();

        }

        public static void Test1()
        {
            Console.WriteLine("Test1");
        }

        public static void Test2()
        {
            Console.WriteLine("Test2");
        }

        public static void Test3()
        {
            Console.WriteLine("Test3");
        }

        public static void Test4()
        {
            Console.WriteLine("Test3");
        }

    }
}
