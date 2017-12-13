using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 练习
{
    class Computer
    {
        public string fist { get; set; }
        // 根据选择的： 石头剪刀布返回int类型值
        public int ShowFist()
        {
            Random random = new Random();
            int number = random.Next(1, 4);
            string flag = "";
            switch (number)
            {
                case 1:
                    this.fist = "石头";
                    break;
                case 2:
                    this.fist = "剪刀";
                    break;
                case 3:
                    this.fist = "布";
                    break;
                default:
                    break;
            }
            
            return number;
        }
    }
}
