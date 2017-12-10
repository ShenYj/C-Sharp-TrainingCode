using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File类
{
    class Program
    {
        static void Main(string[] args)
        {
            // File类

            // 创建文件
            //File.Create(@"C:\Users\Ryan Shen\Desktop\abc.txt");

            // 删除文件
            //File.Delete(@"C:\Users\Ryan Shen\Desktop\abc.txt");

            // 复制一个文件
            File.Copy(@"C:\Users\Ryan Shen\Desktop\abc.txt", @"C:\Users\Ryan Shen\Desktop\bcd.txt");

            Console.ReadKey();
        }
    }
}
