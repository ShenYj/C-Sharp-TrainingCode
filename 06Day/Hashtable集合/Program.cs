using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hashtable集合
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hashtable集合 : 键值对集合
            Hashtable ht = new Hashtable();
            // 添加数据方式1
            ht.Add(1, "张三");
            ht.Add(2, "李四");
            ht.Add(3, "王五");
            ht.Add(4, true);
            ht.Add(5, 2);
            // 添加数据方式2
            ht[6] = "xin";
            ht[1] = "干掉张三";

            if (!ht.ContainsKey(1))
            {
                ht.Add(1, "s");
            }
            else
            {
                Console.WriteLine("已经包含 1 这个Key");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // foreach循环
            // var
            // 在C#（强类型语言） 使用时必须给变量初始化值
            foreach (var item in ht.Values)
            {
                // 通过 Values 直接打印
                Console.WriteLine(item);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            foreach (var item in ht.Keys)
            {
                // 通过 Keys 获取
                Console.WriteLine(ht[item]);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            // U移除指定Key的数据
            ht.Remove(1);
            foreach (var item in ht.Keys)
            {
                // 通过 Keys 获取
                Console.WriteLine(ht[item]);
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadKey();

        }
    }
}
