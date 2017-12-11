using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    class Gift : DiscountFather
    {
        public double BuyPrice { get; set; }
        public double GiftMoney { get; set; }
        
        public Gift(double m, double s)
        {
            this.BuyPrice = m;
            this.GiftMoney = s;
        }
        // 买500 送100
        public override double GetTotalPriceByDiscount(double money)
        {
            int count = (int)(money / this.BuyPrice);
            if (money > this.BuyPrice) return (money - count * this.GiftMoney);
            return money;
        }
    }
}
