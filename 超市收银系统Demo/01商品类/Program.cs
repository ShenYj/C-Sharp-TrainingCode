using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperMarket market = new SuperMarket();
            market.ShowPros();
            market.AskBuying();
            Console.ReadKey();
        }
    }
}
