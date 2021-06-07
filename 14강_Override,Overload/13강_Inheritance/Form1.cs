using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14강_Override
{
    public partial class Form1 : Form
    {
        cOneCycle cOC;
        cCycle cC;
        cCar cCar;
        public Form1()
        {
            InitializeComponent();        
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cOC = new cOneCycle("외발 자전거");
            cC = new cCycle("자전거");
            cCar = new cCar("자동차");
        }

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            string dd = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fClearPanel();
            OneCycleDraw();
        }

        private void btnCycle_Click(object sender, EventArgs e)
        {
            fClearPanel();
            CycleDraw();
        }

        /// <summary>
        /// OneCycle에 대한 위치 그림을 그려준다
        /// </summary>

        private void OneCycleDraw()
        {
            lblName.Text = cOC.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = cOC.fPenInfo();
            g.DrawRectangle(p, cOC.rtSquare1);
            g.DrawEllipse(p, cOC.rtCircle1);
        }
        private void CycleDraw()
        {
            lblName.Text = cC.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = cC.fPenInfo();
            g.DrawRectangle(p, cC.rtSquare1);
            g.DrawEllipse(p, cC.rtCircle1);
            g.DrawEllipse(p, cC.rtCircle2);
        }
        private void CarDraw()
        {
            lblName.Text = cCar.strName;
            Graphics g = pMain.CreateGraphics();
            Pen p = cC.fPenInfo();
            g.DrawRectangle(p, cCar.rtSquare1);
            g.DrawRectangle(p, cCar.rtSquare2);
            g.DrawEllipse(p, cCar.rtCircle1);
            g.DrawEllipse(p, cCar.rtCircle2);
        }

        private void fClearPanel()
        {
            pMain.Invalidate();
            Refresh();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            fClearPanel();
            CarDraw();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            fClearPanel();
            cOC.fPenInfo(Color.Black, 5);

            switch (lblName.Text)
            {
                case "외발 자전거":
                    cOC.fMove(-5);
                    OneCycleDraw();
                    break;
                case "자전거":
                    cC.fMove(-5);
                    CycleDraw();
                    break;
                case "자동차":
                    cCar.fMove(-5);
                    CarDraw();
                    break;
            }
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            fClearPanel();
            switch (lblName.Text)
            {
                case "외발 자전거":
                    cOC.fMove(5);
                    OneCycleDraw();
                    break;
                case "자전거":
                    cC.fMove(5);
                    CycleDraw();
                    break;
                case "자동차":
                    cCar.fMove(5);
                    CarDraw();
                    break;
            }
        }

        
    }
}
