using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    public class Banana : ProductFather
    {
        public Banana(string id, string name, double count, double price) : base(id, name, count, price)
        {

        }
    }
}
