using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _13강_Inheritance
{
    class cCycle : cBase
    {
        public Rectangle rtCircle1; // 바퀴
        public Rectangle rtCircle2; // 바퀴
        public Rectangle rtSquare1; // 몸통

        public cCycle(string sName)
        {
            strName = sName;
            pen = new Pen(Color.Black, 3);

            rtCircle1 = new Rectangle(30, 150, 120, 120);
            rtCircle2 = new Rectangle(210, 150, 120, 120);
            rtSquare1 = new Rectangle(60, 90, 240, 60);
        }

        public Pen fPenInfo()
        {
            return pen;
        }

        public void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
            fSquare1Move(iMove);
        }

        /// <summary>
        /// 내부에서만 움직인다.
        /// </summary>
        /// <param name="iMove"></param>
        protected void fCircle1Move(int iMove)
        {
            Point oPoint = rtCircle1.Location;
            oPoint.X = oPoint.X + iMove;
            rtCircle1.Location = oPoint;
        }
        protected void fCircle2Move(int iMove)
        {
            Point oPoint = rtCircle2.Location;
            oPoint.X = oPoint.X + iMove;
            rtCircle2.Location = oPoint;
        }

        protected void fSquare1Move(int iMove)
        {
            Point oPoint = rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            rtSquare1.Location = oPoint;
        }
    }
}
