using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _13강_Inheritance
{
    class cBase
    {
        public string strName;

        protected Pen pen;
        public cBase()
        {
            pen = new Pen(Color.Aqua);
        }
    }
}
