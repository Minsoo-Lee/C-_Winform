using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2강_DataType
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            try
            {
                short sNum = short.Parse(tboxNumber.Text);
                lblShort.Text = sNum.ToString();
                lblException.Text = "-";
            }
            catch(Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnInt_Click(object sender, EventArgs e)
        {
            try
            {
                int sNum = int.Parse(tboxNumber.Text);
                lblInt.Text = sNum.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnDouble_Click(object sender, EventArgs e)
        {
            try
            {
                double sNum = double.Parse(tboxNumber.Text);
                lblDouble.Text = sNum.ToString();
                lblException.Text = "-";
            }
            catch (Exception ex)
            {
                lblException.Text = ex.ToString();
            }
        }

        private void btnExe_Click(object sender, EventArgs e)
        {
            short sNum = 0;
            int iNum = 0;
            double dNum = 0;

            lblException.Text = "-";
            if (short.TryParse(tboxNumber.Text, out sNum))
                lblShort.Text = sNum.ToString();
            else if (int.TryParse(tboxNumber.Text, out iNum))
                lblInt.Text = iNum.ToString();
            else if (double.TryParse(tboxNumber.Text, out dNum))
                lblDouble.Text = dNum.ToString();
            else
                lblException.Text = "변환 불가능";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            lblShort.Text = "-";
            lblInt.Text = "-";
            lblDouble.Text = "-";
            lblException.Text = "-";
        }
    }
}
