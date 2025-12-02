using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    internal class Coin : RandGen
    {
        public Coin()
        {
            Rmin = 0;
            Rmax = 2;
            // 난수 발생 범위: 0, 1(=2-1)
        }

        public static char ValToChar(int val) // static 메소드
        {
            switch (val)
            {
                case 0: return 'B'; // 뒷면: back
                case 1: return 'F'; // 앞면: front
                default: return ' ';
            }
        }
    }
}
