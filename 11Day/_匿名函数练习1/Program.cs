using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _匿名函数练习1
{
    class Program
    {
        public delegate void DStringFormatterConvert(string[] strings);

        static void Main(string[] args)
        {
            string[] lists = { "Acer", "sanSUng", "DeLL" };

            //DStringFormatterConvert del1 = delegate (string[] strs)
            //{
            //    for (int i = 0; i < strs.Length; i++)
            //    {
            //        strs[i] = strs[i].ToUpper();
            //    }
            //};
            //del1(lists);
            
            DStringFormatterConvert del2 = (string[] strs) => {

                for (int i = 0; i < strs.Length; i++)
                {
                    strs[i] = strs[i].ToUpper();
                }
            };
            del2(lists);
            foreach (string item in lists)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }




        public static void Demo(string[] strs, DStringFormatterConvert delegateS)
        {
            delegateS(strs);
        }

        public static void Test()
        {
            string[] lists = { "Acer", "sanSUng", "DeLL" };

            Demo(lists, delegate (string[] strs) {

                for (int i = 0; i < strs.Length; i++)
                {
                    strs[i] = strs[i].ToUpper();
                }
            });

            foreach (string item in lists)
            {
                Console.WriteLine(item);
            }
        }
    }
}
