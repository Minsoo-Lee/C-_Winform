using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12강_Class
{
    public partial class Form1 : Form
    {
        
        struct structPlayer
        {
            // 필드값
            public int iCount;

            public int iSun;
            public int iMoon;
            public int iStar;

            public int iCardSum;
            /*public int CardSum(int iSum, int iMoon, int iStar)
            {
                return iSun + iMoon + iStar;
            }

            public string ResultText(int iCardSum)
            {
                return string.Format("{0}회 진행 후) 해: {1}, 달: {2}, 별: {3}  //  합계는 {4}입니다.", iCount, iSun, iMoon, iStar, iCardSum);
            }*/
        }
        

        


        Random rd = new Random();
        structPlayer stPlayer1;
        structPlayer stPlayer2;

        // classPlayer clPlayer1 = new classPlayer();
        // classPlayer clPlayer2 = new classPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void pboxSun_Click(object sender, EventArgs e)
        {
            int iNumber = rd.Next(1, 21);
            if (rdPlayer1.Checked) stPlayer1.iSun = iNumber;
            else stPlayer2.iSun = iNumber;
            Result();
        }

        private void pboxMoon_Click(object sender, EventArgs e)
        {
            int iNumber = rd.Next(1, 21);
            if (rdPlayer1.Checked) stPlayer1.iMoon = iNumber;
            else stPlayer2.iMoon = iNumber;
            Result();
        }

        private void pboxStar_Click(object sender, EventArgs e)
        {
            int iNumber = rd.Next(1, 21);
            if (rdPlayer1.Checked) stPlayer1.iStar = iNumber;
            else stPlayer2.iStar = iNumber;
            Result();
        }

        private void pboxNone_Click(object sender, EventArgs e)
        {
            Result();
        }

        private void iCheckChange()
        {
            if (rdPlayer1.Checked) rdPlayer2.Checked = true;
            else rdPlayer1.Checked = true;
        }

        _12강_Class.classPlayer cPlayer = new _12강_Class.classPlayer();

        private void Result()
        {
            string strResult = string.Empty;
            int iCardSum = 0;

            if (rdPlayer1.Checked)
            {
                stPlayer1.iCount++;

                stPlayer1.iCardSum = cPlayer.CardSum(stPlayer1.iSun, stPlayer1.iMoon, stPlayer1.iStar);
                strResult = cPlayer.ResultText(stPlayer1.iCardSum, stPlayer1.iSun, stPlayer1.iMoon, stPlayer1.iStar, stPlayer1.iCount);

                lboxResult1.Items.Add(strResult);
            }
            else
            {
                stPlayer2.iCount++;

                stPlayer2.iCardSum = cPlayer.CardSum(stPlayer2.iSun, stPlayer2.iMoon, stPlayer2.iStar);
                strResult = cPlayer.ResultText(stPlayer2.iCardSum, stPlayer2.iSun, stPlayer2.iMoon, stPlayer2.iStar, stPlayer2.iCount);

                lboxResult2.Items.Add(strResult);
            }
            iCheckChange();

            if (stPlayer1.iCount == stPlayer2.iCount)
            {
                lboxNow.Items.Add(cPlayer.PlayerPair(stPlayer2.iCount, stPlayer1.iCardSum, stPlayer2.iCardSum));

                if (stPlayer2.iCount >= 5)
                {
                    lboxNow.Items.Add(cPlayer.PlayerResult(stPlayer1.iCardSum, stPlayer2.iCardSum));
                }
            }

            /*
            if (stPlayer1.iCount >= 5 && stPlayer2.iCount >= 5)
            {
                cPlayer
            }*/

            
        }
    }
}
