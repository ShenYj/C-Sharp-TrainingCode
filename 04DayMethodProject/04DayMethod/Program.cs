using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// C# 方法练习
/// </summary>
namespace _04DayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 123;
            int number2 = 42;

            int result = GetMaxNumber(123, 42);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        public static int GetMaxNumber(int n1, int n2)
        {
            return (n1 > n2) ? n1 : n2;
        }
    }
}
