using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    internal class Dice : RandGen
    {
        public Dice()
        {
            Rmin = 1;
            Rmax = 6 + 1;
            // 난수 발생 범위: 1~6
        }
    }
}
