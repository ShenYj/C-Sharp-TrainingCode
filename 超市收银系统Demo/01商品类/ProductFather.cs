using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    public class ProductFather
    {
        // 价格
        public double Price { get; set; }
        // 数量
        public double Count { get; set; }
        // ID 使用Guid生成
        public string ID { get; set; }
        // 商品名称
        public String Name { get; set; }

        public ProductFather(string id, string name, double count, double price)
        {
            this.ID = id;
            this.Count = count;
            this.Price = price;
            this.Name = name;
        }
    }
}
