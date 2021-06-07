using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3강_프로그램의_기본과_Method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            //int iResult = iNumA + iNumB;
            //tboxResult.Text = iResult.ToString();

            tboxResult.Text = fPlus(iNumA, iNumB).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA - iNumB;

            tboxResult.Text = iResult.ToString();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA * iNumB;

            tboxResult.Text = iResult.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            int iNumA = int.Parse(tboxNum1.Text);
            int iNumB = int.Parse(tboxNum2.Text);

            int iResult = iNumA / iNumB;

            //int iResultB = iNumA % iNumB;

            tboxResult.Text = iResult.ToString();
        }

        private int fPlus(int iA, int iB)
        {            
            return iA+iB;
        }
    }
}
