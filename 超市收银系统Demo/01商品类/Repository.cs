using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    class Repository
    {
        // 存储商品
        // 01 -> Acer
        // 02 -> SamSung
        // 03 -> Banana
        // 04 -> Oil
        public List<List<ProductFather>> Productors = new List<List<ProductFather>>();

        // 构造
        public Repository()
        {
            this.Productors.Add(new List<ProductFather>());
            this.Productors.Add(new List<ProductFather>());
            this.Productors.Add(new List<ProductFather>());
            this.Productors.Add(new List<ProductFather>());
        }
        // 展示货物
        public void ShowProducts()
        {
            foreach (List<ProductFather> pros in Productors)
            {
                Console.WriteLine("我们的仓库有{0}个{1}商品 单价{2}元", pros.Count, pros[0].Name, pros[0].Price);
            }
        }
        // 进货
        public void AddProduct(string type, int count)
        {

            for (int i = 0; i < count; i++)
            {
                switch (type)
                {
                    case "Acer":
                        Productors[0].Add(new Acer(Guid.NewGuid().ToString(), "Acer", 8799, 9990));
                        break;
                    case "SamSung":
                        Productors[1].Add(new SamSung(Guid.NewGuid().ToString(), "SamSung", 8799, 7800));
                        break;
                    case "Banana":
                        Productors[2].Add(new Banana(Guid.NewGuid().ToString(), "Banana", 8799, 2));
                        break;
                    case "Oil":
                        Productors[3].Add(new Oil(Guid.NewGuid().ToString(), "Oil", 8799, 25));
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(" 仓库添加了 {0} 个 {1} 商品 ", count, type);
        }
        // 出货
        public List<ProductFather> GetProducts(string type, int count)
        {
            List<ProductFather> list = new List<ProductFather>();
            switch (type)
            {
                case "Acer":
                    list = GetProduct(0, count);
                    break;
                case "SamSung":
                    list = GetProduct(1, count);
                    break;
                case "Banana":
                    list = GetProduct(2, count);
                    break;
                case "Oil":
                    list = GetProduct(3, count);
                    break;
                default:
                    break;
            }
            //for (int i = 0; i < count; i++)
            //{
                
            //}
            Console.WriteLine(" 仓库移除了 {0} 个 {1} 商品 ", count, type);
            return list;
        }

        private List<ProductFather> GetProduct(int index, int count)
        {
            List<ProductFather> list = new List<ProductFather>();
            if (Productors[index].Count >= count)
            {
                for (int i = 0; i < count; i++)
                {
                    list.Add(Productors[index][i]);
                }
                Productors[index].RemoveRange(0, count - 1);
            }
            else
            {
                Console.WriteLine("商品不足");
            }
            return list;
        }
    }
}
