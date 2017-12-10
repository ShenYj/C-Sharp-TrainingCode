using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _简繁转换
{
    class Program
    {

        private const string Jian = "我闷";
        private const string Fan = "窩悶";
        static void Main(string[] args)
        {

            // 简繁转换
            Hashtable ht = new Hashtable();

            for (int i = 0; i < Jian.Length; i++)
            {
                ht.Add(Jian[i], Fan[i]);
            }


            Console.WriteLine("请随便输入");
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (ht.Contains(input[i]))
                {
                    Console.WriteLine(ht[input[i]]);
                }
            }

            Console.ReadKey();
        }
    }
}
