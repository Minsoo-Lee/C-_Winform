using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _14강_Override
{
    class cCycle : cOneCycle
    {
        public Rectangle rtCircle2; // 바퀴

        public cCycle(string sName) : base(sName)
        {
            strName = sName;
            pen = new Pen(Color.Black, 3);

            rtCircle1 = new Rectangle(30, 150, 120, 120);
            rtCircle2 = new Rectangle(210, 150, 120, 120);
            rtSquare1 = new Rectangle(60, 90, 240, 60);
        }

        public override void fMove(int iMove)
        {
            base.fMove(iMove);
            fCircle2Move(iMove);
        }

        protected void fCircle2Move(int iMove)
        {
            Point oPoint = rtCircle2.Location;
            oPoint.X = oPoint.X + iMove;
            rtCircle2.Location = oPoint;
        }
    }
}
