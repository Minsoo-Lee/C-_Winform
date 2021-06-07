using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _14강_Override
{
    class cOneCycle : cBase
    {
        public Rectangle rtCircle1; // 바퀴
        public Rectangle rtSquare1; // 몸통

        public cOneCycle(string sName)
        {
            strName = sName;
            pen = new Pen(Color.WhiteSmoke, 3);

            rtCircle1 = new Rectangle(120, 150, 120, 120);
            rtSquare1 = new Rectangle(150, 30, 60, 120);
        }

        public Pen fPenInfo()
        {
            return pen;
        }
        public Pen fPenInfo(Color oColor)
        {
            pen = new Pen(oColor);
            return pen;
        }

        public Pen fPenInfo(Color oColor, int iWidth)
        {
            pen = new Pen(oColor, iWidth);
            return pen;
        }

        /// <summary>
        /// 외부에서 호출 가능하도록
        /// </summary>
        /// <param name="iMove"></param>

        public virtual void fMove(int iMove)
        {
            fCircle1Move(iMove);
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

        protected void fSquare1Move(int iMove)
        {
            Point oPoint = rtSquare1.Location;
            oPoint.X = oPoint.X + iMove;
            rtSquare1.Location = oPoint;
        }
    }
}
