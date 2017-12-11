using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _超市收银系统练习
{
    class SuperMarket
    {
        // 创建仓库
        Repository repository = new Repository();

        public SuperMarket()
        {
            repository.AddProduct("Acer", 1000);
            repository.AddProduct("Oil", 10000);
            repository.AddProduct("SamSung", 1999);
            repository.AddProduct("Banana", 500);
        }

        public void AskBuying()
        {
            Console.WriteLine("欢迎光临");
            Console.WriteLine("我们有三星笔记本、鸿基笔记本、香蕉和酱油四种商品");
            Console.WriteLine("******商品列表：******");
            Console.WriteLine("****** 1. Acer 笔记本");
            Console.WriteLine("****** 2. SamSung 笔记本");
            Console.WriteLine("****** 3. Banana 香蕉");
            Console.WriteLine("****** 4. Oil 地沟油");
            Console.WriteLine("*********************");
            Console.WriteLine("输入序号进行选择：");
            string strType = Console.ReadLine();
            int a = -1;
            bool flag = int.TryParse(strType, out a);
            while (!flag)
            {
                Console.WriteLine("输入有误， 请重新输入");
                strType = Console.ReadLine();
                flag = int.TryParse(strType, out a);
            }

            string productName = "";
            switch (a)
            {
                case 1:
                    productName = "Acer";
                    break;
                case 2:
                    productName = "SamSung";
                    break;
                case 3:
                    productName = "Banana";
                    break;
                case 4:
                    productName = "Oil";
                    break;
                default:
                    break;
            }

            Console.WriteLine("您选择的商品类型是 : {0}", productName);
            Console.WriteLine("您需要的数量是：");

            string numberString = Console.ReadLine();
            int number = -1;
            bool flag1 = int.TryParse(numberString, out number);

            while (!flag1)
            {
                Console.WriteLine("输入有误， 请重新输入");
                numberString = Console.ReadLine();
                flag1 = int.TryParse(numberString, out number);
            }

            Console.WriteLine("您需要的数量是： {0}", number);
            Console.WriteLine("正在取货");

            List<ProductFather> list = repository.GetProducts(productName, number);

            // 计算总价
            double totalPrice = GetTotalPrice(list);
            Console.WriteLine("总价是: {0}", totalPrice);
            Console.WriteLine("打折方式： 1--不打折，2--打九折，3--八五折，4--买300送50，5--买500送100");

            string numberString1 = Console.ReadLine();
            int number1 = -1;
            bool flag2 = int.TryParse(numberString1, out number1);
            while (!flag2)
            {
                Console.WriteLine("输入有误， 请重新输入");
                numberString = Console.ReadLine();
                flag2 = int.TryParse(numberString, out number1);
            }
            DiscountFather discountMethod = GetDiscountMethod(number1);
            double money = discountMethod.GetTotalPriceByDiscount(totalPrice);
            Console.WriteLine("打折后的价格是： {0}", money);
        }

        public DiscountFather GetDiscountMethod(int type)
        {
            DiscountFather discountMethod = null;
            switch (type)
            {
                case 1:
                    discountMethod = new NormalPrice(); ;
                    break;
                case 2:
                    discountMethod = new RatePrice(0.9);
                    break;
                case 3:
                    discountMethod = new RatePrice(0.85);
                    break;
                case 4:
                    discountMethod = new Gift(300, 50);
                    break;
                case 5:
                    discountMethod = new Gift(500, 100);
                    break;
                default:
                    break;
            }
            return discountMethod;
        }

        public double GetTotalPrice(List<ProductFather> lists)
        {
            double total = 0;
            foreach (ProductFather item in lists)
            {
                total += item.Price;
            }
            return total;
        }

        // 展示商品
        public void ShowPros()
        {
            repository.ShowProducts();
        }
    }
}
