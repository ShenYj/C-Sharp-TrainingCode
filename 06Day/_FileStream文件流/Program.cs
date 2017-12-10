using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _FileStream文件流
{
    class Program
    {
        static void Main(string[] args)
        { 
            Test3();
            Console.ReadKey();
            
        }
        // StreamReader和StreamWriter ：用来操作文本
        public static void Test3()
        {
            string sourcePath = @"c:\users\ryan shen\desktop\cde.txt";

            // 读取文件
            using (StreamReader stReader = new StreamReader(sourcePath, Encoding.UTF8))
            {
                //Console.WriteLine(stReader.ReadLine()); 从当前流中读取一行， 返回一个字符串
                while (!stReader.EndOfStream)
                {
                    Console.WriteLine(stReader.ReadLine());
                }

            }

            // 写入文件
            string destinationPath = @"c:\users\ryan shen\desktop\efg.txt";
            using (StreamWriter stWriter = new StreamWriter(destinationPath, true , Encoding.UTF8))
            {
                stWriter.Write("aklsjdlkfjsa;lkdf");
            }
        }
        // FileStream 复制文件练习
        public static void Test2()
        {

            // 复制文件功能
            string sourcePath = @"c:\users\ryan shen\desktop\cde.txt";
            string destinationPath = @"c:\users\ryan shen\desktop\efg.txt";

            // 先创建一个读取的流
            using (FileStream readStream = new FileStream(sourcePath,FileMode.Open,FileAccess.Read))
            {
                // 再创建一个负责写入的流
                using (FileStream writeStream = new FileStream(destinationPath, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] bytes = new byte[1024 * 1024];   // 每次读1M
                    
                    // 循环读取文件片段
                    while (true)
                    {
                        // 读取
                        int len = readStream.Read(bytes, 0, bytes.Length);
                        // 如果读取的长度为0， 说明读取完毕
                        if (len == 0) break;

                        // 写入
                        writeStream.Write(bytes, 0, len);
                    }
                    
                }
                
            }

        }

        // FileStream 练习
        public static void Test1()
        {
            // FileStream                      操作字节的 （所有文件）
            // StreamReader 和 StreamWriter    操作字符的 （文本）
            // 读取小文件， 使用File即可

            // 1.创建filestream对象
            FileStream fsread = new FileStream(@"c:\users\ryan shen\desktop\abc.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 1];
            // 返回本次实际读取到的有效字节数
            int len = fsread.Read(buffer, 0, buffer.Length);
            // 将字节数组中的每一个元素按照指定的编码格式解码成字符串
            string s = Encoding.Default.GetString(buffer, 0, len);
            // 关闭流
            fsread.Close();
            // 释放流所占用的资源
            fsread.Dispose();
            Console.WriteLine(s);

            // 2. 写文件
            // 将创建文件流对象的过程卸载using当中， 会自动帮助我们释放流所占用的资源
            using (FileStream fsWrite = new FileStream(@"C:\Users\Ryan Shen\Desktop\cde.txt", FileMode.OpenOrCreate, FileAccess.Write))
            {
                string str = "看我阿斯顿福建阿杀戮空间";
                byte[] bufferWrite = Encoding.UTF8.GetBytes(str);
                fsWrite.Write(bufferWrite, 0, bufferWrite.Length);// 会按照字节进行覆盖
            }
        }
    }
}
