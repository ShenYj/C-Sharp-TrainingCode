using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            TellStory(0);
            Console.ReadKey();
        }

        // 方法的递归
        public static void TellStory(int i)
        {
            Console.WriteLine("老和尚讲故事");
            i++;
            if (i >= 10) return;

            TellStory(i);
        }

    }
}
