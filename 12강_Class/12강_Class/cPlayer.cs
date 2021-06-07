using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12강_Class
{
    class classPlayer
    {

        int iTest = 0;
        public classPlayer() { iTest = 1; }
        ~classPlayer() { iTest = 0; }

        public int iCardSum = 0;
        //값들을 더해서 반환

        
        public int CardSum(int iSun, int iMoon, int iStar)
        {
            return iSun + iMoon + iStar;
        }

        public string ResultText(int iCardSum, int iSun, int iMoon, int iStar, int iCount)
        {
            return string.Format("{0}회 진행 후) 해: {1}, 달: {2}, 별: {3}  //  합계는 {4}입니다.", iCount, iSun, iMoon, iStar, iCardSum);
        }
        
        public string PlayerPair(int iCount, int iP1Cardsum, int iP2CardSum)
        {
            int iCheck = iP1Cardsum - iP2CardSum;
            if (iCheck > 0)
            {
                return string.Format("{0}회차 : Player1이 {1}만큼 더 큽니다", iCount, iCheck);
            }
            else if (iCheck < 0)
            {
                return string.Format("{0}회차 : Player2가 {1}만큼 더 큽니다", iCount, Math.Abs(iCheck));
            }
            else
            {
                return string.Format("{0}회차 : Player1과 Player2의 값이 같습니다.", iCount);
            }
        }

        public string PlayerResult(int iP1CardSum, int iP2CardSum)
        {

            string strReturn = string.Empty;
            if (iP1CardSum > iP2CardSum) strReturn = "Player 1번이 이겼습니다.";
            else if (iP1CardSum < iP2CardSum) strReturn = "Player 2번이 이겼습니다.";
            else strReturn = "비겼습니다.";

            return strReturn;
        }
    }
}
