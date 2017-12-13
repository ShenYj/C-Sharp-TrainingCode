using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 练习
{
    public enum Result
    {
        PlayerWin,
        ComputerWin,
        Deuce
    }
    class Referee
    {
        // 比赛结果
        public static Result Result (int player, int computer)
        {
            int value = player - computer;
            if (value == -1 || value == 2)
            {
                return 练习.Result.PlayerWin;
            }
            else if (value == 0)
            {
                return 练习.Result.Deuce;
            }
            else
            {
                return 练习.Result.ComputerWin;
            }
        }
    }
}
