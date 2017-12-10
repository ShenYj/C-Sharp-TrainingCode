using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Dictionary集合
{
    class Program
    {
        static void Main(string[] args)
        {
            DictionaryTest3();
            string str1 = "s";
            string str2 = "S";
                
            Console.ReadKey();
        }

        public static void DictionaryTest3()
        {
            // 统计Welcome to china 中每个字符出现的次数 不考虑大小写
            string str = "Welcome to china";
            List<char> list = str.ToList<char>();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for (int i = 0; i < list.Count; i++)
            {
                char c = list[i];
                if (c.Equals(' ')) continue;
                if (dict.ContainsKey(c))
                {
                    dict[c] += 1;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }

            foreach (KeyValuePair<char, int> kv in dict)
            {
                Console.WriteLine("{0}出现了{1}次", kv.Key, kv.Value);
            }

        }

        public static void DictionaryTest2()
        {
            // 提示用户输入一个字符串， 通过foreach循环将用户输入的字符串赋值给一个字符数组
            Console.WriteLine("请输入一个字符串");

            string input = Console.ReadLine();
            List<char> list = new List<char>();

            foreach (char c in input)
            {
                list.Add(c);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        public static void DictionaryTest1()
        {
            // 将一个数组中的基数放在一个集合中， 再讲偶数放在另一个集合中
            // 最终将两个集合合并为一个集合，并且基数显示在左边 偶数显示在右边
            int[] array = new int[] { 12, 5, 32, 5, 2, 6, 8, 76};
            ArrayList arrayList1 = new ArrayList();
            ArrayList arrayList2 = new ArrayList();
            List<ArrayList> list = new List<ArrayList>();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0) arrayList2.Add(array[i]);
                if (array[i] % 2 != 0) arrayList1.Add(array[i]);
            }
            list.Add(arrayList1);
            list.Add(arrayList2);
            foreach (ArrayList item in list)
            {
                for (int i = 0; i < item.Count; i++)
                {
                    Console.Write( item[i] + " ");
                }
            }

            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //foreach (int item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            //foreach (int item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public static void DictionaryTest()
        {
            // dictionary集合
            Dictionary<int, string> dict = new Dictionary<int, string>();

            dict.Add(1, "小杜");
            dict.Add(2, "张三");
            dict.Add(3, "李四");
            dict.Add(4, "王五");

            // 键值对方式遍历
            foreach (KeyValuePair<int, string> kv in dict)
            {
                Console.WriteLine("  {0} - {1}", kv.Key, kv.Value);
            }
        }
    }
}
