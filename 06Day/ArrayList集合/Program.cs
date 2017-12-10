using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayList集合
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList 集合
            // 1.长度可以任意改变， 类型随便
            ArrayListTest3();
            
            Console.ReadKey();
        }

        // 1.基本使用， ArrayList的创建 添加元素
        public static void ArrayListTest1()
        {
            ArrayList list = new ArrayList();

            list.Add("小王");
            list.Add(9);
            list.Add('A');

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.AddRange(new string[] { "老王", "隔壁"});
            // 指定位置插入
            list.Insert(0, "小东");
            list.InsertRange(2, new int[] { 1, 5, 65 });
            // 移除
            Console.WriteLine("------------------------操作后打印------------------------");
            list.Remove("小王");

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            if (list.Contains("小东"))
            {
                Console.WriteLine("包含小东这个元素");
            }
        }

        // 2.
        public static void ArrayListTest2()
        {
            // 创建一个集合， 里面添加一些数字， 求平均值与和
            ArrayList arrayList = new ArrayList();

            arrayList.AddRange(new int[]{ 1, 3, 5, 6, 9, 10});

            int sum = 0;
            int average = 0;
            for (int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i] is int)
                {
                    sum += (int)arrayList[i];
                }
                
            }
            average = sum / arrayList.Count;

            Console.WriteLine("和：{0}  \n平均值：{1}", sum, average);
        }

        // 3.
        public static void ArrayListTest3()
        {
            // 写一个长度为10的集合， 要求在里面随机的存放10个数字 （0 - 9）， 要求所有数字不重复
            ArrayList arrayList = new ArrayList();
            Random random = new Random();
            int number = 0;
            while (true)
            {
                if (arrayList.Count >= 10) break;
                number = random.Next(0, 10);
                if (!arrayList.Contains(number))
                {
                    arrayList.Add(number);
                }
                else
                {
                    number = random.Next(0, 10);
                }
            }


            for(int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            
        }
    }
}
