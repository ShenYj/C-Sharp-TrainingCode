using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    class Player
    {
        // 根据选择的： 石头剪刀布返回int类型值
        public int ShowFist(string fist)
        {
            int flag = 0;
            switch (fist)
            {
                case "石头":
                    flag = 1;
                    break;
                case "剪刀":
                    flag = 2;
                    break;
                case "布":
                    flag = 3;
                    break;
                default:
                    break;
            }
            return flag;
        }
    }
}
