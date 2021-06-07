using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8강_ifSwitch
{
    public partial class cbox : Form
    {
        public cbox()
        {
            InitializeComponent();
        }
               
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnifResult_Click(object sender, EventArgs e)
        {
            int inumber1 = (int)nNumber1.Value;
            int inumber2 = (int)nNumber2.Value;
            if (inumber1 > inumber2)
            {
                lblifResult.Text = string.Format("- Number1이 Number2보다 {0} 더 큽니다.", inumber1 - inumber2);
            } else if (inumber1 < inumber2)
            {
                lblifResult.Text = string.Format("- Number2이 Number1보다 {0} 더 큽니다.", inumber2 - inumber1);
            }
            else
            {
                lblifResult.Text = string.Format("- 두 숫자는 같습니다. 숫자 : {0}", inumber1);
            }    
        }

        private void btnswitchResult_Click(object sender, EventArgs e)
        {
            string strSelect = cboxDay.Text;

            switch (strSelect)
            {
                case "월":
                    lblswitchResult.Text = "- 선택 날짜는 월요일 입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "- 선택 날짜는 화요일 입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "- 선택 날짜는 수요일 입니다.";
                    break;
                case "목":
                case "금":
                    lblswitchResult.Text = "- 선택 날짜는 목요일 또는 금요일 입니다.";
                    break;
                default:
                    lblswitchResult.Text = "- 선택 날짜는 주말 입니다.(토요일, 일요일)";
                    break;
            }

        }
    }
}
