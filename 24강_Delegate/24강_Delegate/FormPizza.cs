using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24강_Delegate
{
    public partial class FormPizza : Form
    {

        public delegate int delPizzaCompelete(string strResult, int Time);
        public event delPizzaCompelete eventdelPizzaComplete; // delegate event 선언
        
        public FormPizza()
        {
            InitializeComponent();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        internal void PizzaCheck(Dictionary<string, int> dPizzaOrder)
        {
            //int iTime = 0;
            //string strType = string.Empty;
            int iTotalTime = 0;
            foreach (KeyValuePair<string, int> oOrder in dPizzaOrder)
            {
                int iNowTime = 0;
                string strType = string.Empty;
                int iTime = 0;
                int iCount = oOrder.Value; 
                switch (oOrder.Key) {
                    //도우
                    case "오리지널":
                        iNowTime = 3000;
                        strType = "도우";
                        break;
                    case "씬":
                        iNowTime = 3500;
                        strType = "도우";
                        break;
                    //엣지
                    case "리치골드":
                        iNowTime = 500;
                        strType = "엣지";
                        break;
                    case "치즈크러스트":
                        iNowTime = 400;
                        strType = "엣지";
                        break;
                    // 토핑
                    case "소세지":
                        iNowTime = 32;
                        strType = "토핑";
                        break;
                    case "감자":
                        strType = "토핑";
                        iNowTime = 17;
                        break;
                    case "치즈":
                        iNowTime = 48;
                        strType = "토핑";
                        break;

                    default:
                        break;
                }
                iTime = iNowTime * iCount;

                iTotalTime = iTotalTime + iTime;
                lboxMake.Items.Add(string.Format("{0}) {1}: {2}초 ({3}초, {4}개)", strType, oOrder.Key, iTime, iNowTime, iCount));

                Refresh();
                Thread.Sleep(1000);
            }

            eventdelPizzaComplete("Pizza가 완성되었습니다.", iTotalTime);

            lboxMake.Items.Add("-------------------------------");
            lboxMake.Items.Add("주문 완료 확인");
        }
    }
}
