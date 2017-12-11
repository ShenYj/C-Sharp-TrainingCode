using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    class NormalPrice : DiscountFather
    {
        public override double GetTotalPriceByDiscount(double money)
        {
            return money;
        }
    }
}
