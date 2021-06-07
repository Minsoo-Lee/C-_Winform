using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15강_Capsule_PartialClass
{
    /// <summary>
    /// 변수만
    /// </summary>
    partial class cData
    {
        private string strItem = string.Empty;
        private int iRate = 0;
        private int iCount = 0;

        public string StrItem {
            /*get => strItem;*/
            set {
                if (string.IsNullOrEmpty(value)) { strErrorName = "물건이 선택되지 않았습니다."; }
                else { strItem = value; }
            } 
        }

        public int IRate
        { /*get => iRate; */
            set
            {
                if (value > 20) { strErrorName = "사장님만 가능한 할인입니다."; }
                else { iRate = value; }
            }
        }

        public int ICount { /*get => iCount; */
            set
            {
                if (value > 5) { strErrorName = "개별 물품은 5개이상 살 수 없습니다."; }
                else if (value == 0) { strErrorName = "물품의 개수가 0개 입니다."; }
                else { iCount = value; }
            }
        }

        public string StrErrorName { get => strErrorName; /*set => strErrorName = value;*/ }

        private string strErrorName = string.Empty;
    }

    partial class cData
    {
        public double fItemPrice()
        {
            double dPrice = 0;
            int iItemPrice = 0;

            if (String.IsNullOrEmpty(strErrorName)) // Error가 없으면 정상 값들을 받음
            {
                iItemPrice = (int) Enum.Parse(typeof(EnumItem), strItem);

                dPrice = iItemPrice - Math.Round((double)iItemPrice * (double)iRate / 100, 2);
            }
            return dPrice * iCount;
        }
    }
}
