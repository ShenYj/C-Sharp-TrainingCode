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
            //int number1 = 123;
            //int number2 = 42;

            //int result = GetMaxNumber(123, 42);
            //Console.WriteLine(result);

            //Test1(number1);
            //Console.WriteLine(number1);
            //Console.ReadKey();


            // out 参数使用
            //int min = 0;
            //int max = 0;

            //int[] array = { 2, 5, 5, 6, 2, 7 };
            //GetMaxMinNumber(array, out max,out min);

            //Console.WriteLine("最大值: {0}", max);
            //Console.WriteLine("最小值: {0}", min);
            //Console.ReadKey();

            // ref 参数使用
            //double money = 5000;
            //JiangJin(ref money);

            //Console.WriteLine(money);
            //Console.ReadKey();

            //FaKuan(ref money);
            //Console.WriteLine(money);
            //Console.ReadKey();

            // params 可变参数
            int[] score = { 11, 49, 99};
            //Test(score, "小杜");
            Test("小杜",23, 45, 132, 543, 65);
            Console.ReadKey();
        }

        // params 可变参数 必须是最后一个参数
        public static void Test(string name,params int[] score)
        {
            int sum = 0;
            for(int i = 0; i < score.Length; i++)
            {
                sum += score[i];
            }
            Console.WriteLine("{0}这次考试的总成绩是：{1}",name,sum);
        }

        // ref 参数使用
        public static void JiangJin(ref double s)
        {
            s += 500;
        }
        public static void FaKuan(ref double s)
        {
            s -= 500;
        }

        // out 参数使用
        public static void GetMaxMinNumber(int[] arr, out int max,out int min)
        {
            max = arr.First();
            min = arr.First();

            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i]) max = arr[i];
                if (min > arr[i]) min = arr[i];
            }
        }

        /// <summary>
        /// 求两个数的最大值
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static int GetMaxNumber(int n1, int n2)
        {
            return (n1 > n2) ? n1 : n2;
        }

        public static void Test1(int number)
        {
            number += 2;
        }

        
    }
}
