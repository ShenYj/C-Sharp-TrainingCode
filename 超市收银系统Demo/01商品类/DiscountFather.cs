using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    public abstract class DiscountFather
    {
        // 抽象类 打折方法
        /// <summary>
        /// 计算打折后的价格
        /// </summary>
        /// <param name="money">打折前的价格</param>
        /// <returns>打折后的价格</returns>
        public abstract double GetTotalPriceByDiscount(double money);
    }
}
