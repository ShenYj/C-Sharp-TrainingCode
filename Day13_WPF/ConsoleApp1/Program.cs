﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 枚举
            Des d = Des.gao | Des.fu;
            Console.WriteLine(d);
            Console.ReadKey();
            
        }
        [Flags]// 标示枚举,打印后不再是数值，而是枚举中的文本
        public enum Des
        {
            gao   = 1,
            fu    = 2,
            shuai = 4,
        }
    }
}
