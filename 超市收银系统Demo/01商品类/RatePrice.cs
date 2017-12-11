using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    class RatePrice : DiscountFather
    {
        // 折扣率
        public double Rate { get; set; }

        // 构造函数
        public RatePrice(double rate)
        {
            this.Rate = rate;
        }

        // 获取打折后的价格
        public override double GetTotalPriceByDiscount(double money)
        {
            return this.Rate * money;
        }
    }
}
