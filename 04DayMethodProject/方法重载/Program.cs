using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法重载
{
    class Program
    {
        static void Main(string[] args)
        {

            int sum1 = Sum(12, 54);
            double sum2 = Sum(12.2, 23.5);
            

            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.ReadKey();

        }


        // 方法重载  方法的重载跟返回值没有关系
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static float Sum(float a, float b)
        {
            return a + b;
        }

    }
}
