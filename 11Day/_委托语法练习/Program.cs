using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _委托语法练习
{
    class Program
    {
        // 声明委托
        private delegate void DSayHi(string name);

        static void Main(string[] args)
        {
            // 1.
            DSayHi sayHi1 = new DSayHi(SayHiChinese);
            sayHi1("老王");

            // 2. 
            DSayHi sayHi2 = SayHiEnglish;
            sayHi2("Micheal");

            // 3.
            SayHi("老李", SayHiChinese);

            // 4.lamda
            DSayHi say = (string name) => { Console.WriteLine(name + " 你好！"); };
            say("老王");

            // 5.
            DSayHi s = delegate(string name) {
                Console.WriteLine(name + " 你好！");
            };
            s("小明");

            Console.ReadKey();
        }

        private static void SayHi(string name , DSayHi delegateSayHi)
        {
            delegateSayHi(name);
        }

        private static void SayHiChinese(string name)
        {
            Console.WriteLine( "\"" + name + "\"" + " 你好");
        }
        private static void SayHiEnglish(string name)
        {
            Console.WriteLine("Hello " + "\"" + name + "\"" );
        }

    }
}
