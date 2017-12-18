using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _匿名函数
{
    class Program
    {
        private delegate void DStringConvert(string[] names);

        static void Main(string[] args)
        {

            // 三个需求
            // 1. 将一个字符串数组中的每个元素都转换成大写
            // 2. 将一个字符串数组中的每个元素都转换成小写
            // 3. 将一个字符串数组中的每个元素两边都加上 双引号

            string[] names = { "abCDefG", "HIJKlmnOP", "QRsTuvW", "XyZ" };

            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //// 1.
            //Console.WriteLine("转大写:");
            //DStringConvert stringConvertDelegate1 = StringToUpper;
            //stringConvertDelegate1(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //// 2.
            //Console.WriteLine("转小写:");
            //DStringConvert stringConvertDelegate2 = new DStringConvert(StringToLower);
            //stringConvertDelegate2(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //// 3.
            //Console.WriteLine("加双引号:");
            //Demo(names, StringAddSeperator);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // 4. 匿名函数
            Console.WriteLine("匿名函数转大写:");
            Demo(names, delegate(string[] strings) {
                for (int i = 0; i < strings.Length; i++)
                {
                    strings[i] = strings[i].ToUpper();
                }
            });
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.ReadKey();
        }

        /// <summary>
        /// 字符处理
        /// </summary>
        /// <param name="name"></param>
        private static void Demo(string[] names, DStringConvert del)
        {
            del(names);
        }
        ///// <summary>
        ///// 转大写
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //private static void StringToUpper(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToUpper();
        //    }
        //}
        ///// <summary>
        ///// 转小写
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //private static void StringToLower(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = names[i].ToLower();
        //    }
        //}
        ///// <summary>
        ///// 两边加“”
        ///// </summary>
        ///// <param name="str"></param>
        ///// <returns></returns>
        //private static void StringAddSeperator(string[] names)
        //{
        //    for (int i = 0; i < names.Length; i++)
        //    {
        //        names[i] = "\"" + names[i] + "\"";
        //    }
        //}
    }
}
