using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15강_Capsule_PartialClass
{
    public partial class Form1 : Form
    {
        cData cD = new cData();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnumItem[] ei = (EnumItem[])Enum.GetValues(typeof(EnumItem));

            foreach (EnumItem oitem in ei)
            {
                cboxItem.Items.Add(oitem.ToString());
            }

            foreach (EnumRate oitem in (EnumRate[])Enum.GetValues(typeof(EnumRate)))
            {
                cboxRate.Items.Add(oitem.ToString());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cD.StrItem = cboxItem.Text;
            cD.IRate = (int)Enum.Parse(typeof(EnumRate), cboxRate.Text);
            cD.ICount = (int)numCount.Value;
        }
    }
}
