using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _lamda表达式_匿名函数_
{
    class Program
    {
        // 声明委托
        private delegate void DelOne();
        private delegate void DelTwo(string name);
        private delegate string DelThree(string name);

        static void Main(string[] args)
        {
            DelOne one = () => { };
            DelTwo two = (string name) => { };
            DelThree three = (string name) => {  return name; };
        }
    }
}
