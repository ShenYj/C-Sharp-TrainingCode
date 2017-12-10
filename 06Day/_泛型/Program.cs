using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            // 泛型
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(254);
            list.Add(3);
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            // 集合转成数组
            int[] nums = list.ToArray();

            // 数组转集合
            nums.ToList();


            Console.ReadKey();
        }
    }
}
