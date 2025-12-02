using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice19Main
{
    internal class RandGen : IRandGen
    {
        //// C++처럼 구현
        //// 필드로 구현
        //int rmin;
        //int rmax;
        //// 필드에 대한 getter, setter 정의 필요
        //public int GetRmin() { return rmin; }
        //public void SetRmin(int rmin) { this.rmin = rmin; }
        // C#은 프로퍼티로 간단하게 구현
        // 프로퍼티(property): 변수처럼 사용; 메소드처럼 정의
        public int Rmin { get; set; } = 0; // Rmin을 0으로 초기화
        public int Rmax { get; set; } = 1; // Rmax를 0으로 초기화

        public int GetRand()
        {
            return 0;
        }
    }
}
