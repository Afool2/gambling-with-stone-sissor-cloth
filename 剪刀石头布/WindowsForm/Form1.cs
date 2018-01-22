using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        

        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="playerCard">玩家的牌</param>
        /// <param name="layerCardNum">玩家牌对应的数字</param>
        public  void PlayGame(string playerCard, int layerCardNum)
        {
            lblMyCard.Text = playerCard;
            string cpucard;
            lblJudge.Text = Judge(layerCardNum, ShowCpuCard(out cpucard));
            lblCpuCard.Text = cpucard;
        }

        /// <summary>
        /// 电脑出牌
        /// </summary>
        /// <param name="card">电脑出的牌</param>
        /// <returns>电脑出牌对应的数字。石头--2，剪刀--1，布--0</returns>
        public static int ShowCpuCard(out string card)
        {
            Random r = new Random();
            int cardNum = r.Next(0, 3);
            card = "";
            switch (cardNum)
            {
                case 0:
                    card = "布";
                    break;
                case 1:
                    card = "剪刀";
                    break;
                case 2:
                    card = "石头";
                    break;
            }
            return cardNum;
        }

        /// <summary>
        /// 判断输赢。
        /// </summary>
        /// <param name="playerCardNum">玩家出牌代表的数字,石头--2，剪刀--1，布--0</param>
        /// <param name="cpuCardNum">电脑出牌代表的数字,石头--2，剪刀--1，布--0</param>
        /// <returns></returns>
        public static string Judge(int playerCardNum, int cpuCardNum)
        {
            switch (playerCardNum - cpuCardNum)
            {
                case 1:
                case -2:
                    return "玩家赢";
                case 0:
                    return "平手";
                default:
                    return "电脑赢";
            }
        }

        

        private void btnStone_Click(object sender, EventArgs e)
        {
            PlayGame("石头", 2);
        }

        private void btnSissor_Click(object sender, EventArgs e)
        {
            PlayGame("剪刀", 1);
        }

        private void btnCloth_Click(object sender, EventArgs e)
        {
            PlayGame("布", 0);

        }
    }
}
