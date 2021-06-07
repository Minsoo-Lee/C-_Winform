using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _13강_Inheritance
{
    class cCar : cCycle
    {
        public Rectangle rtSquare2; // 몸통

        public cCar(string sName) : base(sName)
        {
            strName = sName;
            pen = new Pen(Color.Blue, 3);

            rtCircle1 = new Rectangle(30, 150, 120, 120);
            rtCircle2 = new Rectangle(210, 150, 120, 120);
            rtSquare1 = new Rectangle(60, 90, 240, 60);
            rtSquare2 = new Rectangle(30, 120, 300, 60);
        }

        public Pen fPenInfo()
        {
            return pen;
        }

        public new void fMove(int iMove)
        {
            fCircle1Move(iMove);
            fCircle2Move(iMove);
            fSquare1Move(iMove);
            fSquare2Move(iMove);
        }

        protected void fSquare2Move(int iMove)
        {
            Point oPoint = rtSquare2.Location;
            oPoint.X = oPoint.X + iMove;
            rtSquare2.Location = oPoint;
        }
    }
}
