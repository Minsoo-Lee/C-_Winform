using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6강_주석
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private enum enumDay
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
        }

        private enum enumTime
        {
            Morning,
            Afternoom,
            Evening,
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lboxDay.Items.Add(enumDay.Monday);
            lboxDay.Items.Add(enumDay.Tuesday);
            lboxDay.Items.Add(enumDay.Wednesday);
            lboxDay.Items.Add(enumDay.Thursday);
            lboxDay.Items.Add(enumDay.Friday);
            lboxDay.Items.Add(enumDay.Saturday);
            lboxDay.Items.Add(enumDay.Sunday);

            lboxTime.Items.Add(enumTime.Morning);
            lboxTime.Items.Add(enumTime.Afternoom);
            lboxTime.Items.Add(enumTime.Evening);
        }

        private void btnResult1_Click_1(object sender, EventArgs e)
        {
            string strResult = tboxName.Text + "와 " + lboxDay.SelectedItem.ToString() + "(요일) " + lboxTime.SelectedItem.ToString() + "에 보기로 했습니다.";
            tboxResult.Text = strResult;
        }

        private void btnResult2_Click(object sender, EventArgs e)
        {
            // string strResult = string.Format("{0}와 {1}(요일) {2}에 보기로 했습니다.", tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            string strResult = TextLoad(tboxName.Text, lboxDay.SelectedItem.ToString(), lboxTime.SelectedItem.ToString());
            tboxResult.Text = strResult;
        }


        /// <summary>
        ///  준호와 Monday(요일) Afetrnoon에 보기로 했습니다. 같은 문자열을 만들어 줍니다.
        /// </summary>
        /// <param name="strName">이름</param>
        /// <param name="strDay">날짜</param>
        /// <param name="strTime">시간</param>
        /// <returns></returns>
        private string TextLoad(string strName, string strDay, string strTime)
        {
            string strText = string.Format("{0}와 {1}(요일) {2}에 보기로 했습니다.", strName, strDay, strTime);

            return strText;
        }
    }
}
