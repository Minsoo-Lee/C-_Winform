using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24강_Delegate
{
    public partial class Form1 : Form
    {
        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int Ea);
        public delegate T delfunc<T>(T i);
        int iTotalPrice;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }
        #region Function

        /// <summary>
        /// 0: 선택안함, 1: 오리지널, 2: 씬
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fDow(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if(iOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널을 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }
            fLbox(strOrder);
            return iTotalPrice += iPrice;
        }
        /// <summary>
        /// 0: 선택안함, 1: 리치골드, 2: 치즈크러스트
        /// </summary>
        /// <param name="iOrder"></param>
        /// <returns></returns>
        private int fEdge(int iOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드를 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("도우는 치즈크러스트를 선택하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "엣지는 선택하지 않았습니다.";
            }
            fLbox(strOrder);
            return iTotalPrice += iPrice;
        }

        public int fCallBackDelegate(int i, delFuncDow_Edge dFunc)
        {
            return dFunc(i);
        }

        private int fTopping1 (string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;

            strOrder = string.Format("소세지 {0} {1}개를 선택하였습니다: ({2}원 (1ea 500원)", Order, iEa, iPrice);

            fLbox(strOrder);

            return iTotalPrice += iPrice;


        }

        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("감자 {0} {1}개를 선택하였습니다: ({2}원 (1ea 200원)", Order, iEa, iPrice);

            fLbox(strOrder);

            return iTotalPrice += iPrice;


        }

        private int fTopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("치즈 {0} {1}개를 선택하였습니다: ({2}원 (1ea 300원)", Order, iEa, iPrice);

            fLbox(strOrder);

            return iTotalPrice += iPrice;


        }

        private void fLbox(string strOrder)
        {
            lboxOrder.Items.Add(strOrder);
        }
        #endregion

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dPizzaOrder = new Dictionary<string, int> (); // Pizza 주문을 담을 그릇

            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);
            delFuncTopping delTopping = null;


            int iDowOrder = 0;
            int iEdgeOrder = 0;
            // Dow 선택
            if (rdDow1.Checked)
            {
                iDowOrder = 1;
                dPizzaOrder.Add("오리지널", 1);
            }
            else if (rdDow2.Checked)
            {
                iDowOrder = 2;
                dPizzaOrder.Add("씬", 1);
            }

            delDow(iDowOrder);

            // Edge 선택
            if (rdEdge1.Checked)
            {
                iEdgeOrder = 1;
                dPizzaOrder.Add("리치골드", 1);
            }
            else if (rdEdge2.Checked)
            {
                iEdgeOrder = 2;
                dPizzaOrder.Add("치즈크러스트", 1);
            }

            delEdge(iEdgeOrder);

            if (cboxTop1.Checked) { delTopping += fTopping1; dPizzaOrder.Add("소세지", (int)numEa.Value); }
            if (cboxTop2.Checked) { delTopping += fTopping2; dPizzaOrder.Add("감자", (int)numEa.Value); }
            if (cboxTop3.Checked) { delTopping += fTopping3; dPizzaOrder.Add("치즈", (int)numEa.Value); }

            delTopping("토핑", (int)numEa.Value);

            fLbox("---------------------------------------------");
            fLbox(string.Format("전체 주문 가격은 {0}원 입니다.", iTotalPrice));

            frmLoad(dPizzaOrder);

        }

        FormPizza fPizza;

        #region event 예제
        
        private void frmLoad(Dictionary<string, int> dPizzaOrder )
        {
            if (fPizza != null) { fPizza.Dispose(); fPizza = null; }


            fPizza = new FormPizza();
            fPizza.eventdelPizzaComplete += FPizza_eventDelPizzaComplete;
            fPizza.Show();

            fPizza.PizzaCheck(dPizzaOrder);
        }

        private int FPizza_eventDelPizzaComplete(string strResult, int iTime)
        {
            fLbox("---------------------------------------------");
            fLbox(string.Format("{0} / 걸린 시간: {1}", strResult, iTime));

            return 0;
        }
        #endregion

    }
}
