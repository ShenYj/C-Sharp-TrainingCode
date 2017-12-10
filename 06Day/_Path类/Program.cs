using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _Path类
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ryan Shen\Desktop\蓝牙通信升级测试.txt";
            // 获取目录
            string directory = Path.GetDirectoryName(path);
            Console.WriteLine("目录：" + directory);
            // 获取文件名
            string fileName = Path.GetFileName(path);
            Console.WriteLine("文件名：" + fileName);
            // 文件名（不带后缀）
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(path);
            Console.WriteLine("不带后缀的文件名：" + fileNameWithoutExtension);
            // 后缀名
            string extensionName = Path.GetExtension(path);
            Console.WriteLine("后缀名:" + extensionName);
            // 全路径
            string fullPath = Path.GetFullPath(path);
            Console.WriteLine("全路径:" + fullPath);
            // 拼接
            Console.WriteLine(Path.Combine(@"c:\" + @"abc.txt"));
            Console.ReadKey();
        }
    }
}
