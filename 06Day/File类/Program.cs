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
            //File.Copy(@"C:\Users\Ryan Shen\Desktop\abc.txt", @"C:\Users\Ryan Shen\Desktop\bcd.txt");

            // 读取文件
            string path = @"C:\Users\Ryan Shen\Desktop\蓝牙通信升级测试.txt";

            // 方式一 （读取文本文件， 返回数组， 可以精确到每一行进行操作）
            string[] content1 = File.ReadAllLines(path, Encoding.Default);
            //foreach (var item in content1)
            //{
            //    Console.WriteLine(item);
            //}

            // 方式二 (读取文本文件， 返回字符串)
            string content2 = File.ReadAllText(path, Encoding.Default);
            //Console.WriteLine(content2);

            // 方式三 （字节的方式读取）
            Byte[] content3 = File.ReadAllBytes(path);
            //foreach (Byte item in content3)
            //{
            //    Console.WriteLine(item);
            //}

            // 写文件
            string writePath = @"C:\Users\Ryan Shen\Desktop\abc.txt";
            //File.WriteAllLines(writePath, content1);
            File.WriteAllLines(writePath, content1, Encoding.Default);

            Console.ReadKey();
        }
    }
}
