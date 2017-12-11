using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _部分类
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    

    // 部分类 ：
    public partial class Person
    {
        private string _name;
    }
    public partial class Person
    {
        public void Test()
        {
            _name = ""; // 可以访问部分类中的私有成员
        }
    }
}
