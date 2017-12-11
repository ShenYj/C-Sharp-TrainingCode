using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace _序列化和反序列化
{
    class Program
    {
        // 序列化 和 反序列化
        static void Main(string[] args)
        {
            ReSerializePerson();
            Console.ReadKey();
        }

        // 1. 序列化
        public static void SerializePerson()
        {
            string path = @"C:\Users\Ryan Shen\Desktop\xuliehua.txt";

            Person person = new Person();
            person.Name = "小明";
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                // 2. 开始序列化
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, person);
            }
            Console.WriteLine("序列化成功");
        }

        // 2. 反序列化
        public static void ReSerializePerson()
        {
            string path = @"C:\Users\Ryan Shen\Desktop\xuliehua.txt";
            using (FileStream fileStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            {
                // 2. 开始序列化
                BinaryFormatter bf = new BinaryFormatter();
                object ob = bf.Deserialize(fileStream);
                if (ob is Person)
                {
                    Person p = (Person)ob;
                    Console.WriteLine(p.Name);
                }
            }
            Console.WriteLine("反序列化成功");
        }
    }

    // 将这个类标记为可以序列化的类
    [Serializable]
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

}
