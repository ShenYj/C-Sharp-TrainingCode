using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        public static int[] _mapArray = new int[100];           // 地图的坐标集合
        public static int[] _PlayerPoint = new int[2];          // 玩家坐标
        public static string[] _playerNames = new string[2];    // 玩家姓名
        public static bool[] flags = new bool[2];               // 玩家是否继续的标记

        static void Main(string[] args)
        {
            ConsoleHeader();

            if (GetPlayersName())
            {
                // 获取玩家姓名成功
                Console.Clear();
                DrawMap();
                // 两个玩家都没有达到终点， 持续
                while (_PlayerPoint.First() < 99 && _PlayerPoint.Last() < 99)
                {
                    if(flags[0] == false)
                    {
                        PlayGameOneForOnePlayer(0);
                    }
                    else
                    {
                        flags[0] = false;
                    }
                    if(flags[1] == false)
                    {
                        PlayGameOneForOnePlayer(1);
                    }
                    else
                    {
                        flags[1] = false;
                    }
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        ///  每次玩家游戏的过程
        ///  游戏规则：
        /// 1. 如果玩家1踩到了玩家2 玩家2退6格
        /// 2. 踩到了地雷 退6格
        /// 3. 踩到了时空隧道 进10格
        /// 4. 踩到了幸运轮盘，选择： 1交换位置 2轰炸对方 使对方退6格
        /// 5. 踩到了暂停 暂停一回合
        /// 6. 踩到了方块 神马都不干
        /// </summary>
        /// <param name="playerIndex"></param>
        public static void PlayGameOneForOnePlayer(int playerIndex)
        {
            int currentPlayerIndex = playerIndex;
            int anotherPlayerIndex = 1 - playerIndex;
            Console.WriteLine(" \"{0}\" 按任意键， 掷骰子 ", _playerNames[currentPlayerIndex]);
            Console.ReadKey(true);
            Random randomNumber = new Random();
            int random = randomNumber.Next(1, 7); ;
            Console.WriteLine(" \"{0}\" 掷出了 {1} ", _playerNames[currentPlayerIndex], random);
            // 目标坐标处理
            _PlayerPoint[currentPlayerIndex] += random;
            Console.WriteLine(" \"{0}\" 按任意键开始行动 ", _playerNames[currentPlayerIndex]);
            Console.ReadKey(true);
            Console.WriteLine(" \"{0}\" 行动完了 ", _playerNames[currentPlayerIndex]);
            Console.ReadKey(true);

            // 玩家A 踩到了玩家B
            if (_PlayerPoint[currentPlayerIndex] == _PlayerPoint[anotherPlayerIndex])
            {
                Console.WriteLine("  \"{0}\" 踩到了 \"{1}\" \"{2}\"退6格", _playerNames[currentPlayerIndex], _playerNames[anotherPlayerIndex], _playerNames[anotherPlayerIndex]);
                _PlayerPoint[anotherPlayerIndex] -= 6;
                if (_PlayerPoint[anotherPlayerIndex] < 0) _PlayerPoint[anotherPlayerIndex] = 0;
                Console.ReadKey(true);
            }
            else if (_PlayerPoint[currentPlayerIndex] < 100) // 踩到关卡
            {
                int index = _mapArray[_PlayerPoint[currentPlayerIndex]];
                string message = " " + _playerNames[currentPlayerIndex] + " ";
                switch (index)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        message += "踩到了地雷 退6格";
                        Console.WriteLine(message);
                        _PlayerPoint[currentPlayerIndex] -= 6;
                        if (_PlayerPoint[currentPlayerIndex] < 0) _PlayerPoint[currentPlayerIndex] = 0;
                        Console.ReadKey(true);
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        message += "踩到了时空隧道 进10格";
                        Console.WriteLine(message);
                        _PlayerPoint[currentPlayerIndex] += 10;
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        message += "踩到了幸运轮盘 请选择： 1.交换位置 2.轰炸对方，使对方退6格";
                        Console.WriteLine(message);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine(" {0} 选择的是： 1.交换位置 ", _playerNames[currentPlayerIndex]);
                                int tempPoint = _PlayerPoint[currentPlayerIndex];
                                _PlayerPoint[currentPlayerIndex] = _PlayerPoint[anotherPlayerIndex];
                                _PlayerPoint[anotherPlayerIndex] = tempPoint;
                                Console.WriteLine("交换成功， 按任意键继续游戏");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine(" {0} 选择的是： 2.轰炸对方，使对方退6格 ", _playerNames[currentPlayerIndex]);
                                _PlayerPoint[anotherPlayerIndex] -= 6;
                                if (_PlayerPoint[anotherPlayerIndex] < 0) _PlayerPoint[anotherPlayerIndex] = 0;
                                Console.WriteLine(" \"{0}\" 退6格", _playerNames[anotherPlayerIndex]);
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine(" 请选择： 1.交换位置 2.轰炸对方");
                                input = Console.ReadLine();
                            }
                        }
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        message += "踩到了暂停 暂停一回合";
                        Console.WriteLine(message);
                        flags[currentPlayerIndex] = true;
                        Console.ReadKey(true);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        message += "踩到了方块 神马都不干";
                        Console.WriteLine(message);
                        Console.ReadKey(true);
                        break;
                }
            }
            else
            {
                Console.WriteLine("游戏结束");
                _PlayerPoint[currentPlayerIndex] = 99;
                Console.WriteLine("胜利者： {0}",_playerNames[currentPlayerIndex]);
                Console.ReadKey();
            }
            Console.Clear();
            DrawMap();
        }

        /// <summary>
        /// 获取玩家姓名
        /// </summary>
        public static bool GetPlayersName()
        {
            Console.WriteLine("请输入玩家A姓名：");
            _playerNames[0] = Console.ReadLine();
            while (_playerNames[0] == "")
            {
                Console.WriteLine("玩家姓名A不能为空， 请重新输入");
                _playerNames[0] = Console.ReadLine();
            }
            Console.WriteLine("请输入玩家B姓名：");
            _playerNames[1] = Console.ReadLine();
            while (_playerNames[1] == "" || _playerNames[1] == _playerNames[0])
            {
                if (_playerNames[1] == _playerNames[0])
                {
                    Console.WriteLine("玩家B姓名不能与玩家A姓名相同， 请重新输入");
                }
                else
                {
                    Console.WriteLine("玩家姓名B不能为空， 请重新输入");
                }
                _playerNames[1] = Console.ReadLine();
            }
            return true;
        }
        /// <summary>
        /// Show Header Detail
        /// </summary>
        public static void ConsoleHeader()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
            Console.Write("**********                ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("飞行棋");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                ************");
            Console.WriteLine("************************************************************");
            Console.WriteLine("************************************************************");
        }

        public static void GameInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("玩家1  --> Ａ　玩家2  --> Ｂ  ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1. 幸运轮盘       ☆");
            Console.WriteLine("2. 地雷           ▲");
            Console.WriteLine("3. 暂停           ●");
            Console.WriteLine("4. 时空隧道       卍");
            Console.WriteLine("5. 普通坐标       □");
            Console.WriteLine("6. 玩家坐标相同   <>");
            Console.WriteLine("");
        }

        /// <summary>
        /// 1. 幸运轮盘       ☆ 
        /// 2. 地雷           ▲
        /// 3. 暂停           ●
        /// 4. 时空隧道       卍
        /// 5. 玩家坐标相同   <>
        /// </summary>
        public static void InitialMap()
        {
            int[] luckyTurn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘 ▲۞□☭
            int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷 
            int[] pause = { 9, 27, 60, 93 };// 暂停
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };// 时空隧道 ☈

            UpdateUnit(luckyTurn, 1);
            UpdateUnit(landMine, 2);
            UpdateUnit(pause, 3);
            UpdateUnit(timeTunnel, 4);
        }
        
        public static void UpdateUnit(int[] arr, int status)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                _mapArray[arr[i]] = status;
            }
        }

        public static void DrawMap()
        {
            GameInfo();
            InitialMap();
            // 第一行
            for (int i = 0; i < 30; i++)
            {
                DrawUnit(i);
            }
            Console.WriteLine("");
            // 第一列
            for (int i = 30; i < 35; i++)
            {
                Draw29Space();
                DrawUnit(i);
                Console.WriteLine("");
            }
            // 第二行
            for (int i = 64; i >= 35; i--)
            {
                DrawUnit(i);
            }
            Console.WriteLine("");
            // 第二列
            for (int i = 66; i < 71; i++)
            {
                DrawUnit(i);
                Console.WriteLine("");
            }
            // 第三行
            for (int i = 71; i < 100; i++)
            {
                DrawUnit(i);
            }
            Console.WriteLine("");
        }

        public static void Draw29Space()
        {
            for(int i = 0; i < 29; i++)
            {
                Console.Write("　");
            }
        }
        /// <summary>
        /// 绘制一个符号位
        /// </summary>
        /// <param name="i"></param>
        #region
        public static void DrawUnit(int i)
        {
            if (_PlayerPoint[0] == _PlayerPoint[1] && _PlayerPoint[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("<>");
            }
            else if (_PlayerPoint[0] == i)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Ａ");
            }
            else if (_PlayerPoint[1] == i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ｂ");
            }
            else
            {
                switch (_mapArray[i])
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("☆");
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("▲");
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("●");
                        break;
                    case 4:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("卍");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("□");
                        break;
                }
            }
        }
        #endregion
    }
}
