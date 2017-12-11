using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _MD5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入字符串， 将输出MD5加密后的字符串数据");
            string input = Console.ReadLine();
            Console.WriteLine(GetMD5(input));
            Console.ReadKey();
        }

        public static string GetMD5(string str)
        {
            MD5 md5 = MD5.Create();
            byte[] bufferOriginal = Encoding.Default.GetBytes(str);
            byte[] bufferMD5 = md5.ComputeHash(bufferOriginal);

            // 将字节数组转换成字符串
            //  字节数组 ---》  字符串
            // 1. 将字节数组中每个元素按照指定的编码格式解析成字符串
            // 2. 直接将数组ToString（）  ---->打印的是命名空间
            // 3. 将字节数组中的每个元素ToString（）
            // return Encoding.Default.GetString(bufferMD5); 乱码
            string md5String = "";
            for (int i = 0; i < bufferMD5.Length; i++)
            {
                // ToString("x") 转成十六进制字符串
                md5String += bufferMD5[i].ToString("X2");
            }
            return md5String;
        }
    }
}
