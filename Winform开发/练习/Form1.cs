using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Player player = new Player();
        Computer computer = new Computer();

        private void PlayGame(string str)
        {
            lblPlayer.Text = str;

            int playerNumber = player.ShowFist(str);
            int computerNumber = computer.ShowFist();

            switch (computerNumber)
            {
                case 1:
                    lblComputer.Text = @"石头";
                    break;
                case 2:
                    lblComputer.Text = @"剪刀";
                    break;
                case 3:
                    lblComputer.Text = @"布";
                    break;
                default:
                    break;
            }

            Result result = Referee.Result(playerNumber, computerNumber);
            switch (result)
            {
                case Result.PlayerWin:
                    lblWinner.Text = "玩家";
                    break;
                case Result.ComputerWin:
                    lblWinner.Text = "电脑";
                    break;
                case Result.Deuce:
                    lblWinner.Text = "平局";
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "石头";
            PlayGame(str);
        }

        private void bScissors_Click(object sender, EventArgs e)
        {
            string str = "剪刀";
            PlayGame(str);
        }

        private void bCloth_Click(object sender, EventArgs e)
        {
            string str = "布";
            PlayGame(str);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
