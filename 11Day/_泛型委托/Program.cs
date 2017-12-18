using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _泛型委托
{
    class Program
    {
        // 泛型委托
        private delegate T GetMaxNumber<T>(T t1, T t2);
        static void Main(string[] args)
        {
            GetMaxNumber<int> getMax1 = (int a, int b) =>
            {
                if (a > b)
                {
                    return a;
                }
                return b;
            };
            int number = getMax1(23, 54);

            GetMaxNumber<string> getMax2 = delegate(string a, string b)
            {
                if (a.Length > b.Length)
                {
                    return a;
                }
                return b;
            };
            string str = getMax2("asdfasdf", "asdfasdfasdfasdfasdf");


            Console.WriteLine(number);
            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
